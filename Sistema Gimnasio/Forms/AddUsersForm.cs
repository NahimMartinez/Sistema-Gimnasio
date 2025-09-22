using Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Sistema_Gimnasio
{
    public partial class AddUsersForm : Form
    {
        private readonly User editingUser = null;
        private readonly bool soloLectura = false;
        public AddUsersForm() : this(null, false) { }

        

        public AddUsersForm(User userToEdit, bool soloLectura)
        {
            InitializeComponent();
            ConfigureValidations();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;

            this.soloLectura = soloLectura;
            this.editingUser = userToEdit;
            if (userToEdit != null)
            {
                editingUser = userToEdit;
                CargarDatos(userToEdit);
                BLimpiar.Enabled = false; // Deshabilitar botón limpiar en modo edición
                this.Text = "Editar usuario"; // Cambia el título de la ventana
            }

            if(soloLectura)
            {
                ActivarSoloLectura();
                this.Text = "Ver usuario"; // Cambia el título de la ventana
            }
            
        }

        private void ActivarSoloLectura()
        {
            SetReadOnly(this);

            // Ocultar acciones de edición
            BSave.Visible = false;
            BLimpiar.Visible = false;
        }

        private void SetReadOnly(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (c is TextBox tb) tb.ReadOnly = true;
                else if (c is ComboBox cb) cb.Enabled = false;
                else if (c is CheckBox ch) ch.Enabled = false;
                else if (c is DateTimePicker dt) dt.Enabled = false;
                else if (c is NumericUpDown num) num.Enabled = false;

                if (c.HasChildren) SetReadOnly(c);
            }
        }
        private void CargarDatos(User u)
        {
            txtNombre.Text = u.Nombre;
            txtApellido.Text = u.Apellido;
            txtDni.Text = u.Dni;
            txtTelefono.Text = u.Telefono;
            txtEmail.Text = u.Email;
            txtUsuario.Text = u.Username;
            txtContraseña.Text = u.Password;
            txtContraseña2.Text = u.Password;
            CBRol.SelectedValue = u.RolId;
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


        // Validar formato de email
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

        // Limpiar todos los campos del formulario
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

        // Guardar o actualizar usuario
        private void BSave_Click_1(object sender, EventArgs e)
        {
            var userService = new Business.UserService();

            if (!ValidarCampos())
                return;

            try
            {
                if (editingUser == null)
                {
                    // Crear nuevo usuario
                    var newPerson = new Person()
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Apellido = txtApellido.Text.Trim(),
                        Dni = txtDni.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Estado = true
                    };

                    var newUser = new User()
                    {
                        Username = txtUsuario.Text.Trim(),
                        Password = txtContraseña.Text,
                        RolId = (int)CBRol.SelectedValue
                    };

                    userService.UserCreate(newPerson, newUser);

                    MessageBox.Show("Usuario creado con éxito.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Editar usuario existente
                    editingUser.Nombre = txtNombre.Text.Trim();
                    editingUser.Apellido = txtApellido.Text.Trim();
                    editingUser.Dni = txtDni.Text.Trim();
                    editingUser.Telefono = txtTelefono.Text.Trim();
                    editingUser.Email = txtEmail.Text.Trim();
                    editingUser.Username = txtUsuario.Text.Trim();
                    editingUser.Password = txtContraseña.Text;
                    editingUser.RolId = (int)CBRol.SelectedValue;
                    editingUser.IdUsuario = editingUser.IdPersona; // ojo con esto

                    var userRepo = new Data.UserRepository();
                    var personRepo = new Data.PersonRepository();

                    userRepo.UpdateUser(editingUser);
                    personRepo.Update(editingUser);

                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Business.Exceptions.DuplicateFieldException ex)
            {
                // Captura tu excepción custom -> mensaje entendible
                MessageBox.Show($"Error: {ex.Message}", "Dato duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Cualquier otro error inesperado
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mostrar u ocultar contraseña
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

        // Cargar roles en el ComboBox al cargar el formulario
        private void AddUsersForm_Load(object sender, EventArgs e)
        {
            var rolService = new Business.RolService();
            CBRol.DataSource = rolService.GetAll();
            CBRol.DisplayMember = "Nombre";
            CBRol.ValueMember = "IdRol";
            if (editingUser != null)
                CBRol.SelectedValue = editingUser.RolId;
            else
                CBRol.SelectedIndex = -1;
        }
    }
}