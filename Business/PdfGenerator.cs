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
                PdfPTable table = new PdfPTable(5); // 5 Columnas
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 2.5f, 1f, 1f, 1.5f, 1.5f }); // Anchos ajustados

                // Encabezados
                PdfPCell h1 = new PdfPCell(new Phrase("Clase", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5f };
                PdfPCell h2 = new PdfPCell(new Phrase("Días", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5f }; 
                PdfPCell h3 = new PdfPCell(new Phrase("Desc.", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5f }; 
                PdfPCell h4 = new PdfPCell(new Phrase("Monto por día", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5f };
                PdfPCell h5 = new PdfPCell(new Phrase("Subtotal", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5f }; // Monto ajustado


                table.AddCell(h1);
                table.AddCell(h2);
                table.AddCell(h3);
                table.AddCell(h4);
                table.AddCell(h5);

                // --- 4. MEJORA: Filas Alternadas (Zebra-striping) ---
                bool zebra = false;
                var colorZebra = new BaseColor(245, 245, 245); // Un gris muy claro

                foreach (var d in detalles)
                {
                    PdfPCell c1 = new PdfPCell(new Phrase(d.ClaseNombre, fontTableCell));
                    PdfPCell c2 = new PdfPCell(new Phrase(CantDays(nameMembership).ToString(), fontTableCell)); // Nueva celda
                    PdfPCell c3 = new PdfPCell(new Phrase($"-{Porcetentaul(CantDays(nameMembership), d.Monto):F2}", fontTableCell)); // Nueva celda
                    PdfPCell c4 = new PdfPCell(new Phrase($"${d.Monto:F2}", fontTableCell));
                    PdfPCell c5 = new PdfPCell(new Phrase($"${(SubTotal(CantDays(nameMembership), d.Monto)):F2}", fontTableCell));


                    c1.HorizontalAlignment = Element.ALIGN_LEFT;
                    c2.HorizontalAlignment = Element.ALIGN_CENTER; // Alineación central para días
                    c3.HorizontalAlignment = Element.ALIGN_RIGHT; // Alineación derecha para descuento
                    c4.HorizontalAlignment = Element.ALIGN_RIGHT;
                    c5.HorizontalAlignment = Element.ALIGN_RIGHT;

                    c1.Padding = 4f; c2.Padding = 4f; c3.Padding = 4f; c4.Padding = 4f;
                    c1.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                    c2.Border = Rectangle.RIGHT_BORDER; // Borde derecho para días
                    c3.Border = Rectangle.RIGHT_BORDER; // Borde derecho para descuento
                    c4.Border = Rectangle.RIGHT_BORDER; // Borde derecho para monto
                    c5.Border = Rectangle.RIGHT_BORDER;

                    // Aplicamos el color de fondo alternado
                    if (zebra)
                    {
                        c1.BackgroundColor = colorZebra;
                        c2.BackgroundColor = colorZebra;
                        c3.BackgroundColor = colorZebra; // Color para descuento
                        c4.BackgroundColor = colorZebra; // Color para monto
                        c5.BackgroundColor = colorZebra;
                    }

                    table.AddCell(c1);
                    table.AddCell(c2);
                    table.AddCell(c3);
                    table.AddCell(c4);
                    table.AddCell(c5);
                    zebra = !zebra; // Alternamos
                }

                // --- 5. MEJORA: Línea Separadora Limpia ---
                // Celda que abarca 4 columnas solo con borde superior
                PdfPCell totalLabel = new PdfPCell(new Phrase("Total", fontTotal)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = Rectangle.NO_BORDER, PaddingTop = 8f, PaddingRight = 10f, Colspan = 4 }; 
                PdfPCell totalValue = new PdfPCell(new Phrase($"${total:F2}", fontTotal)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = Rectangle.NO_BORDER, PaddingTop = 8f };
                table.AddCell(totalLabel);
                table.AddCell(totalValue);

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                

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

        //sobrecarga del metodo para usarlo desde instancias
        public void GeneratePaymentReceipt(string filePath, int pagoId, string socioNombre, string nameMembership, DateTime fecha, decimal total, IList<PaymentPdfDetail> detalles)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    var fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    var fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    var fontSub = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                    var fontTableHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.WHITE);
                    var fontTableCell = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    var fontTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                    // --- Título ---
                    Paragraph title = new Paragraph("Comprobante de Pago", fontTitle);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 20f;
                    doc.Add(title);

                    // --- Tabla de Información ---
                    PdfPTable infoTable = new PdfPTable(2);
                    infoTable.WidthPercentage = 100;
                    infoTable.SetWidths(new float[] { 1f, 3f });
                    infoTable.DefaultCell.Border = Rectangle.NO_BORDER;

                    infoTable.AddCell(new Phrase("Pago N°:", fontHeader));
                    infoTable.AddCell(new Phrase(pagoId.ToString(), fontSub));
                    infoTable.AddCell(new Phrase("Socio:", fontHeader));
                    infoTable.AddCell(new Phrase(socioNombre, fontSub));
                    infoTable.AddCell(new Phrase("Membresía:", fontHeader));
                    infoTable.AddCell(new Phrase(nameMembership, fontSub));
                    infoTable.AddCell(new Phrase("Fecha:", fontHeader));
                    infoTable.AddCell(new Phrase(fecha.ToString("dd/MM/yyyy"), fontSub));

                    infoTable.SpacingAfter = 25f;
                    doc.Add(infoTable);

                    // --- Tabla de Detalles ---
                    PdfPTable table = new PdfPTable(5); // 4 Columnas
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 2.5f, 1f, 1f, 1.5f, 1.5f }); // Anchos ajustados

                    // Encabezados
                    PdfPCell h1 = new PdfPCell(new Phrase("Clase", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5f };
                    PdfPCell h2 = new PdfPCell(new Phrase("Días", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5f }; // Nuevo encabezado
                    PdfPCell h3 = new PdfPCell(new Phrase("Desc.", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5f }; // Nuevo encabezado
                    PdfPCell h4 = new PdfPCell(new Phrase("Monto por día", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5f }; // Monto ajustado
                    PdfPCell h5 = new PdfPCell(new Phrase("Subtotal", fontTableHeader)) { BackgroundColor = new BaseColor(60, 60, 60), HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5f }; // Monto ajustado


                    table.AddCell(h1);
                    table.AddCell(h2);
                    table.AddCell(h3);
                    table.AddCell(h4);
                    table.AddCell(h5);


                    // Filas de detalles
                    // No se incluye zebra-striping en esta sobrecarga original, solo se actualizan las celdas
                    foreach (var d in detalles)
                    {
                        var monto = d.Monto; // Guardamos el monto original
                        PdfPCell c1 = new PdfPCell(new Phrase(d.ClaseNombre, fontTableCell)) { HorizontalAlignment = Element.ALIGN_LEFT };
                        PdfPCell c2 = new PdfPCell(new Phrase(CantDays(nameMembership).ToString(), fontTableCell)) { HorizontalAlignment = Element.ALIGN_CENTER }; 
                        PdfPCell c3 = new PdfPCell(new Phrase($"-{Porcetentaul(CantDays(nameMembership), d.Monto * CantDays(nameMembership)):F2}", fontTableCell)) { HorizontalAlignment = Element.ALIGN_RIGHT }; 
                        PdfPCell c4 = new PdfPCell(new Phrase($"${d.Monto:F2}", fontTableCell)) { HorizontalAlignment = Element.ALIGN_RIGHT };
                        PdfPCell c5 = new PdfPCell(new Phrase($"${(SubTotal(CantDays(nameMembership), d.Monto)):F2}", fontTableCell)) { HorizontalAlignment = Element.ALIGN_RIGHT };


                        table.AddCell(c1);
                        table.AddCell(c2);
                        table.AddCell(c3);
                        table.AddCell(c4);
                        table.AddCell(c5);
                    }


                    // --- Total ---
                    PdfPCell totalLabel = new PdfPCell(new Phrase("Total", fontTotal)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = Rectangle.NO_BORDER, PaddingTop = 8f, PaddingRight = 10f, Colspan = 4 }; // Colspan ajustado a 3
                    PdfPCell totalValue = new PdfPCell(new Phrase($"${total:F2}", fontTotal)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = Rectangle.NO_BORDER, PaddingTop = 8f };
                    table.AddCell(totalLabel);
                    table.AddCell(totalValue);

                    doc.Add(table);
                    doc.Add(new Paragraph(" "));

                    // --- Pie de Página ---
                    var line = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -1f);
                    doc.Add(new Chunk(line));
                    Paragraph footer = new Paragraph("\nGracias por su pago.", fontSub) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(footer);

                    doc.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo generar el PDF en la ruta: {filePath}", ex);
            }
        }

        private static decimal SubTotal(int pDias, decimal pTotal)
        {
            switch (pDias)
            {       
                case 7: return pTotal *= pDias * 0.9m;     // Semanal 10% off.
                case 30: return pTotal *= pDias * 0.8m; 
                default: return pTotal *= 1;
            }
        }

        private static decimal Porcetentaul(int pDias, decimal pTotal)
        {
            switch (pDias)
            {    
                case 7: return pTotal * 0.1m;         // Semanal 10% off.
                case 30: return pTotal * 0.2m;  // Mensual 20% off.
                default: return 0m;
            }
        }

        private static int CantDays(string pMembership)
        {
            switch (pMembership)
            {
                case "Semanal": return 7;         
                case "Mensual": return 30;  
                default: return 1;
            }
        }
    }

    
}