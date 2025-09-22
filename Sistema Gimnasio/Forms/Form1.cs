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
        // El atributo [Flags] permite realizar operaciones (OR, AND) con los valores del enum
        [Flags]
        public enum Roles
        {
            None = 0,       // Sin permisos - valor base
            Admin = 1,      // Administrador - acceso completo
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

        // Diccionario que controla qué botones del menú puede ver cada rol
        // Key: IconButton (botón del menú), Value: Combinación de roles que tienen permiso
        private readonly Dictionary<IconButton, Roles> Acl = new Dictionary<IconButton, Roles>();

        // Array de botones del sidebar - devuelve todos los botones del menú principal
        private IconButton[] MenuButtons => new[]
        {
            BDashboard, BtnUsers, BtnPartners,
            BSupplier, BActivity, BInventory, BReports
        };

        // Estado actual del usuario autenticado
        private Roles CurrentRole;     // Rol actual del usuario logueado
        private string CurrentUser;    // username a mostrar
        private readonly User user;    // Instancia del usuario autenticado recibido desde login

        // Constructor principal del formulario
        public Form1(User pU)
        {
            InitializeComponent();     // Inicializa componentes
            user = pU;                 // Almacena el usuario autenticado para usar sus propiedades
            WireSidebar();             // Configura texto, íconos y eventos de los botones del sidebar
            BuildAcl();                // Construye la matriz de control de acceso por roles

            // Configuración de propiedades de la ventana principal
            this.WindowState = FormWindowState.Maximized;           // Inicia maximizada
            this.FormBorderStyle = FormBorderStyle.FixedSingle;     // Impide redimensionamiento
            this.MaximizeBox = false;                               // Oculta botón de maximizar
            this.MinimizeBox = true;                                // Mantiene botón de minimizar

            // Configuración visual de los botones del menú lateral
            MenuFlow.SuspendLayout();  // Suspende el layout para realizar múltiples cambios
            foreach (var b in MenuButtons)
            {
                b.Dock = DockStyle.None;           // Desactiva el docking automático
                b.AutoSize = false;                // Desactiva auto-dimensionamiento
                b.Height = 42;                     // Altura uniforme para todos los botones
                b.Margin = new Padding(0, 0, 0, 6); // Margen inferior entre botones

                // Configuración visual consistente para íconos
                b.IconColor = Color.White;                        // Color blanco para íconos
                b.IconSize = 22;                                 // Tamaño uniforme
                b.TextImageRelation = TextImageRelation.ImageBeforeText; // Ícono a la izquierda del texto
                b.ImageAlign = ContentAlignment.MiddleLeft;       // Alineación centrada verticalmente
            }
            MenuFlow.ResumeLayout();   // Reanuda el layout después de las modificaciones

            // Evento que ajusta el ancho de los botones cuando cambia el tamaño del contenedor
            MenuFlow.SizeChanged += (_, __) =>
            {
                int w = MenuFlow.ClientSize.Width - MenuFlow.Padding.Horizontal;
                foreach (var b in MenuButtons) b.Width = w;  // Ajusta ancho al espacio disponible
            };

            // Construye el nombre a mostrar: nombre completo o username
            var nombreCompleto = ((user?.Nombre ?? "") + " " + (user?.Apellido ?? "")).Trim();
            var mostrado = string.IsNullOrWhiteSpace(nombreCompleto) ? (user?.Username ?? "") : nombreCompleto;

            // Establece el rol actual y actualiza la interfaz
            SetRoleAndRefresh(MapRoleByName(user?.Rol?.Nombre), mostrado);

            this.Load += Form1_Load;  // Suscribe al evento Load del formulario
        }

        // Construye el control de acceso (ACL)
        // Define qué roles pueden ver cada botón del menú
        private void BuildAcl()
        {
            Acl[BDashboard] = Roles.Admin;                              // Dashboard: Solo Admin
            Acl[BtnUsers] = Roles.Admin;                                // Usuarios: Solo Admin  
            Acl[BtnPartners] = Roles.Admin | Roles.Recep | Roles.Coach; // Socios: Admin + Recep + coach
            Acl[BSupplier] = Roles.Admin | Roles.Recep;                 // Proveedores: Admin + Recep
            Acl[BActivity] = Roles.Admin | Roles.Recep | Roles.Coach;   // Clases: Todos los roles
            Acl[BInventory] = Roles.Admin | Roles.Recep;                // Inventario: Admin + Recep
            Acl[BReports] = Roles.Admin;                                // Reportes: Solo Admin
        }

        // Aplica la ACL al sidebar: muestra/oculta botones según los permisos del rol
        private void ApplyAcl(Roles role)
        {
            // TryGetValue devuelve false si no encuentra el botón en el diccionario ACL
            foreach (var b in MenuButtons)
                b.Visible = (Acl.TryGetValue(b, out var allowed) && (allowed & role) != 0);

            MenuFlow?.PerformLayout(); // Fuerza recalcular el layout después de cambiar visibilidad
        }

        // Evento Load del formulario - se ejecuta cuando el formulario se carga completamente
        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyAcl(CurrentRole); // Asegura que el menú muestre solo lo permitido para el rol actual

            // Selecciona el primer botón visible como activo e inicia la navegación
            var first = MenuButtons.FirstOrDefault(b => b.Visible);
            if (first != null)
            {
                SetActive(first);            // Establece apariencia visual de activo
                Navigate((string)first.Tag); // Navega al módulo correspondiente
            }

            // Configuración inicial del submenú de Proveedores
            PSubMenuSupplier.Visible = false;   // Inicialmente oculto
            hideTimer.Interval = 120;           // Intervalo del timer en milisegundos
            hideTimer.Tick += HideTimer_Tick;   // Suscribe evento del timer

            // Eventos para mostrar/ocultar submenú al interactuar con el botón
            BSupplier.MouseEnter += BSupplier_MouseHover;
        }

        // Establece el rol actual y refresca la interfaz de usuario
        public void SetRoleAndRefresh(Roles newRole, string username)
        {
            CurrentRole = newRole;
            CurrentUser = username;
            ApplyAcl(CurrentRole); // Recalcula visibilidad de botones según nuevo rol
            UpdateLabels();        // Actualiza etiquetas que muestran usuario y rol
        }

        // Actualiza las etiquetas de la interfaz con información del usuario actual
        private void UpdateLabels()
        {
            LUser.Text = CurrentUser;          // Muestra nombre de usuario
            LRole.Text = CurrentRole.ToString(); // Muestra rol actual
        }

        // Configura los botones del sidebar: texto, íconos, tags y eventos
        private void WireSidebar()
        {
            // Asignar tags - identificadores únicos para cada módulo (usados en navegación)
            BDashboard.Tag = "dashboard";
            BtnUsers.Tag = "users";
            BtnPartners.Tag = "partners";
            BSupplier.Tag = "supplier";
            BActivity.Tag = "classes";
            BInventory.Tag = "inventory";
            BReports.Tag = "reports";

            // Asignar íconos FontAwesome y texto descriptivo
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

            // Asignar evento Click a todos los botones del menú
            foreach (var b in MenuButtons) b.Click += MenuButton_Click;
        }

        // Maneja el evento Click de cualquier botón del menú
        private void MenuButton_Click(object sender, EventArgs e)
        {
            var btn = (IconButton)sender;
            Navigate((string)btn.Tag);  // Navega al módulo según el tag del botón
            SetActive(btn);             // Cambia apariencia visual a activo
        }

        // Navega al módulo correspondiente según el identificador del menú
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

        // Cambia la apariencia visual para indicar qué botón está activo
        private void SetActive(IconButton active)
        {
            var orange = Color.FromArgb(249, 115, 22);  // Color naranja para botón activo
            var dark = Color.FromArgb(15, 23, 42);      // Color oscuro para botones inactivos

            // Restablece todos los botones a estado inactivo
            foreach (var b in MenuButtons)
            {
                b.BackColor = dark;
                b.Font = new Font(b.Font, FontStyle.Regular);
            }

            // Aplica estilo visual al botón activo
            active.BackColor = orange;
            active.Font = new Font(active.Font, FontStyle.Bold);
        }

        // === MÉTODOS DE NAVEGACIÓN A MÓDULOS ===
        // Cada método limpia el panel de contenido y carga el control correspondiente

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
            var view = new PartnersView
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                CurrentRole = CurrentRole  // Pasa el rol actual para control interno
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

        // Métodos para el submenú de Proveedores
        private void ShowSuppliers()
        {
            contentPanel.Controls.Clear();
            var view = new SupplierView
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                CurrentRole = CurrentRole  // Pasa el rol actual para control interno
            };
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

        // === MANEJO DEL SUBMENÚ DE PROVEEDORES ===

        // Muestra el submenú al hacer hover sobre el botón de proveedores
        private void BSupplier_MouseHover(object sender, EventArgs e)
        {
            PSubMenuSupplier.Visible = true;
            hideTimer.Stop();  // Detiene el timer de ocultamiento automático
        }

        // Inicia timer para ocultar submenú al salir del botón principal
        private void BSupplier_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        // Inicia timer para ocultar submenú al salir del panel del submenú
        private void PSubMenuSupplier_MouseLeave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

        // Evento del timer que verifica si debe ocultar el submenú
        private void HideTimer_Tick(object sender, EventArgs e)
        {
            OcultarSiCursorFuera();
        }

        // Oculta el submenú si el cursor no está sobre el botón principal o el submenú
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

        // === EVENTOS DE CLICK DEL SUBMENÚ ===

        private void BProvList_Click(object sender, EventArgs e)
        {
            ShowSuppliers();           // Muestra vista de proveedores
            SetActive(BSupplier);      // Marca botón principal como activo
            PSubMenuSupplier.Visible = false;  // Oculta submenú después de la selección
        }

        private void BPurchaseOrders_Click(object sender, EventArgs e)
        {
            ShowPurchaseOrders();      // Muestra vista de órdenes de compra
            SetActive(BSupplier);      // Marca botón principal como activo
            PSubMenuSupplier.Visible = false;  // Oculta submenú después de la selección
        }

    }
}