using Business;
using Sistema_Gimnasio.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sistema_Gimnasio
{
    public partial class InventoryView : UserControl
    {
        private readonly InventoryService inventoryService = new InventoryService();

        private List<InventoryViewModel> inventoryList = new List<InventoryViewModel>();

        // Constructor del control de usuario
        public InventoryView()
        {
            InitializeComponent();
            BoardInventory.CellClick += BoardMember_CellClick;
            SetupActionIcons();

            LoadRealData();

            // Configuración de los filtros de búsqueda
            TSearchInventory.TextChanged += (s, e) => ApplyFilters();
            TSearchInventory.MouseClick += (s, e) => {
                if (TSearchInventory.Text == "Buscar item...")
                {
                    TSearchInventory.Text = "";
                    TSearchInventory.ForeColor = Color.Black;
                }
            };
            TSearchInventory.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearchInventory.Text))
                {
                    TSearchInventory.Text = "Buscar item...";
                    TSearchInventory.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
            CBCategoria.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        // Carga los datos desde la base de datos y los prepara para la vista
        private void LoadRealData()
        {
            try
            {
                var rawData = inventoryService.GetAllInventoriesForView();

                inventoryList = rawData.Select(item => new InventoryViewModel
                {
                    Id = item.IdInventario, // Guardamos el ID
                    Name = item.Articulo,
                    Cantidad = item.Cantidad.ToString(),
                    FechaIngreso = item.FechaIngreso,
                    Categoria = item.Categoria,
                    Estado = (item.Estado == true) ? "Activo" : "Inactivo"
                }).ToList();

                LoadCategoryFilter();
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inventario: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Llena el ComboBox de filtro con las categorías existentes
        private void LoadCategoryFilter()
        {
            var categorias = inventoryList.Select(i => i.Categoria).Distinct().ToList();

            CBCategoria.Items.Clear();
            CBCategoria.Items.Add("Todos");

            foreach (var cat in categorias)
            {
                CBCategoria.Items.Add(cat);
            }

            CBCategoria.SelectedIndex = 0;
        }

        // Configura los iconos de acción en la grilla
        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);
            Bitmap bmpEnable = IconChar.UserCheck.ToBitmap(Color.Black, 30);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            BoardInventory.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardInventory.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete")
                {
                    var status = BoardInventory.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = status?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;
                    ev.Value = activo ? bmpDelete : bmpEnable;
                    ev.FormattingApplied = true;
                }
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
                        row.DefaultCellStyle.BackColor = BoardInventory.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = BoardInventory.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.SelectionBackColor = BoardInventory.DefaultCellStyle.SelectionBackColor;
                        row.DefaultCellStyle.SelectionForeColor = BoardInventory.DefaultCellStyle.SelectionForeColor;
                    }
                }
            };
        }

        // Maneja los clics en los botones de acción de la grilla
        private void BoardMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int selectedId = (int)BoardInventory.Rows[e.RowIndex].Tag;
            var name = BoardInventory.Rows[e.RowIndex].Cells["name"].Value.ToString();
            var status = BoardInventory.Rows[e.RowIndex].Cells["status"].Value.ToString();
            var col = BoardInventory.Columns[e.ColumnIndex].Name;

            if (col == "colEdit")
            {
                using (var fEditItem = new AddItemForm(selectedId))
                {
                    if (fEditItem.ShowDialog() == DialogResult.OK)
                    {
                        LoadRealData();
                    }
                }
            }
            else if (col == "colView")
            {
                // --- LÓGICA PARA VER DETALLES ---
                // (Creamos un formulario de edición, pero lo hacemos de solo lectura)
                using (var fViewItem = new AddItemForm(selectedId))
                {
                    fViewItem.Text = "Ver Detalles del Artículo";
                    // Deshabilitamos todos los controles para que no se puedan editar
                    foreach (Control control in fViewItem.Controls)
                    {
                        control.Enabled = false;
                    }
                    // Ocultamos los botones de guardar y limpiar
                    fViewItem.Controls["BSave"].Visible = false;
                    fViewItem.Controls["BLimpiar"].Visible = false;
                    // Mostramos el formulario
                    fViewItem.ShowDialog();
                }
            }
            else if (col == "colDelete")
            {
                // --- LÓGICA PARA LA BAJA/ALTA ---
                string action = status.Equals("Activo") ? "dar de baja" : "dar de alta";
                string actionVerb = status.Equals("Activo") ? "Baja" : "Alta";

                // Preguntamos al usuario para confirmar la acción
                var confirmResult = MessageBox.Show($"¿Está seguro de que desea {action} el artículo '{name}'?",
                                                     $"Confirmar {actionVerb}",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamamos al servicio para cambiar el estado
                        inventoryService.ChangeInventoryStatus(selectedId);
                        // Recargamos la grilla para ver el cambio de inmediato
                        LoadRealData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cambiar el estado del artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Abre el formulario para agregar un nuevo ítem
        private void BNewItem_Click(object sender, EventArgs e)
        {
            using (var fNewItem = new AddItemForm())
            {
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {
                    // Si se guardó algo, recargamos los datos para ver el cambio
                    LoadRealData();
                }
            }
        }

        // Filtra y actualiza la grilla
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
                int rowIndex = BoardInventory.Rows.Add(i.Name, i.Cantidad, i.FechaIngreso, i.Categoria, i.Estado);
                // Guardamos el ID en el Tag de la fila para poder usarlo después en los clics
                BoardInventory.Rows[rowIndex].Tag = i.Id;
            }
        }

        // Clase interna para el modelo de la vista
        private class InventoryViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Cantidad { get; set; }
            public string FechaIngreso { get; set; }
            public string Categoria { get; set; }
            public string Estado { get; set; }
        }
    }
}