using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void Sidebar_MenuItemClicked(object sender, string menuId)
        {
            switch (menuId)
            {
                case "dashboard":
                    //ShowDashboard();
                    break;

                case "usuarios":
                    ShowUsers();
                    break;

                case "socios":
                    ShowPartners();
                    break;

                case "clases":
                    //ShowClases();
                    break;

                case "inventario":
                    ShowInventario();
                    break;

                case "proveedores":
                    ShowSuppliers();
                    break;

                case "membresias":
                    //ShowMembresias();
                    break;

                case "reportes":
                    //ShowReportes();
                    break;
            }
        }

        //UserControl crear users
        private void ShowUsers()
        {
            contentPanel.Controls.Clear();
            usersManagment usersmanagnent = new usersManagment();
            usersmanagnent.Dock = DockStyle.Fill;
            usersmanagnent.BackColor = Color.White;
            contentPanel.Controls.Add(usersmanagnent);
            this.Text = "Sistema Gimnasio - Usuarios";
        }

        private void ShowInventario()
        {
            contentPanel.Controls.Clear();
            inventario vinventario = new inventario();
            vinventario.Dock = DockStyle.Fill;
            vinventario.BackColor = Color.White;
            contentPanel.Controls.Add(vinventario);
            this.Text = "Sistema Gimnasio - Inventario";
        }

        private void ShowPartners()
        {
            contentPanel.Controls.Clear();
            PartnersView partnersView = new PartnersView();
            partnersView.Dock = DockStyle.Fill;
            partnersView.BackColor = Color.White;
            contentPanel.Controls.Add(partnersView);
            this.Text = "Sistema Gimnasio - Socios";
        }

        private void ShowSuppliers()
        {
            contentPanel.Controls.Clear();
            SupplierView supplierView = new SupplierView();
            supplierView.Dock = DockStyle.Fill;
            supplierView.BackColor = Color.White;
            contentPanel.Controls.Add(supplierView);
            this.Text = "Sistema Gimnasio - Proveedores";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sidebar1.MenuItemClicked += Sidebar_MenuItemClicked;
        }
    }
}
