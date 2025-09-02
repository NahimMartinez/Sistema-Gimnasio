using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    public partial class usersManagment : UserControl
    {
        public usersManagment()
        {
            InitializeComponent();
        }

        private void BNewUser_Click_1(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewUser = new AddUsersForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewUser.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
