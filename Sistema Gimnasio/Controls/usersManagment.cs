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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_Gimnasio
{
    public partial class UsersManagment : UserControl
    {
        private List<UserView> usersList = new List<UserView>();

        public UsersManagment()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.
            WireFilters(); // Configura los filtros y sus eventos.
            LoadUsers(); // Carga los usuarios y los inserta en la grilla.
            BoardUsers.CellClick += BoardUsers_CellClick; // Asocia el evento de clic en celda a un método.
            SetupActionIcons(); // Configura los iconos de las acciones en la grilla.
        }
        // Evento click del botón para agregar un nuevo usuario.
        private void BNewUser_Click_1(object sender, EventArgs e)
        {
            // Crea una instancia del formulario para agregar usuario
            using (var fNewUser = new AddUsersForm())
            {
                // Muestra el formulario como un cuadro de diálogo
                if (fNewUser.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers(); // Vuelve a cargar los usuarios en la grilla
                }
            }
        }

        // Configura los filtros y sus eventos.
        private void WireFilters()
        {
            // Valores por defecto en los ComboBox
            CBStatus.SelectedIndex = 0; // Todos
            CBRol.SelectedIndex = 0;    // Todos

            // Eventos de filtro: al cambiar el estado, rol o texto de búsqueda se aplican los filtros
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
            CBRol.SelectedIndexChanged += (s, e) => ApplyFilters();
            TSearch.TextChanged += (s, e) => ApplyFilters();

            // Placeholder simple para la caja de búsqueda
            TSearch.GotFocus += (s, e) => {
                if (TSearch.Text == "Buscar usuario...") { 
                            TSearch.Text = ""; TSearch.ForeColor = Color.Black;     
                }
            };
            TSearch.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearch.Text)) { 
                            TSearch.Text = "Buscar usuario..."; TSearch.ForeColor = Color.Gray; 
                }
            };
        }

        // Método para cargar los usuarios en la grilla.
        private void LoadUsers()
        {
            var userService = new UserService(); // Servicio para obtener usuarios
            var allUser = userService.GetAllUsersForView(); // Obtiene todos los usuarios
            // Convierte a lista local para filtrar
            usersList = allUser.Select(u => new UserView
            {
                Nombre = u.Nombre,
                Dni = u.Dni,
                Usuario = u.Usuario,
                Rol = u.Rol,
                Status = u.Status?.ToString()
            }).ToList();

            BoardUsers.AutoGenerateColumns = false; // No generar columnas automáticamente
            ApplyFilters(); // Muestra según filtros actuales
        }
                

        // Aplica los filtros de búsqueda, estado y rol a la lista de usuarios y actualiza la grilla.
        private void ApplyFilters()
        {
            // Texto de búsqueda en minúsculas y sin espacios
            var q = TSearch.Text?.Trim().ToLowerInvariant();
            var hasQuery = !string.IsNullOrWhiteSpace(q) && q != "buscar usuario...";

            // Estado según banderas
            var s = CBStatus.SelectedItem?.ToString() ?? "Todos";
            bool WantActivo = s.Equals("Activo", StringComparison.OrdinalIgnoreCase);
            bool WantInactivo = s.Equals("Inactivo", StringComparison.OrdinalIgnoreCase);
            bool WantAllS = s.Equals("Todos", StringComparison.OrdinalIgnoreCase);

            // Rol
            var r = CBRol.SelectedItem?.ToString() ?? "Todos";
            bool WantAllR = r.Equals("Todos", StringComparison.OrdinalIgnoreCase);

            // Normalizador de estado: determina si el usuario está activo
            bool IsActivo(UserView u)
            {
                var val = (u.Status ?? "").Trim();
                return val == "1" || val.Equals("Activo", StringComparison.OrdinalIgnoreCase);
            }
            // Filtro combinado: filtra por texto, estado y rol
            var view = usersList.Where(u =>
                (!hasQuery ||
                    (u.Nombre ?? "").ToLower().Contains(q) ||
                    (u.Dni ?? "").ToLower().Contains(q) ||
                    (u.Usuario ?? "").ToLower().Contains(q)) &&
                (WantAllS || (WantActivo && IsActivo(u)) || (WantInactivo && !IsActivo(u))) &&
                (WantAllR || string.Equals(u.Rol ?? "", r, StringComparison.OrdinalIgnoreCase))
            ).ToList();
            // Actualiza el datasource de la grilla
            BoardUsers.DataSource = null;           
            BoardUsers.DataSource = view;           
        }

        // Método para configurar los iconos de las acciones en la grilla.
        private void SetupActionIcons()
        {
            // Crea imágenes para los iconos usando FontAwesome.
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30); // Icono de editar
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30); // Icono de ver
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30); // Icono de eliminar
            Bitmap bmpEnable = IconChar.UserCheck.ToBitmap(Color.Black, 30); // Icono de alta
            // Asigna los iconos a las columnas correspondientes
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;
            // Evento para formatear las celdas, asignar los iconos y evitar que el datasource los sobrescriba
            BoardUsers.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return; // Ignora encabezados
                string col = BoardUsers.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") {
                    // Cambia el icono según el estado del usuario
                    var status = BoardUsers.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = status?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    ev.Value = activo ? bmpDelete : bmpEnable;
                    ev.FormattingApplied = true;
                }
                // Marca la fila inactiva
                if (col == "status")
                {
                    var st = BoardUsers.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = st?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    var row = BoardUsers.Rows[ev.RowIndex];
                    if (!activo)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        // Resetea a valores por defecto
                        row.DefaultCellStyle.BackColor = BoardUsers.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = BoardUsers.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.SelectionBackColor = BoardUsers.DefaultCellStyle.SelectionBackColor;
                        row.DefaultCellStyle.SelectionForeColor = BoardUsers.DefaultCellStyle.SelectionForeColor;
                    }
                }
            };
        }

        // Evento click en la grilla para manejar editar, ver y borrar.
        private void BoardUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clics fuera de las filas de datos
            var col = BoardUsers.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            if (col == "colEdit")
            {
                // Obtener el DNI del usuario seleccionado
                var dniCell = BoardUsers.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                var userRepo = new Data.UserRepository();
                // Obtener el usuario completo
                var user = userRepo.GetByUser(dniCell);
                // Abrir el formulario en modo edición
                using (var fEditUser = new AddUsersForm(user, false))
                {
                    if (fEditUser.ShowDialog() == DialogResult.OK)
                    {
                        // Recargar la grilla después de editar
                        LoadUsers();
                    }
                }
            }
            else if (col == "colView")
            {
                // Detalle de solo lectura
                var dniCellView = BoardUsers.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                var userRepo = new Data.UserRepository();
                var user = userRepo.GetByUser(dniCellView);
                using (var fView = new AddUsersForm(user, true)) // true = solo lectura
                {
                    fView.ShowDialog();
                }
            }
            else if (col == "colDelete")
            {
                // Habilitar o deshabilitar usuario
                var dniCell = BoardUsers.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                var name = BoardUsers.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                var cell = BoardUsers.Rows[e.RowIndex].Cells["status"].Value?.ToString().Trim();
                // Si el estado es 1 o Activo entonces está activo
                bool s = cell == "1" || cell?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;
                
                if (s)
                {
                    var confirm = MessageBox.Show($"¿Dar de baja a {name}?",
                                                                  "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (confirm == DialogResult.Yes)
                    {
                        var repo = new Data.UserRepository();
                        var repoD = repo.DisableUser(dniCell);
                        if (repoD == 0) MessageBox.Show("No se realizó la baja. Puede estar ya inactivo o no existe.");
                        LoadUsers();
                    }
                }
                else
                {
                    var confirm = MessageBox.Show($"¿Dar de alta a {name}?",
                                                                  "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var repo = new Data.UserRepository();
                        var repoE = repo.EnableUser(dniCell);
                        if (repoE == 0) MessageBox.Show("No se realizó la alta. Puede estar ya activo o no existe.");
                        LoadUsers();
                    }
                } 
            }
        }
    }
}
