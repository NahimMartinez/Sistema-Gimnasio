using Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{

    public class PdfGenerator
    {
        public static string GenerarComprobantePDF(int pagoId, string socioNombre, string nameMembership, DateTime fecha,
                                           decimal total, IList<PaymentPdfDetail> detalles)
        {
            var path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"Comprobante_{pagoId}.pdf");
            using (var fs = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                doc.Open();

                doc.Add(new iTextSharp.text.Paragraph("Comprobante de Pago"));
                doc.Add(new iTextSharp.text.Paragraph($"Pago #{pagoId}"));
                doc.Add(new iTextSharp.text.Paragraph($"Socio: {socioNombre}"));
                doc.Add(new iTextSharp.text.Paragraph($"Membresía: {nameMembership}"));
                doc.Add(new iTextSharp.text.Paragraph($"Fecha: {fecha:dd/MM/yyyy}"));
                doc.Add(new iTextSharp.text.Paragraph($"Total: ${total:F2}"));
                doc.Add(new iTextSharp.text.Paragraph(" "));

                var table = new iTextSharp.text.pdf.PdfPTable(2);
                table.AddCell("Clase");
                table.AddCell("Monto");
                foreach (var d in detalles)
                {
                    table.AddCell(d.ClaseNombre);
                    table.AddCell($"${d.Monto:F2}");
                }
                doc.Add(table);
                doc.Close();
            }
            return path;
        }


    }
}
