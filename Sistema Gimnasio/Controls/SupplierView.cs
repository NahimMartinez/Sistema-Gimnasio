using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_Gimnasio.Form1;

namespace Sistema_Gimnasio
{
    public partial class SupplierView : UserControl
    {
        public Roles CurrentRole { get; set; } = Roles.None;

        private readonly Dictionary<DataGridViewColumn, Roles> Acl = new Dictionary<DataGridViewColumn, Roles>();

        private List<SupplierViewModel> suppliersList = new List<SupplierViewModel>();

        public SupplierView()
        {
            InitializeComponent();
            LoadFakeData();
            BoardSupplier.CellClick += BoardSupplier_CellClick;
            SetupActionIcons();
            this.Load += SupplierView_Load;

            // Filtros
            TSearchSupplier.TextChanged += (s, e) => ApplyFilters();
            TSearchSupplier.GotFocus += (s, e) => {
                if (TSearchSupplier.Text == "Buscar proveedor...") {
                    TSearchSupplier.Text = "";
                    TSearchSupplier.ForeColor = Color.Black;
                }
            };
            TSearchSupplier.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearchSupplier.Text)) {
                    TSearchSupplier.Text = "Buscar proveedor...";
                    TSearchSupplier.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        private void SupplierView_Load(object sender, EventArgs e)
        {
            BuildAcl();
            ApplyAcl();

            // Inicializamos placeholder al cargar
            if (string.IsNullOrWhiteSpace(TSearchSupplier.Text))
            {
                TSearchSupplier.Text = "Buscar proveedor...";
                TSearchSupplier.ForeColor = Color.Gray;
            }
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);

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
            suppliersList = new List<SupplierViewModel>
            {
                new SupplierViewModel { Name = "Proveedor A", Cuit = "20-12345678-9", TypeSupplier = "Servicios", Email = "proveedorA@mail.com", Phone = "3794-111111", Status = "Activo" },
                new SupplierViewModel { Name = "Proveedor B", Cuit = "23-87654321-0", TypeSupplier = "Insumos", Email = "proveedorB@mail.com", Phone = "3794-222222", Status = "Inactivo" },
                new SupplierViewModel { Name = "Proveedor C", Cuit = "27-11223344-5", TypeSupplier = "Equipos", Email = "proveedorC@mail.com", Phone = "3794-333333", Status = "Activo" }
            };
            ApplyFilters();
        }

        private void BuildAcl()
        {
            Acl[colEdit] = Roles.Admin;
            Acl[colDelete] = Roles.Admin;
            Acl[colView] = Roles.Admin | Roles.Recep;
        }

        private void ApplyAcl()
        {
            foreach (var keyValue in Acl)
                keyValue.Key.Visible = (CurrentRole & keyValue.Value) != 0;
        }

        private void BNewSupplier_Click_1(object sender, EventArgs e)
        {
            using (var fNewSupllier = new AddSupplierForm())
            {
                if (fNewSupllier.ShowDialog() == DialogResult.OK)
                {
                    // recargar datos
                }
            }
        }

        private void ApplyFilters()
        {
            string query = TSearchSupplier.Text?.Trim().ToLowerInvariant();
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar proveedor...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos";

            var filtered = suppliersList.Where(s =>
                (!hasQuery || (s.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" ||
                 (estado == "Activo" && s.Status.Equals("Activo", StringComparison.OrdinalIgnoreCase)) ||
                 (estado == "Inactivo" && s.Status.Equals("Inactivo", StringComparison.OrdinalIgnoreCase)))
            ).ToList();

            BoardSupplier.Rows.Clear();
            foreach (var s in filtered)
            {
                BoardSupplier.Rows.Add(s.Name, s.Cuit, s.TypeSupplier, s.Email, s.Phone, s.Status);
            }
        }

        private class SupplierViewModel     
        {
            public string Name { get; set; }
            public string Cuit { get; set; }
            public string TypeSupplier { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Status { get; set; }
        }
    }
}
