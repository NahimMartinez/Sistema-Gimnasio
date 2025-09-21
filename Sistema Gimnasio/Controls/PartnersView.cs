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
        private List<PartnerViewModel> partnersList = new List<PartnerViewModel>();

        // Constructor: se ejecuta al crear el control.
        public PartnersView()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.

            // Asocia el evento de clic en celda a un método.
            BoardMember.CellClick += BoardMember_CellClick;
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
            LoadFakeData(); // Carga datos de ejemplo en la lista de socios.

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
            BoardMember.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return; // Ignora encabezados
                string col = BoardMember.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
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
        private void LoadFakeData()
        {
            partnersList = new List<PartnerViewModel>
            {
                new PartnerViewModel { Name = "Juan Pérez", Dni = "12345678", Phone = "3794-111111", Plan = "Mensual", Estado = "Activo" },
                new PartnerViewModel { Name = "María López", Dni = "87654321", Phone = "3794-222222", Plan = "Semanal", Estado = "Inactivo" },
                new PartnerViewModel { Name = "Carlos Gómez", Dni = "45678912", Phone = "3794-333333", Plan = "Diaria", Estado = "Activo" }
            };
            ApplyFilters(); // Aplica los filtros para mostrar los datos en la tabla.
        }

        // Aplica los filtros de búsqueda, estado y membresía a la lista de socios y actualiza la tabla.
        private void ApplyFilters()
        {
            string query = TSearchPartner.Text?.Trim(); // Obtiene el texto de búsqueda
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "Buscar socio...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos"; // Obtiene el estado seleccionado
            string membresia = CBMembership.SelectedItem?.ToString() ?? "Todos"; // Obtiene la membresía seleccionada

            // Filtra la lista según el texto de búsqueda, estado y membresía
            var filtered = partnersList.Where(p =>
                (!hasQuery || (p.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" || (p.Estado ?? "").Equals(estado, StringComparison.OrdinalIgnoreCase)) &&
                (membresia == "Todos" || (p.Plan ?? "").Equals(membresia, StringComparison.OrdinalIgnoreCase))
            ).ToList();
            BoardMember.Rows.Clear(); // Limpia la tabla
            foreach (var p in filtered)
            {
                // Agrega cada socio filtrado a la tabla
                BoardMember.Rows.Add(p.Name, p.Dni, p.Phone, p.Plan, p.Estado);
            }
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
