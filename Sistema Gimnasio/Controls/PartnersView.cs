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
    public partial class PartnersView : UserControl
    {
        public PartnersView()
        {
            InitializeComponent();
        }

       

        private void BNewMember_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewMember = new AddMemberForm())
           {
                //muestro el formulario como un cuadro de dialogo
                if (fNewMember.ShowDialog() == DialogResult.OK)
               {
                    
                }
            }
        }

        private void LMembership_Click(object sender, EventArgs e)
        {

        }
    }
}
