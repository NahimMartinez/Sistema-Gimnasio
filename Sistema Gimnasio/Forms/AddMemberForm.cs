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
        // Si edito, guardo acá el socio que vino de afuera. Si es null, estoy creando.
        private readonly Partner editingPartner = null;
        // Servicios para hablar con la capa de negocio/datos.
        private readonly PartnerService partnerService = new PartnerService();
        private readonly PersonService personService = new PersonService();

        // Propiedades públicas para que el formulario que lo llama pueda recoger los datos.
        public Person NewPerson { get; private set; }
        public Partner NewPartner { get; private set; }

        // Ctor por defecto: crear socio (no lectura, no edición).
        public AddMemberForm() : this(null, false) { }

        // Ctor general: si partnerEdit != null estoy editando; si readOnly = true solo muestro.
        public AddMemberForm(Partner partnerEdit, bool readOnly)
        {
            InitializeComponent();//Inicializa los componentes visuales del formulario.
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            // Restringo inputs por tecla.
            TName.KeyPress += TName_KeyPress;         // Solo letras y espacio.
            TLastName.KeyPress += TLastName_KeyPress; // Solo letras y espacio.
            TDni.KeyPress += TDni_KeyPress;           // Solo números.
            TPhone.KeyPress += TPhone_KeyPress;       // Solo números.

            // Validaciones cuando salgo del control.
            this.TDni.Leave += new EventHandler(this.TDni_Leave);     // DNI duplicado.
            this.TEmail.Leave += new EventHandler(this.TEmail_Leave); // Email duplicado.
            this.TPhone.Leave += new EventHandler(this.TPhone_Leave); // Tel duplicado.

            // Si me pasaron un socio, cargo datos y seteo estado de edición.
            if (partnerEdit != null)
            {
                editingPartner = partnerEdit; // Guardo referencia del que edito.
                LoadData(partnerEdit);        // Lleno los textbox con sus datos.
                BClean.Enabled = false;       // En edición no limpio todo.
                this.Text = "Editar Socio";   // Cambio el título.
            }

            // Si es solo lectura, deshabilito inputs y oculto acciones.
            if (readOnly)
            {
                ActivateReadOnly();
                this.Text = "Ver Socio";
            }
        }

        // Cargo los campos del formulario con el socio que recibí.
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
        // Click en Guardar: o creo nuevos objetos o actualizo el existente.
        private void BSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;// Valido mínimos antes de seguir.

            try
            {
                if (editingPartner == null) // MODO CREAR
                {
                   
                    //Creamos los objetos con los datos del formulario.
                    NewPerson = new Person()
                    {
                        Nombre = TName.Text.Trim(),
                        Apellido = TLastName.Text.Trim(),
                        Dni = TDni.Text.Trim(),
                        Telefono = TPhone.Text.Trim(),
                        Email = TEmail.Text.Trim()
                    };
                    // Armo el socio con lo faltante.
                    NewPartner = new Partner()
                    {
                        ContactoEmergencia = long.Parse(TContactE.Text.Trim()),
                        Observaciones = TObservation.Text.Trim()
                    };

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else // MODO ACTUALIZAR
                {
                    // Copio cambios a la instancia existente.
                    editingPartner.Nombre = TName.Text.Trim();
                    editingPartner.Apellido = TLastName.Text.Trim();
                    editingPartner.Dni = TDni.Text.Trim();
                    editingPartner.Telefono = TPhone.Text.Trim();
                    editingPartner.Email = TEmail.Text.Trim();
                    editingPartner.ContactoEmergencia = long.Parse(TContactE.Text.Trim());
                    editingPartner.Observaciones = TObservation.Text.Trim();

                    // Pido a la capa de negocio que actualice en BD.
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
        // Al salir del DNI verifico duplicado.
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

        // Al salir del Email verifico duplicado.
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
        // Al salir del Teléfono verifico duplicado.
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


        // Botón Limpiar: borro todos los campos.
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
        // Valido formato de email con System.Net.Mail.
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
        // Solo letras y espacio en Nombre.
        private void TName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        // Solo letras y espacio en Apellido.
        private void TLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        // Solo dígitos en DNI.
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Solo dígitos en Teléfono.
        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Validación mínima de requeridos y formato de email.
        private bool ValidateInputs()
        {
            // Requeridos: Nombre, Apellido, DNI.
            if (string.IsNullOrWhiteSpace(TName.Text) ||
                string.IsNullOrWhiteSpace(TLastName.Text) ||
                string.IsNullOrWhiteSpace(TDni.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Si hay email, que tenga formato válido.
            if (!string.IsNullOrWhiteSpace(TEmail.Text) && !ValidEmail(TEmail.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // Recorro recursivo el árbol de controles y pongo readonly/disabled según tipo.
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

        // Modo solo lectura: bloqueo inputs y oculto botones de acción.
        private void ActivateReadOnly()
        {
            SetReadOnly(this);
            BSave.Visible = false;
            BClean.Visible = false;
        }
    }
}