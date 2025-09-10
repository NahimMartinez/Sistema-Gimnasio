using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Entities;
using FontAwesome.Sharp;

namespace Sistema_Gimnasio
{
    public partial class AddUsersForm : Form
    {
        public AddUsersForm()
        {
            InitializeComponent();
            ConfigureValidations();
        }

        private void ConfigureValidations()
        {
            // Validar solo letras para Nombre y Apellido
            txtNombre.KeyPress += TxtSoloLetras_KeyPress;
            txtApellido.KeyPress += TxtSoloLetras_KeyPress;

            // Validar solo números para DNI y Teléfono
            txtDni.KeyPress += TxtSoloNumeros_KeyPress;
            txtTelefono.KeyPress += TxtSoloNumeros_KeyPress;
        }

        private void TxtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, espacio, backspace y borrar
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, backspace y borrar
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        // Función para validar que todos los campos tengan datos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor ingrese el apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor ingrese el DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor ingrese el email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (!ValidEmail(txtEmail.Text))
            {
                MessageBox.Show("El email ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor ingrese el teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return false;
            }

            if (txtContraseña.Text != txtContraseña2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña2.Focus();
                return false;
            }

            if (CBRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBRol.Focus();
                return false;
            }

            return true; // Todos los campos son válidos
        }

        private bool ValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void BLimpiar_Click_1(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtContraseña2.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            CBRol.SelectedIndex = -1;
        }

        private void BCrear_Click_1(object sender, EventArgs e)
        {
            var userService = new Business.UserService();
            // Validar antes de guardar
            if (!ValidarCampos())
            {
                return; // Detener si hay errores
            }
            var newPerson = new Person()
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Dni = txtDni.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Estado = true // Activo por defecto
            };

            var newUser = new User() { 
                Username = txtUsuario.Text.Trim(),
                Password = txtContraseña.Text,
                RolId = (int)CBRol.SelectedValue
            };         
            
            userService.UserCreate(newPerson, newUser);
            MessageBox.Show("Datos validados correctamente. Guardando...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CBVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVerContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0'; // Mostrar texto
                txtContraseña2.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '●'; // Ocultar con puntos
                txtContraseña2.PasswordChar = '●';
            }
        }

        private void AddUsersForm_Load(object sender, EventArgs e)
        {
            var rolService = new Business.RolService();
            CBRol.DataSource = rolService.GetAll();
            CBRol.DisplayMember = "Nombre";
            CBRol.ValueMember = "IdRol";
            CBRol.SelectedIndex = -1; // Ningún rol seleccionado por defecto
        }
    }
}