using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_Gimnasio
{
    public partial class LoginView : Form
    {
        private readonly AuthService auth = new AuthService();
        public User UsuarioAutenticado { get; private set; }

        public Form1.Roles UserRole { get; private set; } = Form1.Roles.None;
        //public string Username { get; private set; }
        public LoginView()
        {
            InitializeComponent();
        }

        

        private void BLogin_Click(object sender, EventArgs e)
        {
            var username = TUser.Text.Trim();
            var password = TPass.Text;
            var u = auth.Login(username, password);
            if (u == null)
            {
                MessageBox.Show("Usuario/Contraseña invalida");
                return;
            }
            UsuarioAutenticado = u;
            DialogResult = DialogResult.OK;
            Close();
            /*
            // usuarios y roles hardcodeados para demo
            if (Username == "admin" && password == "123")
                UserRole = Form1.Roles.Admin;
            else if (Username == "recep" && password == "123")
                UserRole = Form1.Roles.Recep;
            else if (Username == "coach" && password == "123")
                UserRole = Form1.Roles.Coach;
            else
            {
                MessageBox.Show("Usuario/Contraseña invalida");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
            */
        }

        private void BCleanup_Click(object sender, EventArgs e)
        {

        }
    }

}

