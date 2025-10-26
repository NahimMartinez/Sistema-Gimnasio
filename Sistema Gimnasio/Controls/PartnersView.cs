using Business;
using Data;
using Entities;
using FontAwesome.Sharp;
using Sistema_Gimnasio.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        // Lista que almacena la información de los socios
        private List<PartnerDataGrid> partnersList = new List<PartnerDataGrid>();

        private readonly MembershipService membershipService = new MembershipService();

        // Paginación
        private int currentPage = 1;
        private int pageSize = 20; 
        private int totalPages = 1;

        

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

            // Si cambian los combosbox o el texto, resetea a página 1 y vuelve a filtrar.
            CBStatus.SelectedIndexChanged += (s, e) => { currentPage = 1; ApplyFilters(); }; // Filtra al cambiar el estado.
            CBMembership.SelectedIndexChanged += (s, e) => { currentPage = 1; ApplyFilters(); }; // Filtra al cambiar la membresía.
            TSearchPartner.TextChanged += (s, e) => { currentPage = 1; ApplyFilters(); }; // Filtra al escribir en la caja de búsqueda.

            // Placeholder simple para la caja de texto.
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

            // Reiniciar paginación al cargar todos
            currentPage = 1;
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
            Bitmap bmpViewPdf = IconChar.FilePdf.ToBitmap(Color.Black, 30);

            // Asigna los iconos a las columnas correspondientes.
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;
            colViewPdf.Image = bmpViewPdf;

            // Evento para mostrar los iconos en las celdas de acción.
            BoardMember.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0) return; //Ignora encabezados
                var colName = BoardMember.Columns[e.ColumnIndex].Name;

                // Íconos fijos
                if (colName == "colEdit") { e.Value = bmpEdit; e.FormattingApplied = true; return; }
                if (colName == "colView") { e.Value = bmpView; e.FormattingApplied = true; return; }
                if (colName == "colViewPdf") { e.Value = bmpViewPdf; e.FormattingApplied = true; return; }

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
                        //Colores para inactivo
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        // Colores por defecto para activo
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

        private void BNewMember_Click(object sender, EventArgs e)
        {
            using (var fNewItem = new AddMemberForm())
            {
                // Mostramos el primer formulario y esperamos a que se cierre.
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {
                    // Si el usuario guardó (DialogResult.OK), recogemos los datos.
                    Person newPerson = fNewItem.NewPerson;
                    Partner newPartner = fNewItem.NewPartner;

                    // Asignar membresía y clases
                    // Abrimos el segundo formulario, pasándole los datos del primero.
                    using (var fMembership = new MembershipForm(newPerson, newPartner))
                    {
                        // Mostramos el formulario de membresía.
                        if (fMembership.ShowDialog() == DialogResult.OK)
                        {
                            // Si la membresía también se guardó correctamente,
                            // recargamos la lista de socios para ver al nuevo miembro.
                            LoadPartners();
                        }
                    }
                }
            }
        }

        private void PartnersView_Load(object sender, EventArgs e)
        {
            BuildAcl(); // Construye el diccionario de control de acceso (ACL)
            ApplyAcl(); // Aplica el control de acceso según el rol actual
            if (CurrentRole == Roles.Coach)
            {
                BNewMember.Visible = false;
                BRenovation.Visible = false;
            }
            try
            {
                //Actualiza las membresías vencidas al cargar la vista
                membershipService.synchronizeMembership();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al sincronizar membresías vencidas: {ex.Message}");
            }
            LoadPartners(); // Carga datos de socio

        }

        private void BoardMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validar que el clic fue en una fila de datos válida (no en la cabecera)
            if (e.RowIndex < 0) return;

            //Obtener la fila y el objeto de datos del socio correspondiente
            var row = BoardMember.Rows[e.RowIndex];
            var partnerData = row.DataBoundItem as PartnerDataGrid;
            if (partnerData == null) return;

            //Obtener el nombre de la columna en la que se hizo clic
            var columnName = BoardMember.Columns[e.ColumnIndex].Name;

            //Ejecutar la acción correspondiente a la columna
            try
            {
                switch (columnName)
                {
                    case "colEdit":
                        var partnerRepoEdit = new PartnerRepository();
                        var partnerToEdit = partnerRepoEdit.GetByDni(partnerData.Dni);
                        if (partnerToEdit == null)
                        {
                            MessageBox.Show("No se encontró al socio para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        using (var formEditPartner = new AddMemberForm(partnerToEdit, false))
                        {
                            if (formEditPartner.ShowDialog() == DialogResult.OK)
                            {
                                LoadPartners(); // Recargar la grilla si se guardaron cambios
                            }
                        }
                        break;

                    case "colView":
                        var partnerRepoView = new PartnerRepository();
                        var partnerToView = partnerRepoView.GetByDni(partnerData.Dni);
                        if (partnerToView == null)
                        {
                            MessageBox.Show("No se encontró al socio para visualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        using (var formViewPartner = new AddMemberForm(partnerToView, true))
                        {
                            formViewPartner.ShowDialog();
                        }
                        break;

                    case "colDelete":
                        string actionText = partnerData.Estado ? "desactivar" : "activar";
                        var confirmationResult = MessageBox.Show(string.Format("¿Está seguro que desea {0} al socio '{1} {2}'?", actionText, partnerData.Nombre, partnerData.Apellido),
                                                                 "Confirmar " + actionText,
                                                                 MessageBoxButtons.YesNo,
                                                                 partnerData.Estado ? MessageBoxIcon.Warning : MessageBoxIcon.Question);

                        if (confirmationResult == DialogResult.Yes)
                        {
                            var partnerRepoToggle = new PartnerRepository();
                            int result = 0;
                            if (partnerData.Estado)
                            {
                                result = partnerRepoToggle.DisablePartner(partnerData.Dni);
                            }
                            else
                            {
                                result = partnerRepoToggle.EnablePartner(partnerData.Dni);
                            }

                            if (result == 0) MessageBox.Show(string.Format("No se pudo {0} al socio.", actionText), "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            LoadPartners(); // Recargar siempre para reflejar el cambio
                        }
                        break;

                    case "colViewPdf":
                        // Llama al servicio que genera TODOS los PDFs para el Id del socio.
                        var paymentService = new PaymentService();

                        using (var fbd = new FolderBrowserDialog())
                        {
                            fbd.Description = "Seleccione la carpeta donde se guardarán los comprobantes del socio.";
                            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                            {
                                try
                                {
                                    int generated = paymentService.GenerateAllPaymentReceiptsForPartner(partnerData.IdPersona, fbd.SelectedPath);

                                    if (generated == 0)
                                    {
                                        MessageBox.Show("No se generaron comprobantes para este socio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"{generated} comprobante(s) fueron generados exitosamente en la carpeta seleccionada.", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Ocurrió un error al generar los comprobantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Debug.WriteLine("Error al generar comprobantes de pago: " + ex);
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                // Un manejador de errores central para cualquier excepción inesperada.
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Error en Datagrid: " + ex.ToString());
            }
        }



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

            // Filtro de Membresía (Vigente/Vencida)
            var m = CBMembership.SelectedItem?.ToString() ?? "Todos";
            bool WantVigente = m.Equals("Vigente", StringComparison.OrdinalIgnoreCase);
            bool WantVencida = m.Equals("Vencida", StringComparison.OrdinalIgnoreCase);
            bool WantAllM = m.Equals("Todos", StringComparison.OrdinalIgnoreCase);

            // Filtra la lista según el texto de búsqueda, estado y membresía
            var filtered = partnersList.Where(p =>
               (!hasQuery ||
                   (p.Nombre ?? "").ToLower().Contains(query) ||
                   (p.Apellido ?? "").ToLower().Contains(query) ||
                   (p.Dni ?? "").ToLower().Contains(query))  &&
               (WantAllS || (WantActivo && p.Estado) || (WantInactivo && !p.Estado)) &&
               (WantAllM || (WantVigente && p.EstadoMembresia) || (WantVencida && !p.EstadoMembresia))
           ).ToList();

            // Calcula paginación
            totalPages = Math.Max(1, (int)Math.Ceiling((double)filtered.Count / pageSize));
            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            var paged = filtered.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            // Actualiza el datasource de la grilla
            BoardMember.DataSource = null;
            BoardMember.DataSource = paged;

            // Actualiza controles de paginación si existen
            try
            {
                if (lblPageInfo != null)
                    lblPageInfo.Text = $"Página {currentPage} de {totalPages}";
                if (btnPrevPage != null)
                    btnPrevPage.Enabled = currentPage > 1;
                if (btnNextPage != null)
                    btnNextPage.Enabled = currentPage < totalPages;
            }
            catch { }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ApplyFilters();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                ApplyFilters();
            }
        }

        private void BuildAcl()
        {
            // Solo el rol Admin puede editar y eliminar
            Acl[colEdit] = Roles.Admin | Roles.Recep; ;
            Acl[colDelete] = Roles.Admin | Roles.Recep; ;
            // El rol Admin y Recepcionista pueden ver
            Acl[colView] = Roles.Admin | Roles.Recep | Roles.Coach;
            Acl[colViewPdf] = Roles.Admin | Roles.Recep;
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
            string texto = activa ? "Vigente" : "Vencida";

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
