using Business;
using Entities;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    public partial class AddMemberForm : Form
    {
        private readonly Partner editingPartner = null;
        private readonly PartnerService partnerService = new PartnerService();
        private readonly PersonService personService = new PersonService();

        // Propiedades públicas para que el formulario que lo llama pueda recoger los datos.
        public Person NewPerson { get; private set; }
        public Partner NewPartner { get; private set; }

        public AddMemberForm() : this(null, false) { }
        public AddMemberForm(Partner partnerEdit, bool readOnly)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            TName.KeyPress += TName_KeyPress;
            TLastName.KeyPress += TLastName_KeyPress;
            TDni.KeyPress += TDni_KeyPress;
            TPhone.KeyPress += TPhone_KeyPress;
            this.TDni.Leave += new EventHandler(this.TDni_Leave);
            this.TEmail.Leave += new EventHandler(this.TEmail_Leave);
            this.TPhone.Leave += new EventHandler(this.TPhone_Leave);

            if (partnerEdit != null)
            {
                editingPartner = partnerEdit;
                LoadData(partnerEdit);
                BClean.Enabled = false;
                this.Text = "Editar Socio";
            }

            if (readOnly)
            {
                ActivateReadOnly();
                this.Text = "Ver Socio";
            }
        }

        private void LoadData(Partner p)
        {
            TName.Text = p.Nombre;
            TLastName.Text = p.Apellido;
            TDni.Text = p.Dni;
            TPhone.Text = p.Telefono;
            TEmail.Text = p.Email;
            TContactE.Text = p.ContactoEmergencia.ToString();
            TObservation.Text = p.Observaciones;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                if (editingPartner == null) // MODO CREAR
                {
                   
                    // 1. Creamos los objetos con los datos del formulario.
                    NewPerson = new Person()
                    {
                        Nombre = TName.Text.Trim(),
                        Apellido = TLastName.Text.Trim(),
                        Dni = TDni.Text.Trim(),
                        Telefono = TPhone.Text.Trim(),
                        Email = TEmail.Text.Trim()
                    };

                    NewPartner = new Partner()
                    {
                        ContactoEmergencia = long.Parse(TContactE.Text.Trim()),
                        Observaciones = TObservation.Text.Trim()
                    };

                    // 2. NO se llama al MembershipForm desde aquí.
                    //    Simplemente, se indica que la operación fue exitosa y se cierra.
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else // MODO ACTUALIZAR
                {
                    editingPartner.Nombre = TName.Text.Trim();
                    editingPartner.Apellido = TLastName.Text.Trim();
                    editingPartner.Dni = TDni.Text.Trim();
                    editingPartner.Telefono = TPhone.Text.Trim();
                    editingPartner.Email = TEmail.Text.Trim();
                    editingPartner.ContactoEmergencia = long.Parse(TContactE.Text.Trim());
                    editingPartner.Observaciones = TObservation.Text.Trim();

                    partnerService.UpdatePartner(editingPartner);
                    MessageBox.Show("Socio actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TDni_Leave(object sender, EventArgs e)
        {
            try
            {
                string dni = TDni.Text.Trim();
                if (personService.ExistsDni(dni))
                {
                    MessageBox.Show("El DNI ya está registrado.", "Duplicado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TDni.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar DNI: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                string email = TEmail.Text.Trim();
                if (personService.ExistsEmail(email))
                {
                    MessageBox.Show("El correo electrónico ya está registrado.", "Duplicado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar correo electrónico: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TPhone_Leave(object sender, EventArgs e)
        {
            try
            {
                string phone = TPhone.Text.Trim();
                if (personService.ExistsPhone(phone))
                {
                    MessageBox.Show("El teléfono ya está registrado.", "Duplicado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TPhone.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar teléfono: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



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
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void TName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(TName.Text) ||
                string.IsNullOrWhiteSpace(TLastName.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            BSave.Visible = false;
            BClean.Visible = false;
        }
    }
}