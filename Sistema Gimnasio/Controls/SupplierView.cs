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
    public partial class SupplierView : UserControl
    {
        public SupplierView()
        {
            InitializeComponent();
            LoadFakeData();
            BoardSupplier.CellClick += BoardSupplier_CellClick;
            SetupActionIcons();
        }

        private void SupplierView_Load(object sender, EventArgs e)
        {

        }

        private void BNewSupplier_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewSupllier = new AddSupplierForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewSupllier.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 16);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 16);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 16);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            BoardSupplier.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardSupplier.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        private void BoardSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var name = BoardSupplier.Rows[e.RowIndex].Cells["name"].Value;
            var col = BoardSupplier.Columns[e.ColumnIndex].Name;
            if (col == "colEdit")
            {
                MessageBox.Show($"Editar proveedor {name}");
            }
            else if (col == "colView")
            {
                MessageBox.Show($"Ver proveedor {name}");
            }
            else if (col == "colDelete")
            {
                MessageBox.Show($"Eliminar proveedor {name}");
            }
        }

        private void LoadFakeData()
        {

            BoardSupplier.Rows.Add("Proveedor A", "20-12345678-9", "Servicios", "proveedorA@mail.com", "3794-111111", "Activo");
            BoardSupplier.Rows.Add("Proveedor B", "23-87654321-0", "Insumos", "proveedorB@mail.com", "3794-222222", "Inactivo");
            BoardSupplier.Rows.Add("Proveedor C", "27-11223344-5", "Equipos", "proveedorC@mail.com", "3794-333333", "Activo");
        }
    }

}
