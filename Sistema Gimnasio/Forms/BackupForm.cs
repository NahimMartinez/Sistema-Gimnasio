using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Forms
{
    public partial class BackupForm : Form
    {

        public BackupForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;
        }

        private void BSave_Click(object sender, EventArgs e)
        {

        }

        private void BRoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            openFile.Title = "Seleccionar archivo";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtRoad.Text = openFile.FileName;
            }
        }
    }
}
