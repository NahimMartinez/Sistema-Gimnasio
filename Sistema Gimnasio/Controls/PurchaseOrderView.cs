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
        private List<OrderViewModel> ordersList = new List<OrderViewModel>();

        public PurchaseOrderView()
        {
            InitializeComponent();

            // Mostrar el checkbox y dejarlo desmarcado
            DTSearchDate.ShowCheckBox = true;
            DTSearchDate.Checked = false;

            // Filtros
            TOrdPurcharse.TextChanged += (s, e) => ApplyFilters();
            TOrdPurcharse.Click += (s, e) => {
                if (TOrdPurcharse.Text == "Buscar orden de compra...") {
                    TOrdPurcharse.Text = "";
                    TOrdPurcharse.ForeColor = Color.Black;
                }
            };
            TOrdPurcharse.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TOrdPurcharse.Text)) {
                    TOrdPurcharse.Text = "Buscar orden de compra...";
                    TOrdPurcharse.ForeColor = Color.Gray;
                }
            };
            DTSearchDate.ValueChanged += (s, e) => ApplyFilters();

            LoadFakeData();
            BoardOrderP.CellClick += BoardOrderP_CellClick;
            SetupActionIcons();
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);

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
            ordersList = new List<OrderViewModel>
            {
                new OrderViewModel { IdOrden = "ORD-001", Supplier = "Proveedor A", Date = DateTime.Now.AddDays(-3), Status = "Pendiente" },
                new OrderViewModel { IdOrden = "ORD-002", Supplier = "Proveedor B", Date = DateTime.Now.AddDays(-1), Status = "Recibida" },
                new OrderViewModel { IdOrden = "ORD-003", Supplier = "Proveedor C", Date = DateTime.Now, Status = "Cancelada" }
            };
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string query = TOrdPurcharse.Text?.Trim().ToLowerInvariant();
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar orden de compra...";
            bool useDate = DTSearchDate.Checked;
            DateTime selectedDate = DTSearchDate.Value.Date;

            var filtered = ordersList.Where(o =>
                (!hasQuery ||
                    (o.IdOrden ?? "").ToLower().Contains(query) ||
                    (o.Supplier ?? "").ToLower().Contains(query) ||
                    (o.Status ?? "").ToLower().Contains(query))
                && (!useDate || o.Date.Date == selectedDate)
            ).ToList();

            BoardOrderP.Rows.Clear();
            foreach (var o in filtered)
            {
                BoardOrderP.Rows.Add(o.IdOrden, o.Supplier, o.Date.ToShortDateString(), o.Status, null, null, null);
            }
        }

        private void BNewOrderP_Click(object sender, EventArgs e)
        {
            using (var fNewOrder = new AddOrderPurchase())
            {
                if (fNewOrder.ShowDialog() == DialogResult.OK)
                {
                    //aca tenemos que volver a cargar los datos cuando se guarde el nuevo proveedor(cuando sea dinamico)
                }
            }
        }

        private class OrderViewModel
        {
            public string IdOrden { get; set; }
            public string Supplier { get; set; }
            public DateTime Date { get; set; }
            public string Status { get; set; }
        }
    }
}
