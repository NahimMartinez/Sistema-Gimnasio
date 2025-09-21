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
    public partial class AddClassCategory : Form
    {
        public AddClassCategory()
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;
        }

        // Cerrar el formulario sin guardar
        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Guardar la nueva categoría
        private void BSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewClassCategory.Text))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Categoría guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
