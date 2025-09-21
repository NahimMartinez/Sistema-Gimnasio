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
using Sistema_Gimnasio.Forms;

namespace Sistema_Gimnasio
{
    public partial class PurchaseOrderView : UserControl
    {
        // Lista que almacena la información de las órdenes de compra
        private List<OrderViewModel> ordersList = new List<OrderViewModel>();

        // Constructor: se ejecuta al crear el control.
        public PurchaseOrderView()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.

            // Configura el DateTimePicker para buscar por fecha.
            DTSearchDate.ShowCheckBox = true; // Muestra el checkbox para activar/desactivar el filtro por fecha.
            DTSearchDate.Checked = false; // Inicialmente el filtro por fecha está desactivado.

            // Configura los filtros de búsqueda y fecha.
            TOrdPurcharse.TextChanged += (s, e) => ApplyFilters(); // Filtra al escribir en la caja de búsqueda.
            TOrdPurcharse.Click += (s, e) => {
                // Limpia el texto de placeholder al hacer clic en la caja de búsqueda.
                if (TOrdPurcharse.Text == "Buscar orden de compra...") {
                    TOrdPurcharse.Text = "";
                    TOrdPurcharse.ForeColor = Color.Black;
                }
            };
            TOrdPurcharse.LostFocus += (s, e) => {
                // Restaura el placeholder si la caja queda vacía al perder el foco.
                if (string.IsNullOrWhiteSpace(TOrdPurcharse.Text)) {
                    TOrdPurcharse.Text = "Buscar orden de compra...";
                    TOrdPurcharse.ForeColor = Color.Gray;
                }
            };
            DTSearchDate.ValueChanged += (s, e) => ApplyFilters(); // Filtra al cambiar la fecha seleccionada.

            LoadFakeData(); // Carga datos de ejemplo en la lista de órdenes.
            BoardOrderP.CellClick += BoardOrderP_CellClick; // Asocia el evento de clic en celda a un método.
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
        }

        // Configura los iconos de las columnas de acción en la tabla.
        private void SetupActionIcons()
        {
            // Crea imágenes para los iconos usando FontAwesome.
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30); // Icono de editar
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30); // Icono de ver
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30); // Icono de eliminar

            // Asigna los iconos a las columnas correspondientes.
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            // Evento para mostrar los iconos en las celdas de acción.
            BoardOrderP.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return; // Ignora encabezados
                string col = BoardOrderP.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        // Evento que se ejecuta al hacer clic en una celda de la tabla.
        private void BoardOrderP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clics fuera de las filas de datos
            var id = BoardOrderP.Rows[e.RowIndex].Cells["Id_Orden"].Value; // Obtiene el ID de la orden
            var col = BoardOrderP.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            // Muestra un mensaje según la acción seleccionada
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

        // Carga datos de ejemplo en la lista de órdenes de compra.
        private void LoadFakeData()
        {
            // Se crean algunas órdenes de ejemplo y se agregan a la lista.
            ordersList = new List<OrderViewModel>
            {
                new OrderViewModel { IdOrden = "ORD-001", Supplier = "Proveedor A", Date = DateTime.Now.AddDays(-3), Status = "Pendiente" },
                new OrderViewModel { IdOrden = "ORD-002", Supplier = "Proveedor B", Date = DateTime.Now.AddDays(-1), Status = "Recibida" },
                new OrderViewModel { IdOrden = "ORD-003", Supplier = "Proveedor C", Date = DateTime.Now, Status = "Cancelada" }
            };
            ApplyFilters(); // Aplica los filtros para mostrar los datos en la tabla.
        }

        // Aplica los filtros de búsqueda y fecha a la lista de órdenes y actualiza la tabla.
        private void ApplyFilters()
        {
            // Obtiene el texto de búsqueda en minúsculas
            string query = TOrdPurcharse.Text?.Trim().ToLowerInvariant();
            // Determina si hay texto de búsqueda válido
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar orden de compra...";
            // Determina si el filtro por fecha está activado
            bool useDate = DTSearchDate.Checked;
            // Obtiene la fecha seleccionada
            DateTime selectedDate = DTSearchDate.Value.Date;

            // Filtra la lista según el texto de búsqueda y la fecha
            var filtered = ordersList.Where(o =>
                (!hasQuery ||
                    (o.IdOrden ?? "").ToLower().Contains(query) || // Busca por ID
                    (o.Supplier ?? "").ToLower().Contains(query) || // Busca por proveedor
                    (o.Status ?? "").ToLower().Contains(query)) // Busca por estado
                && (!useDate || o.Date.Date == selectedDate) // Filtra por fecha si está activado
            ).ToList();

            BoardOrderP.Rows.Clear(); // Limpia la tabla
            foreach (var o in filtered)
            {
                // Agrega cada orden filtrada a la tabla
                // Los últimos tres valores (null) son para las columnas de acción (editar, ver, eliminar)
                BoardOrderP.Rows.Add(o.IdOrden, o.Supplier, o.Date.ToShortDateString(), o.Status, null, null, null);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para agregar una nueva orden de compra.
        private void BNewOrderP_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario para agregar orden de compra
            using (var fNewOrder = new AddOrderPurchase())
            {
                // Muestra el formulario como un cuadro de diálogo
                if (fNewOrder.ShowDialog() == DialogResult.OK)
                {
                    // Aquí se podría recargar los datos si se agregó una nueva orden
                }
            }
        }

        // Clase interna que representa la información de una orden de compra.
        private class OrderViewModel
        {
            public string IdOrden { get; set; } // ID de la orden
            public string Supplier { get; set; } // Nombre del proveedor
            public DateTime Date { get; set; } // Fecha de la orden
            public string Status { get; set; } // Estado de la orden (Pendiente, Recibida, Cancelada)
        }
    }
}
