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
        // Lista que almacena la información de los ítems del inventario 
        private List<InventoryViewModel> inventoryList = new List<InventoryViewModel>();

        // Constructor: se ejecuta al crear el control.
        public Inventory()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.
            BoardInventory.CellClick += BoardMember_CellClick; // Asocia el evento de clic en celda a un método.
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
            LoadFakeData(); // Carga datos de ejemplo en la lista de inventario.

            // Buscador y filtro
            TSearchInventory.TextChanged += (s, e) => ApplyFilters();
            TSearchInventory.MouseClick += (s, e) => {
                // Limpia el texto de placeholder al hacer clic en la caja de búsqueda.
                if (TSearchInventory.Text == "Buscar item...") {
                    TSearchInventory.Text = "";
                    TSearchInventory.ForeColor = Color.Black;
                }
            };
            TSearchInventory.LostFocus += (s, e) => {
                // Restaura el placeholder si la caja queda vacía al perder el foco.
                if (string.IsNullOrWhiteSpace(TSearchInventory.Text)) {
                    TSearchInventory.Text = "Buscar item...";
                    TSearchInventory.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar el estado.
            CBCategoria.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar la categoría.
        }

        // Configura los iconos de las columnas de acción en la tabla.
        private void SetupActionIcons()
        {
            // Crea imágenes para los iconos usando FontAwesome.
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);
            Bitmap bmpEnable = IconChar.UserCheck.ToBitmap(Color.Black, 30); // Icono de alta

            // Asigna los iconos a las columnas correspondientes.
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            // Evento para mostrar los iconos en las celdas de acción.
            BoardInventory.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return; // Ignora encabezados
                string col = BoardInventory.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete")
                {
                    var status = BoardInventory.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = status?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    ev.Value = activo ? bmpDelete : bmpEnable; 
                    ev.FormattingApplied = true; }

                if (col == "status")
                {
                    var st = BoardInventory.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = st?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    var row = BoardInventory.Rows[ev.RowIndex];
                    if (!activo)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        // Resetea a valores por defecto
                        row.DefaultCellStyle.BackColor = BoardInventory.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = BoardInventory.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.SelectionBackColor = BoardInventory.DefaultCellStyle.SelectionBackColor;
                        row.DefaultCellStyle.SelectionForeColor = BoardInventory.DefaultCellStyle.SelectionForeColor;
                    }
                }
            };
        }

        // Evento que se ejecuta al hacer clic en una celda de la tabla.
        private void BoardMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clics fuera de las filas de datos
            var name = BoardInventory.Rows[e.RowIndex].Cells["name"].Value; // Obtiene el nombre del ítem
            var col = BoardInventory.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            // Muestra un mensaje según la acción seleccionada
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

        // Evento que se ejecuta al hacer clic en el botón para agregar un nuevo ítem.
        private void BNewItem_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario para agregar ítem
            using (var fNewItem = new AddItemForm())
            {
                // Muestra el formulario como un cuadro de diálogo
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {
                    // Aquí se podría recargar los datos si se agregó un nuevo ítem
                }
            }
        }

        // Carga datos de ejemplo en la lista de inventario.
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
            ApplyFilters(); // Aplica los filtros para mostrar los datos en la tabla.
        }

        // Aplica los filtros de búsqueda, estado y categoría a la lista de inventario y actualiza la tabla.
        private void ApplyFilters()
        {
            string query = TSearchInventory.Text?.Trim().ToLowerInvariant(); // Obtiene el texto de búsqueda en minúsculas
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar item...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos"; // Obtiene el estado seleccionado
            string categoria = CBCategoria.SelectedItem?.ToString() ?? "Todos"; // Obtiene la categoría seleccionada

            // Filtra la lista según el texto de búsqueda, estado y categoría
            var filtered = inventoryList.Where(i =>
                (!hasQuery || (i.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" || (i.Estado ?? "").Equals(estado, StringComparison.OrdinalIgnoreCase)) &&
                (categoria == "Todos" || (i.Categoria ?? "").Equals(categoria, StringComparison.OrdinalIgnoreCase))
            ).ToList();
            BoardInventory.Rows.Clear(); // Limpia la tabla
            foreach (var i in filtered)
            {
                // Agrega cada ítem filtrado a la tabla
                BoardInventory.Rows.Add(i.Name, i.Cantidad, i.FechaIngreso, i.Categoria, i.Estado);
            }
        }

        // Clase interna que representa la información de un ítem del inventario.
        private class InventoryViewModel
        {
            public string Name { get; set; } // Nombre del ítem
            public string Cantidad { get; set; } // Cantidad disponible
            public string FechaIngreso { get; set; } // Fecha de ingreso al inventario
            public string Categoria { get; set; } // Categoría del ítem
            public string Estado { get; set; } // Estado del ítem (Activo/Inactivo)
        }
    }
}
