using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sistema_Gimnasio
{
    public partial class PurchaseOrderView : UserControl
    {
        public PurchaseOrderView()
        {
            InitializeComponent();
            
            LoadFakeData();
            BoardOrderP.CellClick += BoardOrderP_CellClick;
            SetupActionIcons();
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 16);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 16);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 16);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            BoardOrderP.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardOrderP.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        private void BoardOrderP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var id = BoardOrderP.Rows[e.RowIndex].Cells["Id_Orden"].Value;
            var col = BoardOrderP.Columns[e.ColumnIndex].Name;
            if (col == "colEdit")
            {
                MessageBox.Show($"Editar orden {id}");
            }
            else if (col == "colView")
            {
                MessageBox.Show($"Ver orden {id}");
            }
            else if (col == "colDelete")
            {
                MessageBox.Show($"Eliminar orden {id}");
            }
        }

        private void LoadFakeData()
        {
            BoardOrderP.Rows.Add("ORD-001", "Proveedor A", DateTime.Now.AddDays(-3).ToShortDateString(), "Pendiente", null);
            BoardOrderP.Rows.Add("ORD-002", "Proveedor B", DateTime.Now.AddDays(-1).ToShortDateString(), "Recibida", null);
            BoardOrderP.Rows.Add("ORD-003", "Proveedor C", DateTime.Now.ToShortDateString(), "Cancelada", null);
        }
    }

    
}
