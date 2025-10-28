using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business
{
    public class PaymentService
    {
        private readonly PaymentRepository paymentRepository = new PaymentRepository();
        
        public List<PaymentMethod> GetPaymentMethods()
        {
            return paymentRepository.GetPaymentMethods();
        }

        public decimal GetTotalGeneratedService() 
        {
            return paymentRepository.GetTotalGenerated();
        }

        public List<dynamic> GetTotalXMonthService()
        {
            return paymentRepository.GetTotalXMonth(); 
        }

        public string GenerateReceipt(int pagoId, bool autoPrint = true)
        {
            // 1) Trae encabezado + detalle desde BD
            var (h, d) = paymentRepository.GetReceipt(pagoId);

            // 2) Mapea a detalle para el PDF
            var detail = d.Select(x => new PaymentPdfDetail
            {
                ClaseNombre = x.ClaseNombre,
                Monto = x.Monto
            }).ToList();

            // 3) Genera PDF
            var pdfPath = PdfGenerator.GenerarComprobantePDF(
                pagoId: h.PagoId,
                socioNombre: h.SocioNombre,
                nameMembership: h.Membresia,
                fecha: h.Fecha,
                total: h.Total,
                detalles: detail
            );

            // 4) Imprime  
            if (autoPrint)
            {
                try
                {
                    var psi = new ProcessStartInfo(pdfPath) { UseShellExecute = true, Verb = "open" };
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    // registra o informa si querés
                    Debug.WriteLine("Print error: " + ex.Message);
                }
            }


            return pdfPath;
        }

        public int GetLastPaymentPartnerService(int pPartner)
        {
            return paymentRepository.GetLastPaymentPartner(pPartner);
        }

        public int GenerateAllPaymentReceiptsForPartner(int partnerId, string outputFolder)
        {
            if (string.IsNullOrWhiteSpace(outputFolder))
                throw new ArgumentException("Debe proporcionar la ruta de la carpeta donde guardar los comprobantes.", nameof(outputFolder));

            if (!Directory.Exists(outputFolder))
                throw new DirectoryNotFoundException($"La carpeta especificada no existe: {outputFolder}");

            // 1. Obtenemos TODOS los IDs de pago del socio desde el repositorio
            var paymentIds = paymentRepository.GetAllPaymentIdsByPartner(partnerId);

            if (paymentIds == null || !paymentIds.Any())
            {
                // No hay pagos -> devuelve 0
                return 0;
            }

            int generatedCount = 0;
            var pdfGenerator = new PdfGenerator(); // Creamos una instancia del generador de PDF

            // 3. Recorremos cada ID de pago
            foreach (var paymentId in paymentIds)
            {
                try
                {
                    // Obtenemos los datos para este pago específico usando tu método existente
                    var (h, d) = paymentRepository.GetReceipt(paymentId);

                    if (h != null && d != null && d.Any())
                    {
                        // Mapeamos los detalles
                        var detail = d.Select(x => new PaymentPdfDetail
                        {
                            ClaseNombre = x.ClaseNombre,
                            Monto = x.Monto
                        }).ToList();

                        // Creamos un nombre de archivo único para cada PDF
                        string safePartnerName = string.Join("_", h.SocioNombre.Split(Path.GetInvalidFileNameChars()));
                        string fileName = $"Comprobante_{safePartnerName}_Pago_{paymentId}_{h.Fecha:yyyyMMdd}.pdf";
                        string fullPath = Path.Combine(outputFolder, fileName);

                        // Llamamos al método del generador de PDF
                        pdfGenerator.GeneratePaymentReceipt(fullPath, h.PagoId, h.SocioNombre, h.Membresia ?? "-", h.Fecha, h.Total, detail);
                        generatedCount++;
                    }
                }
                catch (Exception ex)
                {
                    // Si falla un PDF, podemos registrar el error y continuar con los demás
                    Debug.WriteLine($"Error al generar PDF para el pago ID {paymentId}: {ex.Message}");
                }
            }

            return generatedCount;
        }
    }
}
