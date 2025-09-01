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
    public partial class Sidebar : UserControl
    {

        //Evento que se dispara cuando se hace click en un botón del sidebar
        public event EventHandler<string> MenuItemClicked;

        public Sidebar()
        {
            InitializeComponent();
            BuildSideBar();
        }

        
        private void BuildSideBar()
        {
            BackColor = Color.FromArgb(41, 39, 40);
            Dock = DockStyle.Left;
            Width = 150;

            var items = new (string id, string text)[]
            {
                ("dashboard", "Dashboard"),
                ("usuarios",  "Usuarios"),
                ("socios",    "Socios"),
                ("clases",    "Clases"),
                ("inventario","Inventario"),
                ("proveedores","Proveedores"),
                ("membresias","Membresías"),
                ("reportes",  "Reportes"),
            };

            // Panel relleno primero para que Top apile encima
            Controls.Add(new Panel { Dock = DockStyle.Fill, BackColor = BackColor });

            // Agrego en orden inverso para que queden de arriba hacia abajo
            foreach (var item in items.Reverse())
            {
                var btn = new Button
                {
                    Text = item.text,
                    Name = item.id,
                    Dock = DockStyle.Top,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    BackColor = BackColor,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(20, 0, 0, 0)
                };
                btn.FlatAppearance.BorderSize = 0;

                // Evento click
                btn.Click += (s, e) =>
                {
                    // Disparar el evento con el ID del menú
                    MenuItemClicked?.Invoke(this, item.id);
                };

                Controls.Add(btn);
            }

        }

        private void Sidebar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
