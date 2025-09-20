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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
            ConfigureValidations();
        }


        private void ConfigureValidations()
        {
            // Validar solo números 
            txtCantidad.KeyPress += TxtSoloNumeros_KeyPress;
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor ingrese una Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
                return false;
            }

            if (DTFechaIngreso.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de ingreso no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTFechaIngreso.Focus();
                return false;
            }

            if (CBCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBCategoria.Focus();
                return false;
            }

            return true; // Todos los campos son válidos
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
            txtNombre.Clear();
            txtCantidad.Clear();
            CBCategoria.SelectedIndex = -1;
            DTFechaIngreso.Value = DateTime.Now;
        }

       
    }
}
