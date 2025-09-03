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

namespace Sistema_Gimnasio
{
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
            TName.KeyPress += TName_KeyPress;
            TLastName.KeyPress += TLastName_KeyPress;
            TCuit.KeyPress += TCuit_KeyPress;
            TPhone.KeyPress += TPhone_KeyPress;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return; // Si la validación falla, no continua
            }
            MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BClean_Click(object sender, EventArgs e)
        {
            TName.Clear();
            TLastName.Clear();
            TCuit.Clear();
            TPhone.Clear();
            TEmail.Clear();
            TCuit.Clear();
            
        }

        private bool ValidEmail(string email)
        {
            try
            {
                //intenta crear la direccion de correo
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                //si falla, no es valida
                return false;
            }
        }

        private void TName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignorar el carácter si no es válido
            }
        }

        private void TLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignorar el carácter si no es válido
            }
        }

        private void TCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter si no es válido
            }
        }

        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter si no es válido
            }
        }

        private bool ValidateInputs()
        {
            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(TName.Text) ||
                string.IsNullOrWhiteSpace(TLastName.Text) ||
                string.IsNullOrWhiteSpace(TCuit.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validar formato de correo electrónico si no está vacío
            if (!string.IsNullOrWhiteSpace(TEmail.Text) && !ValidEmail(TEmail.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
