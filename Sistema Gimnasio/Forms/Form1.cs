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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_Gimnasio
{
    public partial class Form1 : Form
    {

        // --- Roles con flags correctos
        [Flags]
        public enum Roles
        {
            None = 0,
            Admin = 1,
            Recep = 2,
            Coach = 4,
       
        }

        private Roles CurrentRole;
        private string CurrentUser;

        // ACL por botón (se llena después de InitializeComponent)
        private readonly Dictionary<Button, Roles> Acl = new Dictionary<Button, Roles>();

        // Instanciamos un array de botones para manejar el sidebar
        private Button[] MenuButtons => new[]
        {
            BDashboard, BtnUsers, BtnPartners, BMemberships,
            BSupplier, BActivity, BInventory, BReports
        };

        public Form1()
        {
            InitializeComponent();

            WireSidebar();          // setea Tag de navegación y eventos
            BuildAcl();             // define permisos por botón

      

            MenuFlow.SuspendLayout();
            foreach (var b in MenuButtons)
            {
                // b.Visible = true; // REDUNDANTE: lo maneja ApplyAcl
                b.Dock = DockStyle.None; // Flow ignora Dock, pero evitá Top
                b.AutoSize = false;
                b.Height = 42;
                b.Margin = new Padding(0, 0, 0, 6);
            }
            MenuFlow.ResumeLayout();

            // mantener 100% de ancho
            MenuFlow.SizeChanged += (_, __) =>
            {
                int w = MenuFlow.ClientSize.Width - MenuFlow.Padding.Horizontal;
                foreach (var b in MenuButtons) b.Width = w;
            };

            this.Load += Form1_Load;
        }

        private void BuildAcl()
        {
            // Usá solo roles acá. Tag queda para navegación.
            Acl[BDashboard] = Roles.Admin;
            Acl[BtnUsers] = Roles.Admin;
            Acl[BtnPartners] = Roles.Admin | Roles.Recep;
            Acl[BMemberships] = Roles.Admin | Roles.Recep;
            Acl[BSupplier] = Roles.Admin | Roles.Recep;
            Acl[BActivity] = Roles.Admin | Roles.Recep | Roles.Coach;
            Acl[BInventory] = Roles.Admin | Roles.Recep;
            Acl[BReports] = Roles.Admin;
        }

        private void ApplyAcl(Roles role)
        {
            foreach (var b in MenuButtons)
                b.Visible = (Acl.TryGetValue(b, out var allowed) && (allowed & role) != 0);

            MenuFlow?.PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyAcl(CurrentRole);
            var first = MenuButtons.FirstOrDefault(b => b.Visible);
            if (first != null)
            {
                SetActive(first);
                Navigate((string)first.Tag);
            }
        }

        public void SetRoleAndRefresh(Roles newRole, string username)
        {
            CurrentRole = newRole;
            CurrentUser = username;
            ApplyAcl(CurrentRole);
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            LUser.Text = CurrentUser;
            LRole.Text = CurrentRole.ToString();
        }

        private void WireSidebar()
        {
            // Tags que usa Navigate() SOLO para navegación
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

        // Evento click de los botones del sidebar
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
                case "dashboard": ShowDashboard(); break;
                case "users": ShowUsers(); break;
                case "partners": ShowPartners(); break;
                case "classes": ShowClases(); break;
                case "inventory": ShowInventario(); break;
                case "memberships": ShowMemberships(); break;
                //case "supplier": ShowSuppliers(); break;
                case "reports": ShowReports(); break;
            }
        }

        // Estilo para activo/inactivo de los botones del sidebar
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

        // Vistas
        private void ShowDashboard()
        {
            contentPanel.Controls.Clear();
            this.Text = "GymManager Pro - Dashboard";
        }

        private void ShowUsers()
        {
            contentPanel.Controls.Clear();
            var view = new UsersManagment { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Usuarios";
        }

        private void ShowPartners()
        {
            contentPanel.Controls.Clear();
            var view = new PartnersView { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Socios";
        }

        private void ShowClases()
        {
            contentPanel.Controls.Clear();
            var view = new Clases { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Clases";
        }

        private void ShowInventario()
        {
            contentPanel.Controls.Clear();
            var view = new Inventory { Dock = DockStyle.Fill, BackColor = Color.White };
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
            var view = new SupplierView { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Proveedores";


        }

        private void BSupplier_MouseHover(object sender, EventArgs e)
        {
            PSubMenuSupplier.Visible = true;
            hideTimer.Stop();
        }

        private void BSupplier_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        private void PSubMenuSupplier_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        private void hideTimer_Tick(object sender, EventArgs e)
        {
            OcultarSiCursorFuera();
        }

        // hit-testing entre botón y panel usando coordenadas de pantalla
        private void OcultarSiCursorFuera()
        {
            var cursor = Cursor.Position;

            var btnRect = BSupplier.RectangleToScreen(BSupplier.ClientRectangle);
            var subRect = PSubMenuSupplier.RectangleToScreen(PSubMenuSupplier.ClientRectangle);

            if (!btnRect.Contains(cursor) && !subRect.Contains(cursor))
            {
                PSubMenuSupplier.Visible = false;
                hideTimer.Stop();
            }
        }

        // clics de submenú
        private void BProvList_Click(object sender, EventArgs e)
        {
            
            ShowSuppliers();
            SetActive(BSupplier); // mantiene resaltado el botón padre
            PSubMenuSupplier.Visible = false;
        }

        private void BPurchaseOrders_Click(object sender, EventArgs e)
        {
            ShowPurchaseOrders();
            SetActive(BSupplier);
            PSubMenuSupplier.Visible = false;
        }

        
        private void ShowPurchaseOrders()
        {
            contentPanel.Controls.Clear();
            var view = new PurcharseOrderView { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Órdenes de compra";
        }

    }
}
