using Business;
using Data;
using Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_Gimnasio.Form1;

namespace Sistema_Gimnasio
{
    public partial class SupplierView : UserControl
    {
        // Propiedad que indica el rol actual del usuario (por ejemplo, Admin, Coach, etc.)
        public Roles CurrentRole { get; set; } = Roles.None;

        // Diccionario que asocia columnas de la tabla con roles para control de acceso (ACL)
        private readonly Dictionary<DataGridViewColumn, Roles> Acl = new Dictionary<DataGridViewColumn, Roles>();

        // Lista que almacena la información de los proveedores (simulada en este ejemplo)
        private List<Supplier> suppliersList = new List<Supplier>();

        // Constructor: se ejecuta al crear el control.
        public SupplierView()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.
            LoadSupplier(); // Carga datos de proveedores.
            BoardSupplier.CellClick += BoardSupplier_CellClick; // Asocia el evento de clic en celda a un método.
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
            this.Load += SupplierView_Load; // Asocia el evento de carga del control a un método.

            // Configura los filtros de búsqueda y estado.
            TSearchSupplier.TextChanged += (s, e) => ApplyFilters(); // Filtra al escribir en la caja de búsqueda.
            TSearchSupplier.GotFocus += (s, e) => {
                // Limpia el texto de placeholder al enfocar la caja de búsqueda.
                if (TSearchSupplier.Text == "Buscar proveedor...") {
                    TSearchSupplier.Text = "";
                    TSearchSupplier.ForeColor = Color.Black;
                }
            };
            TSearchSupplier.LostFocus += (s, e) => {
                // Restaura el placeholder si la caja queda vacía al perder el foco.
                if (string.IsNullOrWhiteSpace(TSearchSupplier.Text)) {
                    TSearchSupplier.Text = "Buscar proveedor...";
                    TSearchSupplier.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar el estado.
        }
        private void LoadSupplier()
        {
            var supplierService = new SupplierService(); // Servicio para obtener proveedores
            var allSupplier = supplierService.GetAllSuppliers(); // Obtiene todos los proveedores en formato lista
            // Convierte a lista local para filtrar
            suppliersList = allSupplier.Select(s => new Supplier
            {
                Nombre = s.Nombre,
                Cuit = s.Cuit,
                Email = s.Email,
                Telefono = s.Telefono,
                Estado = s.Estado,
            }).ToList();

            BoardSupplier.AutoGenerateColumns = false; // No generar columnas automáticamente
            ApplyFilters(); // Muestra según filtros actuales
        }

        // Evento que se ejecuta al cargar el control.
        private void SupplierView_Load(object sender, EventArgs e)
        {
            BuildAcl(); // Construye el diccionario de control de acceso (ACL)
            ApplyAcl(); // Aplica el control de acceso según el rol actual
            if(CurrentRole != Roles.Admin)
            {
                BNewSupplier.Visible = false; // Oculta el botón de nuevo proveedor si no es Admin
            }
            // Inicializa el texto de búsqueda con un placeholder si está vacío.
            if (string.IsNullOrWhiteSpace(TSearchSupplier.Text))
            {
                TSearchSupplier.Text = "Buscar proveedor...";
                TSearchSupplier.ForeColor = Color.Gray;
            }
        }

        // Configura los iconos de las columnas de acción en la tabla.
        private void SetupActionIcons()
        {
            // Crea imágenes para los iconos usando FontAwesome.
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30); // Icono de editar
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30); // Icono de ver
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30); // Icono de eliminar
            Bitmap bmpEnable = IconChar.UserCheck.ToBitmap(Color.Black, 30);
            // Asigna los iconos a las columnas correspondientes.
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            // Evento para mostrar los iconos en las celdas de acción.
            BoardSupplier.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return; // Ignora encabezados
                string col = BoardSupplier.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") {
                    var status = BoardSupplier.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = status?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;
                    ev.Value = activo ? bmpDelete : bmpEnable;
                    ev.FormattingApplied = true; 
                
                
                }

                if (col == "status")
                {
                    var st = BoardSupplier.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = st?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    var row = BoardSupplier.Rows[ev.RowIndex];
                    if (!activo)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        // Resetea a valores por defecto
                        row.DefaultCellStyle.BackColor = BoardSupplier.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = BoardSupplier.DefaultCellStyle.ForeColor;
                        
                    }
                }
            };
        }

        // Evento que se ejecuta al hacer clic en una celda de la tabla.
        private void BoardSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clics fuera de las filas de datos
            //var name = BoardSupplier.Rows[e.RowIndex].Cells["name"].Value; // Obtiene el nombre del proveedor
            var col = BoardSupplier.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            // Muestra un mensaje según la acción seleccionada
            if (col == "colEdit")
            {
                // Obtener el DNI del usuario seleccionado
                var cuitCell = BoardSupplier.Rows[e.RowIndex].Cells["Cuit"].Value;
                var supRepo = new SupplierRepository();
                // Obtener el usuario completo
                var supplier = supRepo.GetSupplierByCuit((long)cuitCell);
                // Abrir el formulario en modo edición
                using (var fEditUser = new AddSupplierForm(supplier, false))
                {
                    if (fEditUser.ShowDialog() == DialogResult.OK)
                    {
                        // Recargar la grilla después de editar
                        LoadSupplier();
                    }
                }
            }
            else if (col == "colView")
            {
                var cuitCell = BoardSupplier.Rows[e.RowIndex].Cells["Cuit"].Value;
                var supRepo = new SupplierRepository();
                var supplier = supRepo.GetSupplierByCuit((long)cuitCell);
                using (var fViewUser = new AddSupplierForm(supplier, true)) // true para modo solo lectura
                {
                    fViewUser.ShowDialog(); // Solo mostrar, no editar
                }

            }
            else if (col == "colDelete")
            {
                var cuitCell = BoardSupplier.Rows[e.RowIndex].Cells["Cuit"].Value;
                var name = BoardSupplier.Rows[e.RowIndex].Cells["name"].Value;
                var cell = BoardSupplier.Rows[e.RowIndex].Cells["status"].Value?.ToString().Trim();
                bool s = cell == "1" || cell?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;
                var repo = new SupplierRepository();
                if (s)
                {
                    var confirm = MessageBox.Show($"¿Está seguro que desea desactivar el proveedor '{name}'?", "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {

                        var repoD = repo.DisableSupplier((long)cuitCell);
                        if (repoD == 0) MessageBox.Show("No se realizó la baja. Puede estar ya inactivo o no existe.");
                        LoadSupplier();

                    }                    
                }
                else
                {
                    var confirm = MessageBox.Show($"¿Está seguro que desea activar el proveedor '{name}'?", "Confirmar activación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        var repoE = repo.EnableSupplier((long)cuitCell);
                        if (repoE == 0) MessageBox.Show("No se realizó la activación. Puede estar ya activo o no existe.");
                        LoadSupplier();
                    }
                }
            }
        }
               

        // Construye el diccionario de control de acceso (ACL) para las columnas de acción.
        private void BuildAcl()
        {
            // Solo el rol Admin puede editar y eliminar
            Acl[colEdit] = Roles.Admin;
            Acl[colDelete] = Roles.Admin;
            // El rol Admin y Recepcionista pueden ver
            Acl[colView] = Roles.Admin | Roles.Recep;
        }

        // Aplica el control de acceso a las columnas de acción según el rol actual.
        private void ApplyAcl()
        {
            foreach (var keyValue in Acl)
                keyValue.Key.Visible = (CurrentRole & keyValue.Value) != 0; // Solo muestra la columna si el rol tiene permiso
        }

        // Evento que se ejecuta al hacer clic en el botón para agregar un nuevo proveedor.
        private void BNewSupplier_Click_1(object sender, EventArgs e)
        {
            // Crea una instancia del formulario para agregar proveedor
            using (var fNewSupllier = new AddSupplierForm())
            {
                // Muestra el formulario como un cuadro de diálogo
                if (fNewSupllier.ShowDialog() == DialogResult.OK)
                {
                    LoadSupplier();
                }
            }
        }

        // Aplica los filtros de búsqueda y estado a la lista de proveedores y actualiza la tabla.
        private void ApplyFilters()
        {
            string query = TSearchSupplier.Text?.Trim().ToLowerInvariant(); // Obtiene el texto de búsqueda en minúsculas
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar proveedor...";

            // Estado según banderas
            var s = CBStatus.SelectedItem?.ToString() ?? "Todos";
            bool WantActivo = s.Equals("Activo", StringComparison.OrdinalIgnoreCase);
            bool WantInactivo = s.Equals("Inactivo", StringComparison.OrdinalIgnoreCase);
            bool WantAllS = s.Equals("Todos", StringComparison.OrdinalIgnoreCase);
                                   
            bool IsActivo(Supplier pSupplier)
            {
                var val = (pSupplier.Estado ?? "").Trim();
                return val == "1" || val.Equals("Activo", StringComparison.OrdinalIgnoreCase);
            }

            // Filtro combinado: filtra por texto, estado 
            var view = suppliersList.Where(supplier =>
                (!hasQuery ||
                    ((supplier.Nombre ?? "").ToLower().Contains(query) ||
                    (supplier.Cuit.ToString() ?? "").ToLower().Contains(query))) &&
                (WantAllS || (WantActivo && IsActivo(supplier)) || (WantInactivo && !IsActivo(supplier)))
            ).ToList();

            // Actualiza el datasource de la grilla
            BoardSupplier.DataSource = null;
            BoardSupplier.DataSource = view;
        }

        
    }
}
