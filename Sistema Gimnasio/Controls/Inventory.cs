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
        private List<InventoryViewModel> inventoryList = new List<InventoryViewModel>();

        public Inventory()
        {
            InitializeComponent();
            BoardInventory.CellClick += BoardMember_CellClick;
            SetupActionIcons();
            LoadFakeData();

            // Buscador y filtro
            TSearchInventory.TextChanged += (s, e) => ApplyFilters();
            TSearchInventory.MouseClick += (s, e) => {
                if (TSearchInventory.Text == "Buscar item...") {
                    TSearchInventory.Text = "";
                    TSearchInventory.ForeColor = Color.Black;
                }
            };
            TSearchInventory.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearchInventory.Text)) {
                    TSearchInventory.Text = "Buscar item...";
                    TSearchInventory.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
            CBCategoria.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);

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
            inventoryList = new List<InventoryViewModel>
            {
                new InventoryViewModel { Name = "Mancuernas 10kg", Cantidad = "10", FechaIngreso = "2023-10-01", Categoria = "Mancuernas", Estado = "Activo" },
                new InventoryViewModel { Name = "Mancuernas 5kg", Cantidad = "15", FechaIngreso = "2023-09-15", Categoria = "Mancuernas", Estado = "Inactivo" },
                new InventoryViewModel { Name = "Barra Olímpica", Cantidad = "5", FechaIngreso = "2023-08-20", Categoria = "Barras", Estado = "Activo" },
                new InventoryViewModel { Name = "Disco 20kg", Cantidad = "8", FechaIngreso = "2023-07-30", Categoria = "Discos", Estado = "Activo" },
                new InventoryViewModel { Name = "Máquina de Remo", Cantidad = "2", FechaIngreso = "2023-06-10", Categoria = "Maquinas", Estado = "Inactivo" },
                new InventoryViewModel { Name = "Cuerda de saltar", Cantidad = "20", FechaIngreso = "2023-05-10", Categoria = "Accesorios", Estado = "Activo" },
                new InventoryViewModel { Name = "Máquina de Pecho", Cantidad = "1", FechaIngreso = "2023-04-01", Categoria = "Maquinas", Estado = "Activo" }
            };
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string query = TSearchInventory.Text?.Trim().ToLowerInvariant();
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar item...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos";
            string categoria = CBCategoria.SelectedItem?.ToString() ?? "Todos";

            var filtered = inventoryList.Where(i =>
                (!hasQuery || (i.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" || (i.Estado ?? "").Equals(estado, StringComparison.OrdinalIgnoreCase)) &&
                (categoria == "Todos" || (i.Categoria ?? "").Equals(categoria, StringComparison.OrdinalIgnoreCase))
            ).ToList();
            BoardInventory.Rows.Clear();
            foreach (var i in filtered)
            {
                BoardInventory.Rows.Add(i.Name, i.Cantidad, i.FechaIngreso, i.Categoria, i.Estado);
            }
        }

        private class InventoryViewModel
        {
            public string Name { get; set; }
            public string Cantidad { get; set; }
            public string FechaIngreso { get; set; }
            public string Categoria { get; set; }
            public string Estado { get; set; }
        }
    }
}
