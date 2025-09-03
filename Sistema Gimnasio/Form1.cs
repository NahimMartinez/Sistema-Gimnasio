using Sistema_Gimnasio.Controls;
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
            WireSidebar();
            Navigate("dashboard"); // pantalla inicial

        }


        //Instanciamos un array de botones para manejar el sidebar
        private Button[] MenuButtons => new[]
        {
            BDashboard, BtnUsers, BtnPartners, BMemberships,
            BSupplier, BActivity, BInventory, BReports
        };

        private void WireSidebar()
        {

            // Tags que usa Navigate()
            BDashboard.Tag = "dashboard";
            BtnUsers.Tag = "users";
            BtnPartners.Tag = "partners";
            BMemberships.Tag = "memberships";
            BSupplier.Tag = "supplier";
            BActivity.Tag = "classes";
            BInventory.Tag = "inventory";
            BReports.Tag = "reports";

            foreach (var b in MenuButtons) b.Click += MenuButton_Click;
                       
        }

        //Evento click de los botones del sidebar
        private void MenuButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Navigate((string)btn.Tag);
            SetActive(btn);
        }

        private void Navigate(string menuId)
        {
            switch (menuId)
            {
                case "dashboard":
                    ShowDashboard();
                    break;

                case "users":
                    ShowUsers();
                    break;

                case "partners":
                    ShowPartners();
                    break;

                case "classes":
                    ShowClases();
                    break;

                case "inventory":
                    ShowInventario();
                    break;

                case "memberships":
                    ShowMemberships();
                    break;

                case "supplier":
                    ShowSuppliers();
                    break;

                case "reports":
                    ShowReports();
                    break;
                
            }
        }

        //Estilo para activo/inactivo de los botones del sidebar
        private void SetActive(Button active)
        {
            var orange = Color.FromArgb(249, 115, 22);
            var dark = Color.FromArgb(15, 23, 42);

            foreach (var b in MenuButtons)
            {
                b.BackColor = dark;
                b.Font = new Font(b.Font, FontStyle.Regular);
            }
            active.BackColor = orange;
            active.Font = new Font(active.Font, FontStyle.Bold);
        }

        //Vistas 
        private void ShowDashboard()
        {
            contentPanel.Controls.Clear();       
            this.Text = "GymManager Pro - Dashboard";
        }

        private void ShowUsers()
        {
            contentPanel.Controls.Clear();
            var view = new usersManagment
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Usuarios";
        }

        private void ShowPartners()
        {
            contentPanel.Controls.Clear();
            var view = new PartnersView
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Socios";
        }

        private void ShowClases()
        {
            contentPanel.Controls.Clear();
            var view = new Clases
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Clases";
        }

        private void ShowInventario()
        {
            contentPanel.Controls.Clear();
            var view = new inventario
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Inventario";
        }

        private void ShowMemberships()
        {
            contentPanel.Controls.Clear();            
            this.Text = "GymManager Pro - Membresías";
        }

       
        private void ShowReports()
        {
            contentPanel.Controls.Clear();            
            this.Text = "GymManager Pro - Reportes";
        }

        private void ShowSuppliers()
        {
            contentPanel.Controls.Clear();
            var view = new SupplierView
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Proveedores";


        }

    }
}
