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
        private readonly DataGridView _dgv;
        private readonly string _colName;
        private readonly string _colId;

        public event Action<object> OnEdit;
        public event Action<object> OnView;
        public event Action<object> OnDelete;

        private readonly Padding P = new Padding(6, 4, 6, 4);
        private const int BtnW = 28, BtnH = 24, Gap = 6;

        private static Bitmap ICON_EDIT;
        private static Bitmap ICON_VIEW;
        private static Bitmap ICON_DELETE;


        public ActionColumn(DataGridView dgv, string idColumnName, string accionesColumnName = "Actions")
        {
            _dgv = dgv ?? throw new ArgumentNullException(nameof(dgv));
            _colId = idColumnName ?? throw new ArgumentNullException(nameof(idColumnName));
            _colName = accionesColumnName ?? "Actions";

            if (!_dgv.Columns.Contains(_colId))
                throw new ArgumentException("Falta columna de ID oculta: " + _colId);

            if (!_dgv.Columns.Contains(_colName))
                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = _colName, HeaderText = "Acciones", ReadOnly = true });

            _dgv.CellPainting += Dgv_CellPainting;
            _dgv.CellMouseClick += Dgv_CellMouseClick;
            _dgv.CellMouseMove += Dgv_CellMouseMove;
        }

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

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_dgv.Columns[e.ColumnIndex].Name != _colName) return;

            e.Handled = true;
            e.PaintBackground(e.ClipBounds, true);
            e.Paint(e.CellBounds, DataGridViewPaintParts.Border);

            ICON_EDIT = ICON_VIEW = ICON_DELETE = null;

            EnsureIcons(); // <-- inicializa los bitmaps una sola vez

            var rects = GetRects(e.CellBounds);
            DrawChip(e.Graphics, rects[0], Color.FromArgb(219, 234, 254), ICON_EDIT);
            DrawChip(e.Graphics, rects[1], Color.FromArgb(220, 252, 231), ICON_VIEW);
            DrawChip(e.Graphics, rects[2], Color.FromArgb(254, 226, 226), ICON_DELETE);
        }

        private void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_dgv.Columns[e.ColumnIndex].Name != _colName) return;

            var cellRect = _dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            var rects = GetRects(cellRect);
            var clickPoint = new Point(e.X + cellRect.X, e.Y + cellRect.Y);

            var id = _dgv.Rows[e.RowIndex].Cells[_colId].Value;

            if (rects[0].Contains(clickPoint)) OnEdit?.Invoke(id);
            else if (rects[1].Contains(clickPoint)) OnView?.Invoke(id);
            else if (rects[2].Contains(clickPoint)) OnDelete?.Invoke(id);
        }

        private void Dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            _dgv.Cursor = (e.RowIndex >= 0 && _dgv.Columns[e.ColumnIndex].Name == _colName) ? Cursors.Hand : Cursors.Default;
        }

        private Bitmap GetIconBitmap(IconChar icon, int size, Color color)
        {
            var bmp = new Bitmap(size, size, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (var iconPicture = new IconPictureBox())
            {
                iconPicture.IconChar = icon;
                iconPicture.IconColor = color;
                iconPicture.IconSize = size - 2;
                iconPicture.BackColor = Color.Magenta;            // color clave
                iconPicture.Size = new Size(size, size);
                iconPicture.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
            }

            bmp.MakeTransparent(Color.Magenta);                   // vuelve Magenta transparente
            return bmp;
        }

        private void EnsureIcons()
        {
            if (ICON_EDIT == null)
            {
                ICON_EDIT = GetIconBitmap(IconChar.PenToSquare, 16, Color.Black);
                ICON_VIEW = GetIconBitmap(IconChar.Eye, 16, Color.Black);
                ICON_DELETE = GetIconBitmap(IconChar.Trash, 16, Color.Black);
            }
        }
    }
}
