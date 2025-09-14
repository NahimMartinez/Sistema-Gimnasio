using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entities;
using FontAwesome.Sharp;

namespace Sistema_Gimnasio
{
    public partial class UsersManagment : UserControl
    {
        public UsersManagment()
        {
            InitializeComponent();
            //BoardUsers.DataSource = typeof(List<UserView>);
            LoadUsers();
            BoardUsers.CellClick += BoardUsers_CellClick;
            SetupActionIcons();
        }

        private void BNewUser_Click_1(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewUser = new AddUsersForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewUser.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void LoadUsers()
        {
            var userService = new UserService();

            // DESACTIVAR la auto-generación de columnas
            BoardUsers.AutoGenerateColumns = false;

            BoardUsers.DataSource = userService.GetAllUsersForView();
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 16);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 16);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 16);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            BoardUsers.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardUsers.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        private void BoardUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = BoardUsers.Columns[e.ColumnIndex].Name;
            if (col == "colEdit")
            {
                // Obtener el username del usuario seleccionado
                var username = BoardUsers.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                var userService = new UserService();
                var userRepo = new Data.UserRepository();
                // Obtener el usuario completo
                var user = userRepo.GetByUsernameActivo(username);
                // Abrir el formulario en modo edición
                using (var fEditUser = new AddUsersForm(user))
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
                var name = BoardUsers.Rows[e.RowIndex].Cells["nombre"].Value;
                MessageBox.Show($"Ver usuario {name}");
            }
            else if (col == "colDelete")
            {
                var name = BoardUsers.Rows[e.RowIndex].Cells["nombre"].Value;
                MessageBox.Show($"Eliminar usuario {name}");
            }
        }
    }
}
