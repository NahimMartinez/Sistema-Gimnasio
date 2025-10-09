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
        // NOTA: Tu clase se llama 'ActivityService' pero en otros archivos era 'ActividadService'.
        // Asegúrate de que el nombre aquí sea el correcto.
        private readonly ActivityService _actividadService = new ActivityService();
        private readonly UserService _userService = new UserService();
        private readonly ClassService _classService = new ClassService();

        private List<CheckBox> checkBoxesDias = new List<CheckBox>();

        public AddClass()
        {
            InitializeComponent();
            checkBoxesDias.AddRange(new CheckBox[] { CBLunes, CBMartes, CBMiercoles, CBJueves, CBViernes, CBSabado, CBDomingo });
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            LoadActivities();
            LoadCoaches();
            SetDayTags();

            // Deja los ComboBox sin selección
            CBCategoria.SelectedIndex = -1;
            CBCoachs.SelectedIndex = -1;
        }

        // --- MÉTODO PARA EL BOTÓN LIMPIAR (CORREGIDO Y COMPLETO) ---
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            // Resetea los ComboBox
            if (CBCategoria.Items.Count > 0) CBCategoria.SelectedIndex = 0;
            if (CBCoachs.Items.Count > 0) CBCoachs.SelectedIndex = 0;

            // Limpia los campos de texto
            txtCupo.Clear();
            txtPrecio.Clear();

            // Resetea las horas a la hora actual
            DTDesde.Value = DateTime.Now;
            DTHasta.Value = DateTime.Now;

            // Desmarca todos los checkboxes
            foreach (var chk in checkBoxesDias)
            {
                chk.Checked = false;
            }
        }

        private void LoadActivities()
        {
            try
            {
                // Carga las categorías/actividades desde la DB
                CBCategoria.DataSource = _actividadService.GetAllActividades();
                CBCategoria.DisplayMember = "Nombre";
                CBCategoria.ValueMember = "IdActividad";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCoaches()
        {
            try
            {
                // Carga los coaches desde la DB
                CBCoachs.DataSource = _userService.GetAllCoaches();
                CBCoachs.DisplayMember = "NombreCompleto";
                CBCoachs.ValueMember = "IdUsuario";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección
                if (CBCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una actividad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CBCoachs.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un coach.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newClass = new Class
                {
                    ActividadId = (int)CBCategoria.SelectedValue,
                    UsuarioId = (int)CBCoachs.SelectedValue,
                    HoraDesde = DTDesde.Value.TimeOfDay,
                    HoraHasta = DTHasta.Value.TimeOfDay,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Cupo = int.Parse(txtCupo.Text),
                    Estado = true 
                };

                foreach (var chk in checkBoxesDias)
                {
                    if (chk.Checked)
                    {
                        newClass.Dias.Add(new Entities.Day { IdDia = Convert.ToInt32(chk.Tag) });
                    }
                }

                _classService.CreateClass(newClass);

                MessageBox.Show("¡Clase creada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor del cupo o del precio no es un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para asignar los IDs (1, 2, 3...) a cada CheckBox
        private void SetDayTags()
        {
            CBLunes.Tag = 1;
            CBMartes.Tag = 2;
            CBMiercoles.Tag = 3;
            CBJueves.Tag = 4;
            CBViernes.Tag = 5;
            CBSabado.Tag = 6;
            CBDomingo.Tag = 7;
        }

        // Si tienes un botón "Cancelar", este sería su evento
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}