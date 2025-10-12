using Business;
using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    public partial class AddMemberForm : Form
    {
        private readonly Partner editingPartner = null;
        private readonly bool soloLectura = false;
        public AddMemberForm() : this(null, false) { }
        public AddMemberForm(Partner partnerEdit, bool readOnly)
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;

            // Asignar los controladores de eventos KeyPress
            TName.KeyPress += TName_KeyPress;
            TLastName.KeyPress += TLastName_KeyPress;
            TDni.KeyPress += TDni_KeyPress;
            TPhone.KeyPress += TPhone_KeyPress;

            if (partnerEdit != null)
            {
                editingPartner = partnerEdit;
                LoadData(partnerEdit);
                BClean.Enabled = false; // Deshabilitar botón limpiar en modo edición
                this.Text = "Editar Socio"; // Cambia el título de la ventana
            }

            if (readOnly)
            {
                ActivateReadOnly();
                this.Text = "Ver Socio"; // Cambia el título de la ventana
            }
        }

        private void LoadData(Partner p)
        {
            TName.Text = p.Nombre;
            TLastName.Text = p.Apellido;
            TDni.Text = p.Dni.ToString();
            TPhone.Text = p.Telefono;
            TEmail.Text = p.Email;
            TContactE.Text = p.ContactoEmergencia.ToString();
            TObservation.Text = p.Observaciones;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            var partnerService = new PartnerService();
            if (!ValidateInputs()) return;// Si la validación falla, no continua
            
            try
            {
                if (editingPartner == null)
                {
                    // CREATE
                    var newPerson = new Person()
                    {
                        Nombre = TName.Text.Trim(),
                        Apellido = TLastName.Text.Trim(),
                        Dni = TDni.Text.Trim(),
                        Telefono = TPhone.Text.Trim(),              
                        Email = TEmail.Text.Trim()                        
                    };

                    var newPartner = new Partner()
                    {                       
                        ContactoEmergencia = long.Parse(TContactE.Text.Trim()),
                        Observaciones = TObservation.Text.Trim()
                    };



                    /*// duplicados antes de crear
                    
                    if (partnerService.ExistsDni(newPartner.Dni, null))
                    { MessageBox.Show("El DNI ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); TDni.Focus(); return; }
                    if (partnerService.ExistsEmail(newPartner.Email, null))
                    { MessageBox.Show("El email ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); TEmail.Focus(); return; }
                    if (partnerService.ExistsTelefono(newPartner.Telefono, null))
                    { MessageBox.Show("El teléfono ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); TPhone.Focus(); return; }
                    */
                    partnerService.PartnerCreate(newPerson, newPartner);
                    MessageBox.Show("Socio agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // UPDATE
                    editingPartner.Nombre = TName.Text.Trim();
                    editingPartner.Apellido = TLastName.Text.Trim();
                    editingPartner.Dni = TDni.Text.Trim();
                    editingPartner.Telefono = TPhone.Text.Trim();   // si es long en tu modelo, usa long.Parse
                    editingPartner.Email = TEmail.Text.Trim();
                    editingPartner.ContactoEmergencia = long.Parse(TContactE.Text.Trim());
                    editingPartner.Observaciones = TObservation.Text.Trim();

                    
                    /*

                    if (partnerService.ExistsDni(editingPartner.Dni, editingPartner.IdPersona))
                    { MessageBox.Show("El DNI ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); TDni.Focus(); return; }
                    if (partnerService.ExistsEmail(editingPartner.Email, editingPartner.IdPersona))
                    { MessageBox.Show("El email ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); TEmail.Focus(); return; }
                    if (partnerService.ExistsTelefono(editingPartner.Telefono, editingPartner.IdPersona))
                    { MessageBox.Show("El teléfono ya existe.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); TPhone.Focus(); return; }
                    */
                    partnerService.UpdatePartner(editingPartner);
                     // Actualiza los datos en la tabla persona


                    MessageBox.Show("Socio actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Business.Exceptions.DuplicateFieldException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }           
             
            
        

        // Limpiar los campos del formulario
        private void BClean_Click(object sender, EventArgs e)
        {
            TName.Clear();
            TLastName.Clear();
            TDni.Clear();
            TPhone.Clear();
            TEmail.Clear();
            TContactE.Clear();
            TObservation.Clear();
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

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
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
                string.IsNullOrWhiteSpace(TDni.Text))
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

        private void ActivateReadOnly()
        {
            SetReadOnly(this);

            // Ocultar acciones de edición
            BSave.Visible = false;
            BClean.Visible = false;
        }
    }
}
