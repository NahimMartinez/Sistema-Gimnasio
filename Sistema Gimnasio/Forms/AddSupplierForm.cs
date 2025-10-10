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
        private readonly Supplier editingSupplier = null;

        
        public AddSupplierForm() : this(null, false) { }
        public AddSupplierForm(Supplier supplierEdit, bool readOnly)
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;

            // Asignar los controladores de eventos KeyPress
            TName.KeyPress += TName_KeyPress;            
            TCuit.KeyPress += TCuit_KeyPress;
            TPhone.KeyPress += TPhone_KeyPress;

            if(supplierEdit != null)
            {
                editingSupplier = supplierEdit;
                LoadData(supplierEdit);
                BClean.Enabled = false; // Deshabilitar botón limpiar en modo edición
                this.Text = "Editar usuario"; // Cambia el título de la ventana
            }

            if(readOnly)
            {
                ActivateReadOnly();
                this.Text = "Ver usuario"; // Cambia el título de la ventana
            }
        }

        private void ActivateReadOnly()
        {
            SetReadOnly(this);

            // Ocultar acciones de edición
            BSave.Visible = false;
            BClean.Visible = false;
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
        private void LoadData(Supplier s)
        {
            TName.Text = s.Nombre;            
            TCuit.Text = s.Cuit.ToString();
            TPhone.Text = s.Telefono.ToString();
            TEmail.Text = s.Email;
            
        }

        // Evento Click del botón Guardar
        private void BSave_Click(object sender, EventArgs e)
        {
            var supplierService = new SupplierService();

            if (!ValidateInputs()) // Usando tu método de validación original
            {
                return;
            }

            try
            {
                if (editingSupplier == null)
                {
                    // Lógica para CREAR un nuevo proveedor
                    var newSupplier = new Supplier()
                    {
                        Nombre = TName.Text.Trim(),
                        Cuit = long.Parse(TCuit.Text.Trim()),
                        Telefono = long.Parse(TPhone.Text.Trim()),
                        Email = TEmail.Text.Trim()
                        // Puedes añadir un campo 'Estado = true' si tu modelo lo requiere
                    };

                    supplierService.SupplierCreate(newSupplier);
                    MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Lógica para EDITAR un proveedor existente
                    editingSupplier.Nombre = TName.Text.Trim();
                    editingSupplier.Cuit = long.Parse(TCuit.Text.Trim());
                    editingSupplier.Telefono = long.Parse(TPhone.Text.Trim());
                    editingSupplier.Email = TEmail.Text.Trim();
                    var sRepository = new SupplierRepository();
                    // --- Validaciones de duplicados antes de actualizar ---
                    

                    if (sRepository.ExistsCuit(editingSupplier.Cuit, editingSupplier.IdProveedor))
                    {
                        MessageBox.Show("El CUIT ya existe en el sistema.", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TCuit.Focus();
                        return;
                    }
                    if (sRepository.ExistsEmail(editingSupplier.Email, editingSupplier.IdProveedor))
                    {
                        MessageBox.Show("El email ya existe en el sistema.", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TEmail.Focus();
                        return;
                    }
                    if (sRepository.ExistsTelefono(editingSupplier.Telefono, editingSupplier.IdProveedor))
                    {
                        MessageBox.Show("El teléfono ya existe en el sistema.", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TPhone.Focus();
                        return;
                    }

                    // Llama al método para actualizar en tu servicio
                    supplierService.SupplierUpdate(editingSupplier);
                    MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Business.Exceptions.DuplicateFieldException ex)
            {
                // Maneja la excepción específica de tu capa de negocio
                MessageBox.Show($"Error: {ex.Message}", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Maneja cualquier otro error inesperado
                MessageBox.Show($"Ocurrió un error inesperado al guardar. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
