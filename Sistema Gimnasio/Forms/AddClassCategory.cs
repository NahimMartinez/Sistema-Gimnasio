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
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BSave.Text))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Categoría guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
