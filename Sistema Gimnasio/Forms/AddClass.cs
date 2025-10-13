using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Sistema_Gimnasio.Form1;

namespace Sistema_Gimnasio.Forms
{
    public partial class AddClass : Form
    {
        private readonly ActivityService actividadService = new ActivityService();
        private readonly UserService userService = new UserService();
        private readonly ClassService classService = new ClassService();
        private List<CheckBox> checkBoxesDias = new List<CheckBox>();
        public Roles CurrentRole { get; set; } = Roles.None;

        // Almacena el ID de la clase si estamos en modo Editar o Ver. Es nulo si es modo Crear.
        private int? classIdFlag;
        // Bandera para determinar si el formulario es de solo lectura.
        private bool isViewOnlyFlag = false;

        // Constructor para el modo CREAR una nueva clase.
        public AddClass()
        {
            InitializeComponent();
            InitializeForm();
        }

        // Constructor para los modos EDITAR o VER una clase existente.
        public AddClass(int classId, bool isViewOnly = false)
        {
            InitializeComponent();
            InitializeForm();
            classIdFlag = classId;
            isViewOnlyFlag = isViewOnly;
        }

        // Realiza la inicialización común para ambos constructores.
        private void InitializeForm()
        {
            checkBoxesDias.AddRange(new CheckBox[] { CBLunes, CBMartes, CBMiercoles, CBJueves, CBViernes, CBSabado, CBDomingo });
            this.txtCupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCupo_KeyPress);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
        }

        // Se ejecuta cuando el formulario se carga. Decide qué modo de operación usar.
        private void AddClass_Load(object sender, EventArgs e)
        {
            SetDayTags();

            // Si se proporcionó un ID de clase, entramos en modo Editar o Ver.
            if (classIdFlag.HasValue)
            {
                // Si además la bandera de solo-vista está activa.
                if (isViewOnlyFlag)
                {
                    this.Text = "Ver Clase";
                    SetViewOnlyMode(); // Bloquea los controles.
                }
                else
                {
                    this.Text = "Editar Clase";
                }
                LoadDataForEditing(); // Carga los datos existentes de la clase.
            }
            // Si no se proporcionó un ID, entramos en modo Crear.
            else
            {
                this.Text = "Nueva Clase";
                LoadActivities();
                LoadCoaches();
                CBCategoria.SelectedIndex = -1;
                CBCoachs.SelectedIndex = -1;
            }
            
            if(CurrentRole != Roles.Admin){
                NewCategoryClass.Visible = false;
            }

        }

        // Configura el formulario para que sea de solo lectura.
        private void SetViewOnlyMode()
        {
            // Deshabilita todos los controles de entrada de datos.
            CBCategoria.Enabled = false;
            CBCoachs.Enabled = false;
            txtPrecio.ReadOnly = true;
            txtCupo.ReadOnly = true;
            DTDesde.Enabled = false;
            DTHasta.Enabled = false;
            foreach (var chk in checkBoxesDias)
            {
                chk.Enabled = false;
            }

            // Oculta los botones de acción y ajusta el botón de cancelar.
            BSave.Visible = false;
            BLimpiar.Visible = false;
        }

        // Carga los datos de una clase existente en los controles del formulario.
        private void LoadDataForEditing()
        {
            try
            {
                var clase = classService.GetClassById(classIdFlag.Value);
                if (clase == null)
                {
                    MessageBox.Show("Error: No se encontró la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Carga las listas de opciones ANTES de asignar los valores.
                LoadActivities();
                LoadCoaches();

                // Asigna los valores de la clase a cada control.
                CBCategoria.SelectedValue = clase.ActividadId;
                CBCoachs.SelectedValue = clase.UsuarioId;
                txtPrecio.Text = clase.Precio.ToString("0.00");
                txtCupo.Text = clase.Cupo.ToString();
                DTDesde.Value = DateTime.Today + clase.HoraDesde;
                DTHasta.Value = DateTime.Today + clase.HoraHasta;

                // Marca los checkboxes de los días correspondientes.
                foreach (var dia in clase.Dias)
                {
                    var chk = checkBoxesDias.FirstOrDefault(c => Convert.ToInt32(c.Tag) == dia.IdDia);
                    if (chk != null)
                    {
                        chk.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Se ejecuta al hacer clic en el botón Guardar.
        private void BSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                var clase = new Class
                {
                    ActividadId = (int)CBCategoria.SelectedValue,
                    UsuarioId = (int)CBCoachs.SelectedValue,
                    HoraDesde = DTDesde.Value.TimeOfDay,
                    HoraHasta = DTHasta.Value.TimeOfDay,
                    Precio = decimal.Parse(txtPrecio.Text.Replace(',', '.')),
                    Cupo = int.Parse(txtCupo.Text),
                    Estado = true
                };

                foreach (var chk in checkBoxesDias)
                {
                    if (chk.Checked)
                    {
                        clase.Dias.Add(new Entities.Day { IdDia = Convert.ToInt32(chk.Tag) });
                    }
                }

                // Decide si debe actualizar una clase existente o crear una nueva.
                if (classIdFlag.HasValue)
                {
                    clase.IdClase = classIdFlag.Value;
                    classService.UpdateClass(clase);
                    MessageBox.Show("¡Clase actualizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    classService.CreateClass(clase);
                    MessageBox.Show("¡Clase creada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor del cupo o del precio tiene un formato incorrecto.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Valida que todos los campos del formulario estén correctos antes de guardar.
        private bool ValidateInputs()
        {
            if (CBCategoria.SelectedIndex == -1) { MessageBox.Show("Debe seleccionar una actividad.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (CBCoachs.SelectedIndex == -1) { MessageBox.Show("Debe seleccionar un coach.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (string.IsNullOrWhiteSpace(txtPrecio.Text)) { MessageBox.Show("Debe ingresar un precio.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (string.IsNullOrWhiteSpace(txtCupo.Text)) { MessageBox.Show("Debe ingresar un cupo.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (DTDesde.Value >= DTHasta.Value) { MessageBox.Show("La hora de inicio debe ser anterior a la hora de fin.", "Error de Horario", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!checkBoxesDias.Any(chk => chk.Checked)) { MessageBox.Show("Debe seleccionar al menos un día para la clase.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        // Impide que se ingresen caracteres que no sean números en el campo de Cupo.
        private void txtCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        // Impide que se ingresen caracteres que no sean números o un separador decimal en el campo de Precio.
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',')) { e.Handled = true; }
            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1)) { e.Handled = true; }
        }

        // Limpia o resetea los campos del formulario.
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            if (classIdFlag.HasValue)
            {
                LoadDataForEditing();
            }
            else
            {
                if (CBCategoria.Items.Count > 0) CBCategoria.SelectedIndex = -1;
                if (CBCoachs.Items.Count > 0) CBCoachs.SelectedIndex = -1;
                txtCupo.Clear();
                txtPrecio.Clear();
                DTDesde.Value = DateTime.Now;
                DTHasta.Value = DateTime.Now;
                foreach (var chk in checkBoxesDias) { chk.Checked = false; }
            }
        }

        // Carga la lista de actividades desde la base de datos y la asigna al ComboBox.
        private void LoadActivities()
        {
            try
            {
                CBCategoria.DataSource = actividadService.GetActivities();
                CBCategoria.DisplayMember = "Nombre";
                CBCategoria.ValueMember = "IdActividad";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Carga la lista de coaches desde la base de datos y la asigna al ComboBox.
        private void LoadCoaches()
        {
            try
            {
                CBCoachs.DataSource = userService.GetAllCoaches();
                CBCoachs.DisplayMember = "NombreCompleto";
                CBCoachs.ValueMember = "IdUsuario";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // Asigna los IDs numéricos (1 para Lunes, 2 para Martes, etc.) a la propiedad Tag de cada CheckBox.
        private void SetDayTags()
        {
            CBLunes.Tag = 1; CBMartes.Tag = 2; CBMiercoles.Tag = 3; CBJueves.Tag = 4;
            CBViernes.Tag = 5; CBSabado.Tag = 6; CBDomingo.Tag = 7;
        }

        // Cierra el formulario.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewCategoryClass_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewItem = new AddClassCategory())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {
                    LoadActivities();
                }
            }
        }
    }
}