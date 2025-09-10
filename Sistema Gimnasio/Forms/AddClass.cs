using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Forms
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
            ConfigureValidations();
        }

        private void ConfigureValidations()
        {
            // Validar solo números 
            txtCupo.KeyPress += TxtSoloNumeros_KeyPress;
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, backspace y borrar
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        private bool ValidarCampos()
        {

            if (CBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBCategoria.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCupo.Text))
            {
                MessageBox.Show("Por favor ingrese el Cupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCupo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHora.Text))
            {
                MessageBox.Show("Por favor ingrese el Horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHora.Focus();
                return false;
            }

            // Nueva validación: al menos un día seleccionado
            if (!CBLunes.Checked && !CBMartes.Checked && !CBMiercoles.Checked &&
                !CBJueves.Checked && !CBViernes.Checked && !CBSabado.Checked)
            {
                MessageBox.Show("Por favor seleccione al menos un día de clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBLunes.Focus(); 
                return false;
            }

            return true; // Todos los campos son válidos
        }

        private void LDiasClases_Click(object sender, EventArgs e)
        {

        }

        private void BCrear_Click(object sender, EventArgs e)
        {
            // Validar antes de guardar
            if (!ValidarCampos())
            {
                return; // Detener si hay errores
            }

            MessageBox.Show("Datos validados correctamente. Guardando...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            txtCupo.Clear();
            CBCategoria.SelectedIndex = -1;
            txtHora.Clear();
            CBLunes.Checked = false;
            CBMartes.Checked = false;
            CBMiercoles.Checked = false;
            CBJueves.Checked = false;
            CBViernes.Checked = false;
            CBSabado.Checked = false;
        }

        private void AddClass_Load(object sender, EventArgs e)
        {

        }
    }
}
