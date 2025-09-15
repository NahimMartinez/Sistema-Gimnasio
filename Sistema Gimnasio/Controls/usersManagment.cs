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
        public UsersManagment()
        {
            InitializeComponent();
            
            LoadUsers();
            //manejador del evento para el click en la grilla editar, ver , borrar
            BoardUsers.CellClick += BoardUsers_CellClick;
            //configuro los iconos de las acciones
            SetupActionIcons();
        }
        //evento click del boton nuevo usuario
        private void BNewUser_Click_1(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewUser = new AddUsersForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewUser.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }
        //metodo para cargar los usuarios en la grilla
        private void LoadUsers()
        {
            var userService = new UserService();
                        
            BoardUsers.AutoGenerateColumns = false;
            //asigno la lista de usuarios como origen de datos de la grilla
            BoardUsers.DataSource = userService.GetAllUsersForView();
        }
        //metodo para configurar los iconos de las acciones en la grilla
        private void SetupActionIcons()
        {
            // Asegurarse de que las columnas de imagen existen
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 16);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 16);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 16);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;
            //evento para formatear las celdas, asignar los iconos y evitar que el datasouce los sobrescriba
            BoardUsers.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardUsers.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }
        //evento click en la grilla para manejar editar, ver y borrar
        private void BoardUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = BoardUsers.Columns[e.ColumnIndex].Name;
            if (col == "colEdit")
            {
                // Obtener el username del usuario seleccionado
                var dniCell = BoardUsers.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                //var userService = new UserService();
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
                //detalle de solo lectura
                var dniCell = BoardUsers.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                var userRepo = new Data.UserRepository();
                var user = userRepo.GetByUser(dniCell);
                using (var fView = new AddUsersForm(user, true)) // true = solo lectura
                {
                    fView.ShowDialog();
                }
            }
            else if (col == "colDelete")
            {
                //habilitar o deshabilitar usuario
                var dniCell = BoardUsers.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                var name = BoardUsers.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                var cell = BoardUsers.Rows[e.RowIndex].Cells["status"].Value?.ToString().Trim();
                //si el estado es 1 o Activo entonces está activo
                bool s = cell == "1" || cell?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;
                
                if (s)
                {
                    var confirm = MessageBox.Show($"¿Dar de baja a {name}?",
                                                                  "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var repo = new Data.UserRepository();
                        var rows = repo.DisableUser(dniCell);
                        if (rows == 0) MessageBox.Show("No se realizó la baja. Puede estar ya inactivo o no existe.");
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
                        var rows = repo.EnableUser(dniCell);
                        if (rows == 0) MessageBox.Show("No se realizó la alta. Puede estar ya activo o no existe.");
                        LoadUsers();
                    }
                }
            }
        }
    }
}
