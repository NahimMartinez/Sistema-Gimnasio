using Business;
using Entities;
using Sistema_Gimnasio.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sistema_Gimnasio
{
    public partial class Form1 : Form
    {
        // Definición de roles con Flags para combinaciones
        [Flags]
        public enum Roles
        {
            None = 0,
            Admin = 1,
            Recep = 2,
            Coach = 4,
        }
        // Convierte un nombre de rol legible a un valor del enum Roles.
        private Roles MapRoleByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return Roles.None;
            if (string.Equals(name, "Administrador", StringComparison.OrdinalIgnoreCase)) return Roles.Admin;
            if (string.Equals(name, "Recepcionista", StringComparison.OrdinalIgnoreCase)) return Roles.Recep;
            if (string.Equals(name, "Coach", StringComparison.OrdinalIgnoreCase)) return Roles.Coach;
            return Roles.None;
        }
        
        
        // ACL
        private readonly Dictionary<IconButton, Roles> Acl = new Dictionary<IconButton, Roles>();

        // Array de botones del sidebar
        private IconButton[] MenuButtons => new[]
        {
            BDashboard, BtnUsers, BtnPartners,
            BSupplier, BActivity, BInventory, BReports
        };

        // Estado actual del usuario autenticado: rol y nombre a mostrar en la UI.
        private Roles CurrentRole;
        private string CurrentUser;
        private readonly User user; // Usuario autenticado recibido desde el login.

        public Form1(User pU)
        {
            InitializeComponent();
            user = pU; // Guarda el usuario logueado para usar su rol/nombre.
            WireSidebar(); // Configura los botones del sidebar.
            BuildAcl(); // Construye la lista de control de acceso (ACL).

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // evita redimensionamiento
            this.MaximizeBox = false;  // Esto quita el botón del cuadrado (maximizar)
            this.MinimizeBox = true;

            // Ajustes visuales de los botones
            MenuFlow.SuspendLayout();
            foreach (var b in MenuButtons)
            {
                b.Dock = DockStyle.None;
                b.AutoSize = false;
                b.Height = 42;
                b.Margin = new Padding(0, 0, 0, 6);

                // Ajuste común para íconos
                b.IconColor = Color.White;
                b.IconSize = 22;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.ImageAlign = ContentAlignment.MiddleLeft;
            }
            MenuFlow.ResumeLayout();

            MenuFlow.SizeChanged += (_, __) =>
            {
                int w = MenuFlow.ClientSize.Width - MenuFlow.Padding.Horizontal;
                foreach (var b in MenuButtons) b.Width = w;
            };

            var nombreCompleto = ((user?.Nombre ?? "") + " " + (user?.Apellido ?? "")).Trim();
            var mostrado = string.IsNullOrWhiteSpace(nombreCompleto) ? (user?.Username ?? "") : nombreCompleto;
            // Setea el rol actual desde el nombre del rol proveniente de la entidad y refresca la UI.
            SetRoleAndRefresh(MapRoleByName(user?.Rol?.Nombre), mostrado);

            this.Load += Form1_Load;
        }
        // Define la matriz de permisos: qué botón puede ver cada rol.
        private void BuildAcl()
        {
            Acl[BDashboard] = Roles.Admin;
            Acl[BtnUsers] = Roles.Admin;
            Acl[BtnPartners] = Roles.Admin | Roles.Recep;
            Acl[BSupplier] = Roles.Admin | Roles.Recep;
            Acl[BActivity] = Roles.Admin | Roles.Recep | Roles.Coach;
            Acl[BInventory] = Roles.Admin | Roles.Recep;
            Acl[BReports] = Roles.Admin;
        }
        // Aplica la ACL al sidebar: muestra solo los botones autorizados para el rol dado.
        private void ApplyAcl(Roles role)
        {
            //trygetvalue devuelve false si no encuentra la llave
            foreach (var b in MenuButtons)
                b.Visible = (Acl.TryGetValue(b, out var allowed) && (allowed & role) != 0);

            MenuFlow?.PerformLayout(); // Fuerza recalcular el layout del FlowLayoutPanel tras ocultar/mostrar.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyAcl(CurrentRole); // Asegura que el menú muestre lo que corresponde al rol actual.
            // Selecciona el primer botón visible como activo e inicia la navegación a ese módulo.
            var first = MenuButtons.FirstOrDefault(b => b.Visible);
            if (first != null)
            {
                SetActive(first);
                Navigate((string)first.Tag);
            }
            // Configuración inicial del submenú de Proveedores.
            PSubMenuSupplier.Visible = false;
            hideTimer.Interval = 120;
            hideTimer.Tick += HideTimer_Tick;
            BSupplier.MouseEnter += BSupplier_MouseHover;
        }

        public void SetRoleAndRefresh(Roles newRole, string username)
        {
            CurrentRole = newRole;
            CurrentUser = username;
            ApplyAcl(CurrentRole); // Recalcula qué botones se ven.
            UpdateLabels(); // Actualiza etiquetas LUser y LRole.
        }

        private void UpdateLabels()
        {
            LUser.Text = CurrentUser;
            LRole.Text = CurrentRole.ToString();
        }

        private void WireSidebar()
        {
            // Asignar tags
            BDashboard.Tag = "dashboard";
            BtnUsers.Tag = "users";
            BtnPartners.Tag = "partners";
            BSupplier.Tag = "supplier";
            BActivity.Tag = "classes";
            BInventory.Tag = "inventory";
            BReports.Tag = "reports";

            // Asignar íconos FontAwesome
            BDashboard.IconChar = IconChar.ChartPie;
            BDashboard.Text = "Dashboard";

            BtnUsers.IconChar = IconChar.UsersCog;
            BtnUsers.Text = "Usuarios";

            BtnPartners.IconChar = IconChar.AddressBook;
            BtnPartners.Text = "Socios";

            BSupplier.IconChar = IconChar.TruckLoading;
            BSupplier.Text = "Proveedores";

            BActivity.IconChar = IconChar.Dumbbell;
            BActivity.Text = "Clases";

            BInventory.IconChar = IconChar.Boxes;
            BInventory.Text = "Inventario";

            BReports.IconChar = IconChar.ChartBar;
            BReports.Text = "Reportes";

            foreach (var b in MenuButtons) b.Click += MenuButton_Click;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            var btn = (IconButton)sender;
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
                case "reports": ShowReports(); break;
            }
        }

        private void SetActive(IconButton active)
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

        private void ShowDashboard()
        {
            contentPanel.Controls.Clear();
            var view = new Dashboard { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
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
            var view = new PartnersView { 
                Dock = DockStyle.Fill, 
                BackColor = Color.White,
                CurrentRole = CurrentRole
            };
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
        
        private void ShowReports()
        {
            contentPanel.Controls.Clear();
            var view = new Reports { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Reportes";
        }

        private void ShowSuppliers()
        {
            contentPanel.Controls.Clear();
            var view = new SupplierView { Dock = DockStyle.Fill, BackColor = Color.White, CurrentRole = CurrentRole };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Proveedores";
        }

        private void ShowPurchaseOrders()
        {
            contentPanel.Controls.Clear();
            var view = new PurchaseOrderView { Dock = DockStyle.Fill, BackColor = Color.White };
            contentPanel.Controls.Add(view);
            this.Text = "GymManager Pro - Órdenes de compra";
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

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            OcultarSiCursorFuera();
        }

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

        private void BProvList_Click(object sender, EventArgs e)
        {
            ShowSuppliers();
            SetActive(BSupplier);
            PSubMenuSupplier.Visible = false;
        }

        private void BPurchaseOrders_Click(object sender, EventArgs e)
        {
            ShowPurchaseOrders();
            SetActive(BSupplier);
            PSubMenuSupplier.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
