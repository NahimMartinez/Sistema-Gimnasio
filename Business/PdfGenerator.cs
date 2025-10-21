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
            string filePath = $"Comprobante_{pagoId}.pdf";
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // --- Definición de Fuentes ---
                var fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                var fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var fontSub = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                var fontTableHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.WHITE);
                var fontTableCell = FontFactory.GetFont(FontFactory.HELVETICA, 10); // Un poco más pequeño para más espacio
                var fontTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                // --- 1. MEJORA: Logotipo y Título ---
                // Intenta cargar un logo. Si no existe, simplemente lo omite.
                try
                {
                    // Cambia "path/to/your/logo.png" por la ruta real de tu logo
                    string logoPath = "path/to/your/logo.png";
                    if (File.Exists(logoPath))
                    {
                        Image logo = Image.GetInstance(logoPath);
                        logo.ScaleToFit(120f, 60f); // Ajusta el tamaño
                        logo.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(logo);
                    }
                }
                catch (Exception)
                {
                    // Opcional: registrar el error si el logo no se carga
                }

                Paragraph title = new Paragraph("Comprobante de Pago", fontTitle);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; // MEJORA: Espaciado controlado
                doc.Add(title);

                
                // Usamos una tabla sin bordes para alinear la información del socio.
                PdfPTable infoTable = new PdfPTable(2);
                infoTable.WidthPercentage = 100;
                infoTable.SetWidths(new float[] { 1f, 3f });
                infoTable.DefaultCell.Border = Rectangle.NO_BORDER;

                // Añadimos celdas de etiqueta (negrita) y valor
                infoTable.AddCell(new Phrase("Pago N°:", fontHeader));
                infoTable.AddCell(new Phrase(pagoId.ToString(), fontSub));

                infoTable.AddCell(new Phrase("Socio:", fontHeader));
                infoTable.AddCell(new Phrase(socioNombre, fontSub));

                infoTable.AddCell(new Phrase("Membresía:", fontHeader));
                infoTable.AddCell(new Phrase(nameMembership, fontSub));

                infoTable.AddCell(new Phrase("Fecha:", fontHeader));
                infoTable.AddCell(new Phrase(fecha.ToString("dd/MM/yyyy"), fontSub));

                // Ajustamos el espaciado después de esta tabla
                infoTable.SpacingAfter = 25f;
                doc.Add(infoTable);


                // --- 3. Tabla de Detalles (con mejoras) ---
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 3f, 1f });

                // Encabezado (como lo tenías, está bien)
                PdfPCell h1 = new PdfPCell(new Phrase("Clase ", fontTableHeader));
                PdfPCell h2 = new PdfPCell(new Phrase("Monto por dia", fontTableHeader));
                h1.BackgroundColor = new BaseColor(60, 60, 60);
                h2.BackgroundColor = new BaseColor(60, 60, 60);
                h1.HorizontalAlignment = Element.ALIGN_CENTER;
                h2.HorizontalAlignment = Element.ALIGN_CENTER;
                h1.Padding = 5f;
                h2.Padding = 5f;
                table.AddCell(h1);
                table.AddCell(h2);

                // --- 4. MEJORA: Filas Alternadas (Zebra-striping) ---
                bool zebra = false;
                var colorZebra = new BaseColor(245, 245, 245); // Un gris muy claro

                foreach (var d in detalles)
                {
                    PdfPCell c1 = new PdfPCell(new Phrase(d.ClaseNombre, fontTableCell));
                    PdfPCell c2 = new PdfPCell(new Phrase($"${d.Monto:F2}", fontTableCell));

                    c1.HorizontalAlignment = Element.ALIGN_LEFT;
                    c2.HorizontalAlignment = Element.ALIGN_RIGHT;
                    c1.Padding = 4f;
                    c2.Padding = 4f;
                    c1.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                    c2.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;

                    // Aplicamos el color de fondo alternado
                    if (zebra)
                    {
                        c1.BackgroundColor = colorZebra;
                        c2.BackgroundColor = colorZebra;
                    }

                    table.AddCell(c1);
                    table.AddCell(c2);
                    zebra = !zebra; // Alternamos
                }

                // --- 5. MEJORA: Línea Separadora Limpia ---
                // Celda que abarca 2 columnas solo con borde superior
                PdfPCell separatorCell = new PdfPCell(new Phrase(" "));
                separatorCell.Colspan = 2;
                separatorCell.Border = Rectangle.TOP_BORDER;
                separatorCell.Padding = 0;
                separatorCell.FixedHeight = 1f; // Altura mínima
                table.AddCell(separatorCell);

                // --- Total (como lo tenías, pero usando la fuente 'fontTotal') ---
                PdfPCell totalLabel = new PdfPCell(new Phrase("Total", fontTotal));
                totalLabel.HorizontalAlignment = Element.ALIGN_RIGHT;
                totalLabel.Border = Rectangle.NO_BORDER;
                totalLabel.PaddingTop = 8f;
                totalLabel.PaddingRight = 10f;

                PdfPCell totalValue = new PdfPCell(new Phrase($"${total:F2}", fontTotal));
                totalValue.HorizontalAlignment = Element.ALIGN_RIGHT;
                totalValue.Border = Rectangle.NO_BORDER;
                totalValue.PaddingTop = 8f;

                table.AddCell(totalLabel);
                table.AddCell(totalValue);

                doc.Add(table);
                doc.Add(new Paragraph(" ")); // Espacio

                // --- 6. MEJORA: Pie de Página con Línea ---
                var line = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -1f);
                doc.Add(new Chunk(line));

                Paragraph footer = new Paragraph("\nGracias por su pago.", fontSub);
                footer.Alignment = Element.ALIGN_CENTER;
                doc.Add(footer);

                doc.Close();
            }
            return filePath;

        }
    }
}
