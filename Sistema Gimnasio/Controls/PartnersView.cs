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
    
    
    public partial class PartnersView : UserControl
    {
        public Roles CurrentRole { get; set; } = Roles.None;

        private readonly Dictionary<DataGridViewColumn, Roles> Acl = new Dictionary<DataGridViewColumn, Roles>();
        private List<PartnerViewModel> partnersList = new List<PartnerViewModel>();

        public PartnersView()
        {
            InitializeComponent();
            BoardMember.CellClick += BoardMember_CellClick;
            SetupActionIcons();
            LoadFakeData();

            // Buscador y filtro
            TSearchPartner.TextChanged += (s, e) => ApplyFilters();
            TSearchPartner.MouseClick += (s, e) => {
                if (TSearchPartner.Text == "Buscar socio...") {
                    TSearchPartner.Text = "";
                    TSearchPartner.ForeColor = Color.Black;
                }
            };
            TSearchPartner.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearchPartner.Text)) {
                    TSearchPartner.Text = "Buscar socio...";
                    TSearchPartner.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
            CBMembership.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            BoardMember.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardMember.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        private void BNewMember_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewMember = new AddMemberForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewMember.ShowDialog() == DialogResult.OK)
                {
                    //aca tenemos que volver a cargar los datos cuando se guarde el nuevo proveedor(cuando sea dinamico)
                }
            }
        }
        
        private void BoardMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var name = BoardMember.Rows[e.RowIndex].Cells["name"].Value;
            var col = BoardMember.Columns[e.ColumnIndex].Name;
            if (col == "colEdit")
            {
                MessageBox.Show($"Editar socio {name}");
            }
            else if (col == "colView")
            {
                MessageBox.Show($"Ver socio {name}");
            }
            else if (col == "colDelete")
            {
                MessageBox.Show($"Eliminar socio {name}");
            }
        }
        private void LoadFakeData()
        {
            partnersList = new List<PartnerViewModel>
            {
                new PartnerViewModel { Name = "Juan Pérez", Dni = "12345678", Phone = "3794-111111", Plan = "Mensual", Estado = "Activo" },
                new PartnerViewModel { Name = "María López", Dni = "87654321", Phone = "3794-222222", Plan = "Semanal", Estado = "Inactivo" },
                new PartnerViewModel { Name = "Carlos Gómez", Dni = "45678912", Phone = "3794-333333", Plan = "Diaria", Estado = "Activo" }
            };
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string query = TSearchPartner.Text?.Trim().ToLowerInvariant();
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "Buscar socio...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos";
            string membresia = CBMembership.SelectedItem?.ToString() ?? "Todos";

            var filtered = partnersList.Where(p =>
                (!hasQuery || (p.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" || (p.Estado ?? "").Equals(estado, StringComparison.OrdinalIgnoreCase)) &&
                (membresia == "Todos" || (p.Plan ?? "").Equals(membresia, StringComparison.OrdinalIgnoreCase))
            ).ToList();
            BoardMember.Rows.Clear();
            foreach (var p in filtered)
            {
                BoardMember.Rows.Add(p.Name, p.Dni, p.Phone, p.Plan, p.Estado);
            }
        }

        private class PartnerViewModel
        {
            public string Name { get; set; }
            public string Dni { get; set; }
            public string Phone { get; set; }
            public string Plan { get; set; }
            public string Estado { get; set; }
        }


    }
}
