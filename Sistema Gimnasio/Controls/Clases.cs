using Sistema_Gimnasio.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio.Controls
{
    public partial class Clases : UserControl
    {
        public Clases()
        {
            InitializeComponent();
            LoadFakeData();
        }

        private void BNewClass_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewClass = new AddClass())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewClass.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void LoadFakeData()
        {

            //nombre, coach, cupo, dia, horario, estado
            BoardClass.Rows.Add("Crossfit", "Juan Perez", "20", "Lunes, Miercoles, Viernes", "6:00 - 7:00", "Activo");
            BoardClass.Rows.Add("Yoga", "Maria Lopez", "15", "Martes, Jueves", "7:00 - 8:00", "Activo");
            BoardClass.Rows.Add("Pilates", "Carlos Gomez", "10", "Lunes, Miercoles", "8:00 - 9:00", "Inactivo");
            BoardClass.Rows.Add("Zumba", "Ana Martinez", "25", "Viernes", "18:00 - 19:00", "Activo");
            BoardClass.Rows.Add("Spinning", "Luis Rodriguez", "30", "Martes, Jueves", "19:00 - 20:00", "Activo");
        }
    }
}
