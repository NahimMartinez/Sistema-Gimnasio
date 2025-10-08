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
using Entities;
using Business;
using Data;

namespace Sistema_Gimnasio
{
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;

            // Asignar los controladores de eventos KeyPress
            TName.KeyPress += TName_KeyPress;            
            TCuit.KeyPress += TCuit_KeyPress;
            TPhone.KeyPress += TPhone_KeyPress;
        }

        // Evento Click del botón Guardar
        private void BSave_Click(object sender, EventArgs e)
        {
            var supplierService = new SupplierService();
            if (!ValidateInputs())
            {
                return; // Si la validación falla, no continua
            }
            // Crear el objeto Proveedor con los datos del formulario
            var newSupplier = new Supplier()
            {
                Nombre = TName.Text.Trim(),                
                Cuit = long.Parse(TCuit.Text.Trim()),
                Telefono = long.Parse(TPhone.Text.Trim()),
                Email = TEmail.Text.Trim()
            };            
            try
            {
                int newSupplierId = supplierService.SupplierCreate(newSupplier);
                // Aquí puedes manejar el ID del nuevo proveedor si es necesario
                MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close(); // Cierra el formulario después de guardar
                
            }
            catch (Business.Exceptions.DuplicateFieldException ex)
            {
                // Manejar la excepción específica de campo duplicado
                MessageBox.Show($"Error: {ex.Message}", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                MessageBox.Show($"Ocurrió un error al guardar el proveedor. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSupplier()
        {
            
            

        }

        // Evento Click del botón Limpiar
        private void BClean_Click(object sender, EventArgs e)
        {
            TName.Clear();
            TCuit.Clear();
            TPhone.Clear();
            TEmail.Clear();
            TCuit.Clear();
            
        }

        // Método para validar el formato del correo electrónico
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
            if (string.IsNullOrWhiteSpace(TName.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TName.Focus();
                return false;
            } else if (string.IsNullOrWhiteSpace(TCuit.Text))
            {
                                MessageBox.Show("Por favor, ingrese el CUIT del proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCuit.Focus();
                return false;
            } else if (string.IsNullOrWhiteSpace(TPhone.Text))
            {
                                MessageBox.Show("Por favor, ingrese el teléfono del proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TPhone.Focus();
                return false;
            } else if (TCuit.Text.Length != 11)
            {
                MessageBox.Show("El CUIT debe tener exactamente 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCuit.Focus();
                return false;
            } else if (TPhone.Text.Length < 8 || TPhone.Text.Length > 15)
            {
                MessageBox.Show("El teléfono debe tener entre 8 y 15 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TPhone.Focus();
                return false;
            }
            // Validar formato de correo electrónico si no está vacío
            if (!string.IsNullOrWhiteSpace(TEmail.Text) && !ValidEmail(TEmail.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TEmail.Focus();
                return false;
            }
            return true;
        }
    }
}
