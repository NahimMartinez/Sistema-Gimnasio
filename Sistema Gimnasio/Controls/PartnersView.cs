using Business;
using Data;
using Entities;
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
        // Propiedad que indica el rol actual del usuario (por ejemplo, Admin, Coach, etc.)
        public Roles CurrentRole { get; set; } = Roles.None;

        // Diccionario que asocia columnas de la tabla con roles para control de acceso (ACL)
        private readonly Dictionary<DataGridViewColumn, Roles> Acl = new Dictionary<DataGridViewColumn, Roles>();
        // Lista que almacena la información de los socios (simulada en este ejemplo)
        private List<Partner> partnersList = new List<Partner>();

        // Constructor: se ejecuta al crear el control.
        public PartnersView()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.
            WireFilters(); // Configura los filtros de búsqueda y estado.
            LoadPartners(); // Carga datos de socio
            BoardMember.CellClick += BoardMember_CellClick;
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
            this.Load += PartnersView_Load;
   

        }
        private void WireFilters()
        {
            // Valores por defecto en los ComboBox
            CBStatus.SelectedIndex = 0; // Todos
            CBMembership.SelectedIndex = 0; // Todos

            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar el estado.
            CBMembership.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar la membresía.
            TSearchPartner.TextChanged += (s, e) => ApplyFilters(); // Filtra al escribir en la caja de búsqueda.

            TSearchPartner.GotFocus += (s, e) => {
                if (TSearchPartner.Text == "Buscar socio...")
                {
                    TSearchPartner.Text = ""; TSearchPartner.ForeColor = Color.Black;
                }
            };
            TSearchPartner.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearchPartner.Text))
                {
                    TSearchPartner.Text = "Buscar socio..."; TSearchPartner.ForeColor = Color.Gray;
                }
            };

        }

        private void LoadPartners()
        {
            var partnerSup = new PartnerService(); // Servicio para obtener socios
            var allPartner = partnerSup.GetAllPartnerView(); // Obtiene todos los socios en formato lista
            // Convierte a lista local para filtrar
            partnersList = allPartner.Select(p => new Partner
            {
                Nombre = p.Nombre, 
                Dni = p.Dni,                
                Telefono = p.Telefono,
                //Membresia = m.Membresia,
                Estado = p.Estado,
            }).ToList();

            BoardMember.AutoGenerateColumns = false; // No generar columnas automáticamente
            
            ApplyFilters(); // Muestra según filtros actuales
        }

        // Configura los iconos de las columnas de acción en la tabla.
        private void SetupActionIcons()
        {
            // Crea imágenes para los iconos usando FontAwesome.
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30); // Icono de editar
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30); // Icono de ver
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30); // Icono de eliminar
            Bitmap bmpEnable = IconChar.UserCheck.ToBitmap(Color.Black, 30); // Icono de alta

            // Asigna los iconos a las columnas correspondientes.
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            // Evento para mostrar los iconos en las celdas de acción.
            BoardMember.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                var colName = BoardMember.Columns[e.ColumnIndex].Name;

                // Íconos fijos
                if (colName == "colEdit") { e.Value = bmpEdit; e.FormattingApplied = true; return; }
                if (colName == "colView") { e.Value = bmpView; e.FormattingApplied = true; return; }

                // Obtengo el bool desde el objeto enlazado
                var item = BoardMember.Rows[e.RowIndex].DataBoundItem as Partner;
                bool activo = item?.Estado == true;

                // Botón eliminar/alta según estado real
                if (colName == "colDelete")
                {
                    e.Value = activo ? bmpDelete : bmpEnable;
                    e.FormattingApplied = true;
                    return;
                }

                // Columna de estado: mostrar texto
                if (colName == "status") // <-- cuidado: en minúsculas
                {
                    e.Value = activo ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;

                    // Pintado de fila según estado
                    var row = BoardMember.Rows[e.RowIndex];
                    if (!activo)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = BoardMember.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = BoardMember.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.SelectionBackColor = BoardMember.DefaultCellStyle.SelectionBackColor;
                        row.DefaultCellStyle.SelectionForeColor = BoardMember.DefaultCellStyle.SelectionForeColor;
                    }
                }
            };
        }
        // Evento que se ejecuta al hacer clic en el botón para agregar un nuevo socio.
        private void BNewMember_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario para agregar socio
            using (var fNewMember = new AddMemberForm())
            {
                // Muestra el formulario como un cuadro de diálogo
                if (fNewMember.ShowDialog() == DialogResult.OK)
                {
                   LoadPartners(); // Recarga la lista de socios si se agregó uno nuevo
                }
            }
        }

        private void PartnersView_Load(object sender, EventArgs e)
        {
            BuildAcl(); // Construye el diccionario de control de acceso (ACL)
            ApplyAcl(); // Aplica el control de acceso según el rol actual

            
        }

        // Evento que se ejecuta al hacer clic en una celda de la tabla.
        private void BoardMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clics fuera de las filas de datos            
            var col = BoardMember.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            var dniCell = BoardMember.Rows[e.RowIndex].Cells["dni"].Value.ToString();

            if (col == "colEdit")
            {
                // Obtener el DNI del usuario seleccionado
                ; 
                var parRepo = new PartnerRepository();
                // Obtener el usuario completo
                var partner = parRepo.GetByDni(dniCell);
                // Abrir el formulario en modo edición
                using (var fEditUser = new AddMemberForm(partner, false))
                {
                    if (fEditUser.ShowDialog() == DialogResult.OK)
                    {
                        // Recargar la grilla después de editar
                        LoadPartners();
                    }
                }
            }
            else if (col == "colView")
            {
                var parRepo = new PartnerRepository();
                var partner = parRepo.GetByDni(dniCell);
                using (var fViewUser = new AddMemberForm(partner, true)) // true para modo solo lectura
                {
                    fViewUser.ShowDialog(); // Solo mostrar, no editar
                }

            }
            else if (col == "colDelete")
            {
                var name = BoardMember.Rows[e.RowIndex].Cells["name"].Value;
                var cell = BoardMember.Rows[e.RowIndex].Cells["status"].Value?.ToString().Trim();
                
                var row = BoardMember.Rows[e.RowIndex];
                if (row == null) return;

                var p = row.DataBoundItem as Partner;
                if (p == null) return;

                bool s = p.Estado;
                var repo = new PartnerRepository();
                if (s)
                {
                    var confirm = MessageBox.Show($"¿Está seguro que desea desactivar el socio '{name}'?", "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {

                        var repoD = repo.DisablePartner(dniCell);
                        if (repoD == 0) MessageBox.Show("No se realizó la baja. Puede estar ya inactivo o no existe.");
                        LoadPartners();

                    }
                }
                else
                {
                    var confirm = MessageBox.Show($"¿Está seguro que desea activar el socio '{name}'?", "Confirmar activación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var repoE = repo.EnablePartner(dniCell);
                        if (repoE == 0) MessageBox.Show("No se realizó la activación. Puede estar ya activo o no existe.");
                        LoadPartners();
                    }
                }
            }
        }
        // Carga datos de ejemplo en la lista de socios.
        

        // Aplica los filtros de búsqueda, estado y membresía a la lista de socios y actualiza la tabla.
        private void ApplyFilters()
        {
            string query = TSearchPartner.Text?.Trim().ToLowerInvariant(); // Obtiene el texto de búsqueda en minúsculas
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar socio...";

            // Estado según banderas
            var s = CBStatus.SelectedItem?.ToString() ?? "Todos";
            bool WantActivo = s.Equals("Activo", StringComparison.OrdinalIgnoreCase);
            bool WantInactivo = s.Equals("Inactivo", StringComparison.OrdinalIgnoreCase);
            bool WantAllS = s.Equals("Todos", StringComparison.OrdinalIgnoreCase);

            bool IsActivo(Partner pP)
            {
                var val = pP.Estado;
                return val == true;
            }

            // Filtra la lista según el texto de búsqueda, estado y membresía
            var view = partnersList.Where(p =>
               (!hasQuery ||
                   (p.Nombre ?? "").ToLower().Contains(query) ||
                   (p.Dni ?? "").ToLower().Contains(query)  &&
               (WantAllS || (WantActivo && IsActivo(p)) || (WantInactivo && !IsActivo(p))))
           ).ToList();

            // Actualiza el datasource de la grilla
            BoardMember.DataSource = null;
            BoardMember.DataSource = view;

        }

        private void BuildAcl()
        {
            // Solo el rol Admin puede editar y eliminar
            Acl[colEdit] = Roles.Admin | Roles.Recep; ;
            Acl[colDelete] = Roles.Admin | Roles.Recep; ;
            // El rol Admin y Recepcionista pueden ver
            Acl[colView] = Roles.Admin | Roles.Recep | Roles.Coach;
        }

        // Aplica el control de acceso a las columnas de acción según el rol actual.
        private void ApplyAcl()
        {
            foreach (var keyValue in Acl)
                keyValue.Key.Visible = (CurrentRole & keyValue.Value) != 0; // Solo muestra la columna si el rol tiene permiso
        }


    }
}
