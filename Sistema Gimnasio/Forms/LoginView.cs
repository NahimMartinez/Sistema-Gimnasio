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
    public partial class LoginView : Form
    {

        
        public Form1.Roles UserRole { get; private set; } = Form1.Roles.None;

        public LoginView()
        {
            InitializeComponent();
        }

        

        private void BLogin_Click(object sender, EventArgs e)
        {
            var Username = TUser.Text.Trim();
            var password = TPass.Text;

            // usuarios y roles hardcodeados para demo
            if (Username == "admin" && password == "123")
                UserRole = Form1.Roles.Admin;
            else if (Username == "recep" && password == "123")
                UserRole = Form1.Roles.Recep;
            else if (Username == "coach" && password == "123")
                UserRole = Form1.Roles.Coach;
            else
            {
                MessageBox.Show("Invalid credentials");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BCleanup_Click(object sender, EventArgs e)
        {

        }
    }

}

