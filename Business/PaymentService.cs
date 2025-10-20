using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                nameMembership: h.Membresia ?? "-",
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
    }
}
