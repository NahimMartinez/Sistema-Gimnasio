using Business;
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

            // Asocia el evento de clic en celda a un método.
            BoardMember.CellClick += BoardMember_CellClick;
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
            LoadPartners(); // Carga datos de ejemplo en la lista de socios.
            this.Load += PartnersView_Load;

            // Configura los filtros de búsqueda y estado.
            TSearchPartner.TextChanged += (s, e) => ApplyFilters(); // Filtra al escribir en la caja de búsqueda.
            TSearchPartner.MouseClick += (s, e) => {
                // Limpia el texto de placeholder al hacer clic en la caja de búsqueda.
                if (TSearchPartner.Text == "Buscar socio...") {
                    TSearchPartner.Text = "";
                    TSearchPartner.ForeColor = Color.Black;
                }
            };
            TSearchPartner.LostFocus += (s, e) => {
                // Restaura el placeholder si la caja queda vacía al perder el foco.
                if (string.IsNullOrWhiteSpace(TSearchPartner.Text)) {
                    TSearchPartner.Text = "Buscar socio...";
                    TSearchPartner.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar el estado.
            CBMembership.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar la membresía.


        }

        private void LoadPartners()
        {
            var partnerSup = new PartnerService(); // Servicio para obtener proveedores
            var allPartner = partnerSup.GetAllPartnerView(); // Obtiene todos los proveedores en formato lista
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
            BoardMember.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return; // Ignora encabezados
                string col = BoardMember.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") {
                    var status = BoardMember.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = status?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    ev.Value = activo ? bmpDelete : bmpEnable; 
                    ev.FormattingApplied = true; }


                if (col == "status")
                {
                    var st = BoardMember.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = st?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    var row = BoardMember.Rows[ev.RowIndex];
                    if (!activo)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        // Resetea a valores por defecto
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
                    //aca tenemos que volver a cargar los datos cuando se guarde el nuevo proveedor(cuando sea dinamico)
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
            var name = BoardMember.Rows[e.RowIndex].Cells["name"].Value; // Obtiene el nombre del socio
            var col = BoardMember.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            // Muestra un mensaje según la acción seleccionada
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
        // Carga datos de ejemplo en la lista de socios.
        

        // Aplica los filtros de búsqueda, estado y membresía a la lista de socios y actualiza la tabla.
        private void ApplyFilters()
        {
            string query = TSearchPartner.Text?.Trim().ToLowerInvariant(); // Obtiene el texto de búsqueda en minúsculas
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar proveedor...";

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

        // Clase interna que representa la información de un socio.
        private class PartnerViewModel
        {
            public string Name { get; set; } // Nombre del socio
            public string Dni { get; set; } // DNI del socio
            public string Phone { get; set; } // Teléfono del socio
            public string Plan { get; set; } // Tipo de membresía
            public string Estado { get; set; } // Estado del socio (Activo/Inactivo)
        }


    }
}
