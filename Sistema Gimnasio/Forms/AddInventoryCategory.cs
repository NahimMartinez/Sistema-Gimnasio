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
    public partial class AddInventoryCategory : Form
    {
        public AddInventoryCategory()
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;
        }

        // Botón Guardar
        private void BSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClassCategory.Text))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Categoría guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // Botón Cancelar
        private void BCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}