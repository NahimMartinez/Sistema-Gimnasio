using Business;
using Entities;
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
    public partial class LoginView : Form
    {
         // Servicio que hace la autenticación (DB).
        private readonly AuthService auth = new AuthService();
        public User UserAuth { get; private set; }       
        
        public LoginView()
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            // Leer y validar entradas.
            var username = TUser.Text.Trim();
            var password = TPass.Text; // No trim a password por seguridad. porque contraseñas es un campo exacto y trim lo puede cambiar

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Ingresá el usuario.");
                TUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingresá la contraseña.");
                TPass.Focus();
                return;
            }

            // Autenticar. Manejar credenciales inválidas e inactivo.
            User u;
            try
            {
                u = auth.Login(username, password); // Devuelve null si falla credencial.
            }
            catch (Exception)
            {
                // Error técnico (DB caída, etc.). No revelar detalles al usuario final.
                MessageBox.Show("No se pudo iniciar sesión. Intentá de nuevo.");                
                return;
            }

            if (u == null)
            {
                MessageBox.Show("Usuario o contraseña inválidos.");
                return;
            }

            if (!u.Estado) // Campo booleano: activo/inactivo.
            {
                MessageBox.Show("Usuario inactivo.");
                return;
            }

            //Éxito: exponer el usuario autenticado y cerrar el diálogo.
            UserAuth = u;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cerrar formulario.
        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

