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

        //Elementos sidebar, topbar, content
        private Panel sidebar = new Panel();

        public Form1()
        {
            InitializeComponent();
            BuildSideBar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BuildSideBar()
        {
            // Configure sidebar
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 150;
            sidebar.BackColor = Color.FromArgb(41, 39, 40);
            this.Controls.Add(sidebar);

            var items = new (string id, string text)[]
            {
                ("dashboard", "Dashboard"),
                ("usuarios", "Usuarios"),
                ("socios", "Socios"),
                ("clases", "Clases"),
                ("proveedores", "Proveedores"),
                ("membresias", "Membresias"),
                ("reportes", "Reportes"),
            };

            // Crear botones sidebar
            foreach (var item in items)
            {
                var btn = new Button
                {
                    Text = item.text,
                    Name = item.id,
                    Dock = DockStyle.Top,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(41, 39, 40),
                    FlatAppearance = { BorderSize = 0 },
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(20, 0, 0, 0)
                };

                //Agregar los botones al sidebar principal
                sidebar.Controls.Add(btn);
            }

            // Agregar un panel que ocupe el espacio restante
            var fillerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(41, 39, 40)
            };
            sidebar.Controls.Add(fillerPanel);
        }
    }
}
