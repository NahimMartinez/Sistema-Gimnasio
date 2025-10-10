using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Forms
{
    public partial class AddClass : Form
    {
        private readonly ActivityService _actividadService = new ActivityService();
        private readonly UserService _userService = new UserService();
        private readonly ClassService _classService = new ClassService();
        private List<CheckBox> checkBoxesDias = new List<CheckBox>();

        private int? _classIdToEdit;

        public AddClass()
        {
            InitializeComponent();
            InitializeForm();
        }

        public AddClass(int classIdToEdit)
        {
            InitializeComponent();
            InitializeForm();
            _classIdToEdit = classIdToEdit;
        }

        private void InitializeForm()
        {
            checkBoxesDias.AddRange(new CheckBox[] { CBLunes, CBMartes, CBMiercoles, CBJueves, CBViernes, CBSabado, CBDomingo });
            this.txtCupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCupo_KeyPress);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            SetDayTags();

            if (_classIdToEdit.HasValue)
            {
                this.Text = "Editar Clase";
                LoadDataForEditing(); // Llamamos al metodo para editar
            }
            else
            {
                this.Text = "Nueva Clase";
                // En modo creación, solo cargamos las listas y dejamos sin selección
                LoadActivities();
                LoadCoaches();
                CBCategoria.SelectedIndex = -1;
                CBCoachs.SelectedIndex = -1;
            }
        }

        private void LoadDataForEditing()
        {
            try
            {
                // 1. OBTENEMOS los datos de la clase que vamos a editar
                var clase = _classService.GetClassById(_classIdToEdit.Value);
                if (clase == null)
                {
                    MessageBox.Show("Error: No se encontró la clase para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // 2. CARGAMOS las listas de opciones en los ComboBox
                LoadActivities();
                LoadCoaches();

                CBCategoria.SelectedValue = clase.ActividadId;
                CBCoachs.SelectedValue = clase.UsuarioId;
                txtPrecio.Text = clase.Precio.ToString("0.00");
                txtCupo.Text = clase.Cupo.ToString();
                DTDesde.Value = DateTime.Today + clase.HoraDesde;
                DTHasta.Value = DateTime.Today + clase.HoraHasta;

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

                if (_classIdToEdit.HasValue)
                {
                    clase.IdClase = _classIdToEdit.Value;
                    _classService.UpdateClass(clase);
                    MessageBox.Show("¡Clase actualizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _classService.CreateClass(clase);
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

        private void txtCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',')) { e.Handled = true; }
            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1)) { e.Handled = true; }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            if (_classIdToEdit.HasValue)
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
        private void LoadActivities()
        {
            try
            {
                CBCategoria.DataSource = _actividadService.GetAllActividades();
                CBCategoria.DisplayMember = "Nombre";
                CBCategoria.ValueMember = "IdActividad";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void LoadCoaches()
        {
            try
            {
                CBCoachs.DataSource = _userService.GetAllCoaches();
                CBCoachs.DisplayMember = "NombreCompleto";
                CBCoachs.ValueMember = "IdUsuario";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void SetDayTags()
        {
            CBLunes.Tag = 1; CBMartes.Tag = 2; CBMiercoles.Tag = 3; CBJueves.Tag = 4;
            CBViernes.Tag = 5; CBSabado.Tag = 6; CBDomingo.Tag = 7;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}