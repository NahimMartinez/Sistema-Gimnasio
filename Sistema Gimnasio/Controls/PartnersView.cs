using Business;
using Data;
using Entities;
using FontAwesome.Sharp;
using Sistema_Gimnasio.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
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
        private List<PartnerDataGrid> partnersList = new List<PartnerDataGrid>();

        private readonly MembershipService membershipService = new MembershipService();

        // Constructor: se ejecuta al crear el control.
        public PartnersView()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.
            WireFilters(); // Configura los filtros de búsqueda y estado.            
            BoardMember.CellClick += BoardMember_CellClick;
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
            this.Load += PartnersView_Load;
            BoardMember.CellPainting += BoardMember_CellPainting;


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
            partnersList = allPartner.Select(p => new PartnerDataGrid
            {
                        IdPersona = p.IdPersona,
                        Nombre = p.Nombre,
                        Apellido = p.Apellido,
                        Dni = p.Dni,
                        Telefono = p.Telefono,
                        Membresia = p.Membresia,           
                        FechaVencimiento = p.FechaVencimiento,
                        EstadoMembresia = p.EstadoMembresia,
                        Estado = p.Estado
                    }).ToList();
            BoardMember.AutoGenerateColumns = false; // No generar columnas automáticamente
            BoardMember.DataSource = partnersList;
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
                var item = BoardMember.Rows[e.RowIndex].DataBoundItem as PartnerDataGrid;
                bool activo = item?.Estado == true;

                // Botón eliminar/alta según estado real
                if (colName == "colDelete")
                {
                    e.Value = activo ? bmpDelete : bmpEnable;
                    e.FormattingApplied = true;
                    return;
                }

                // Columna de estado: mostrar texto
                if (colName == "status")
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

                if (colName == "estadoMembresia")
                {
                    if (item != null)
                    {
                        e.Value = item.EstadoMembresia ? "Vigente" : "Vencida";
                        e.FormattingApplied = true;
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

            try
            {
                membershipService.synchronizeMembership();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al sincronizar membresías vencidas: {ex.Message}");
            }
            LoadPartners(); // Carga datos de socio

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

                var p = row.DataBoundItem as PartnerDataGrid;
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
                        

            // Filtra la lista según el texto de búsqueda, estado y membresía
            var view = partnersList.Where(p =>
               (!hasQuery ||
                   (p.Nombre ?? "").ToLower().Contains(query) ||
                   (p.Apellido ?? "").ToLower().Contains(query) ||
                   (p.Dni ?? "").ToLower().Contains(query))  &&
               (WantAllS || (WantActivo && p.Estado) || (WantInactivo && !p.Estado))
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

        private void BRenovation_Click(object sender, EventArgs e)
        {
            if (BoardMember.SelectedRows == null) return;
            int idRow = Convert.ToInt32(BoardMember.CurrentRow.Cells["idPartner"].Value);
            using (var fMembership = new MembershipForm(idRow))
            {
               // Muestra el formulario como un cuadro de diálogo
               if (fMembership.ShowDialog() == DialogResult.OK)
               {
                   LoadPartners(); // Recarga la lista de socios si se agregó uno nuevo
               }
            }
            
            
        }

        private void BoardMember_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (BoardMember.Columns[e.ColumnIndex].Name != "estadoMembresia") return;

            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            var item = BoardMember.Rows[e.RowIndex].DataBoundItem as PartnerDataGrid;
            if (item == null) return;

            bool activa = item.EstadoMembresia;
            string texto = activa ? "Activa" : "Vencida";

            Color back = activa ? Color.LightGreen : Color.LightCoral;
            Color border = activa ? Color.SeaGreen : Color.Firebrick;
            Color text = Color.Black;

            var rect = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + 6, e.CellBounds.Width - 40, e.CellBounds.Height - 20);
            int r = 10; int d = r * 2;

            using (var path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var b = new SolidBrush(back)) e.Graphics.FillPath(b, path);
                using (var p = new Pen(border, 1)) e.Graphics.DrawPath(p, path);
            }

            TextRenderer.DrawText(e.Graphics, texto, new Font("Segoe UI", 9, FontStyle.Bold),
                                  rect, text, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }



    }
}
