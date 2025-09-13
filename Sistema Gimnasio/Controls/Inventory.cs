using Sistema_Gimnasio.Forms;
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
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
            BoardInventory.CellClick += BoardMember_CellClick;
            SetupActionIcons();
            LoadFakeData();
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 16);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 16);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 16);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            BoardInventory.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardInventory.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        private void BoardMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var name = BoardInventory.Rows[e.RowIndex].Cells["name"].Value;
            var col = BoardInventory.Columns[e.ColumnIndex].Name;
            if (col == "colEdit")
            {
                MessageBox.Show($"Editar item {name}");
            }
            else if (col == "colView")
            {
                MessageBox.Show($"Ver item {name}");
            }
            else if (col == "colDelete")
            {
                MessageBox.Show($"Eliminar item {name}");
            }
        }

        private void BNewItem_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewItem = new AddItemForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void LoadFakeData()
        {
            //nombre, cantidad, fecha ingreso, categoria
            BoardInventory.Rows.Add("Mancuernas", "20", "2023-10-01", "Pesas");
            BoardInventory.Rows.Add("Colchonetas", "15", "2023-09-15", "Yoga");
            BoardInventory.Rows.Add("Bicicletas Estáticas", "10", "2023-08-20", "Cardio");
            BoardInventory.Rows.Add("Balones Medicinales", "25", "2023-07-30", "Rehabilitación");
            BoardInventory.Rows.Add("Cuerdas para Saltar", "30", "2023-06-10", "Cardio");
        }
    }
}
