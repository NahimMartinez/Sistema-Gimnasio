using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Sistema_Gimnasio
{
    public class ActionColumn
    {
        private readonly DataGridView dgv; // grilla destino
        private readonly string colName; // nombre de la col de acciones
        private readonly string colId; // nombre de la col ID (oculta o no)

        // Eventos que exponés hacia afuera. Enviás el ID de la fila.
        public event Action<object> OnEdit;
        public event Action<object> OnView;
        public event Action<object> OnDelete;

        // Métricas de layout de los botones dibujados.
        private readonly Padding P = new Padding(6, 4, 6, 4);
        private const int BtnW = 28, BtnH = 24, Gap = 6;

        // Íconos cacheados en bitmaps para no dibujar FontAwesome cada vez.
        private static Bitmap ICON_EDIT;
        private static Bitmap ICON_VIEW;
        private static Bitmap ICON_DELETE;


        public ActionColumn(DataGridView pDgv, string idColumnName, string accionesColumnName = "Actions")
        {
            dgv = pDgv ?? throw new ArgumentNullException(nameof(pDgv));
            colId = idColumnName ?? throw new ArgumentNullException(nameof(idColumnName));
            colName = accionesColumnName ?? "Actions";

            if (!dgv.Columns.Contains(colId))
                throw new ArgumentException("Falta columna de ID oculta: " + colId);

            // Crea la columna de acciones si no existe.
            if (!dgv.Columns.Contains(colName))
                dgv.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = colName,
                    HeaderText = "Acciones",
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable, // no ordenable
                    Width = 3 * BtnW + 2 * Gap + P.Horizontal           // ancho justo
                });

            // Cachea íconos una sola vez.
            EnsureIcons();

            // Suscripción a eventos de dibujo y mouse.
            dgv.CellPainting += Dgv_CellPainting;
            dgv.CellMouseClick += Dgv_CellMouseClick;
            dgv.CellMouseMove += Dgv_CellMouseMove;

            // Libera bitmaps cuando se dispose la grilla.
            dgv.Disposed += (_, __) => DisposeIcons();
        }

        // Calcula 3 rectángulos para Edit, View, Delete dentro de la celda.
        private Rectangle[] GetRects(Rectangle cellBounds)
        {
            int x = cellBounds.X + P.Left;
            int y = cellBounds.Y + (cellBounds.Height - BtnH) / 2;
            return new[]
            {
            new Rectangle(x, y, BtnW, BtnH),
            new Rectangle(x + BtnW + Gap, y, BtnW, BtnH),
            new Rectangle(x + 2 * (BtnW + Gap), y, BtnW, BtnH)
            };
        }

        // Crea un camino con bordes redondeados para el chip.
        private GraphicsPath Rounded(Rectangle r, int radius)
        {
            var p = new GraphicsPath();
            int d = radius * 2;
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        // Dibuja un “chip” con fondo, borde e ícono centrado
        private void DrawChip(Graphics g, Rectangle r, Color back, Bitmap icon)
        {
            using (var b = new SolidBrush(back))
            using (var pen = new Pen(Color.FromArgb(210, back), 1))
            using (var path = Rounded(r, 8))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillPath(b, path);
                g.DrawPath(pen, path);

                // centrar imagen dentro del rectángulo
                int x = r.X + (r.Width - icon.Width) / 2;
                int y = r.Y + (r.Height - icon.Height) / 2;
                g.DrawImage(icon, x, y, icon.Width, icon.Height);
            }
        }
        // Dibujo custom de la celda de acciones.
        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // fila de encabezado
            if (e.ColumnIndex < 0) return; 
            if (dgv.Columns[e.ColumnIndex].Name != colName) return;

            e.Handled = true; // indicamos que manejamos el pintado
            e.PaintBackground(e.ClipBounds, true); // pinta fondo (incluye selección)
            e.Paint(e.CellBounds, DataGridViewPaintParts.Border); // pinta borde


            var rects = GetRects(e.CellBounds);
            DrawChip(e.Graphics, rects[0], Color.FromArgb(219, 234, 254), ICON_EDIT);   // azul claro
            DrawChip(e.Graphics, rects[1], Color.FromArgb(220, 252, 231), ICON_VIEW);   // verde claro
            DrawChip(e.Graphics, rects[2], Color.FromArgb(254, 226, 226), ICON_DELETE); // rojo claro
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return; // FIX: evita Columns[-1]
            if (dgv.Columns[e.ColumnIndex].Name != colName) return;

            var cellRect = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            var rects = GetRects(cellRect);

            // e.X/Y son relativos a la celda. Ajustamos con el origen del rect de pantalla.
            var clickPoint = new Point(e.X + cellRect.X, e.Y + cellRect.Y);

            var id = dgv.Rows[e.RowIndex].Cells[colId].Value; // obtiene ID de la fila

            if (rects[0].Contains(clickPoint)) OnEdit?.Invoke(id);
            else if (rects[1].Contains(clickPoint)) OnView?.Invoke(id);
            else if (rects[2].Contains(clickPoint)) OnDelete?.Invoke(id);
        }

        // Cambia el cursor a “mano” cuando pasa por la columna de acciones.
        private void Dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool hand = e.RowIndex >= 0 && e.ColumnIndex >= 0                     
                 && dgv.Columns[e.ColumnIndex].Name == colName;
            dgv.Cursor = hand ? Cursors.Hand : Cursors.Default;
        }
        // Genera un bitmap desde FontAwesome.Sharp con transparencia real.
        private Bitmap GetIconBitmap(IconChar icon, int size, Color color)
        {
            var bmp = new Bitmap(size, size, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (var iconPicture = new IconPictureBox())
            {
                iconPicture.IconChar = icon;                      // ícono a renderizar
                iconPicture.IconColor = color;                    // color del ícono
                iconPicture.IconSize = size - 2;                  // leve padding interno
                iconPicture.BackColor = Color.Magenta;            // color clave
                iconPicture.Size = new Size(size, size);
                // Renderiza el control al bitmap.
                iconPicture.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            }

            bmp.MakeTransparent(Color.Magenta);                   // vuelve Magenta transparente
            return bmp;
        }

        // Crea los bitmaps una sola vez.
        private void EnsureIcons()
        {
            if (ICON_EDIT == null)
            {
                ICON_EDIT = GetIconBitmap(IconChar.PenToSquare, 16, Color.Black);
                ICON_VIEW = GetIconBitmap(IconChar.Eye, 16, Color.Black);
                ICON_DELETE = GetIconBitmap(IconChar.Trash, 16, Color.Black);
            }
        }

        // Libera recursos gráficos.
        private static void DisposeIcons()
        {
            ICON_EDIT?.Dispose(); ICON_EDIT = null;
            ICON_VIEW?.Dispose(); ICON_VIEW = null;
            ICON_DELETE?.Dispose(); ICON_DELETE = null;
        }
    }
}
