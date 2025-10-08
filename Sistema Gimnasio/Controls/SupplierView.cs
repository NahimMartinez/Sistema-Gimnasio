using Business;
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
                Estado = s.Estado
            }).ToList();

            BoardSupplier.AutoGenerateColumns = false; // No generar columnas automáticamente
            ApplyFilters(); // Muestra según filtros actuales
        }

        // Evento que se ejecuta al cargar el control.
        private void SupplierView_Load(object sender, EventArgs e)
        {
            BuildAcl(); // Construye el diccionario de control de acceso (ACL)
            ApplyAcl(); // Aplica el control de acceso según el rol actual

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
                        row.DefaultCellStyle.SelectionBackColor = BoardSupplier.DefaultCellStyle.SelectionBackColor;
                        row.DefaultCellStyle.SelectionForeColor = BoardSupplier.DefaultCellStyle.SelectionForeColor;
                    }
                }
            };
        }

        // Evento que se ejecuta al hacer clic en una celda de la tabla.
        private void BoardSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clics fuera de las filas de datos
            var name = BoardSupplier.Rows[e.RowIndex].Cells["name"].Value; // Obtiene el nombre del proveedor
            var col = BoardSupplier.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            // Muestra un mensaje según la acción seleccionada
            if (col == "colEdit")
            {
                MessageBox.Show($"Editar proveedor {name}");
            }
            else if (col == "colView")
            {
                MessageBox.Show($"Ver proveedor {name}");
            }
            else if (col == "colDelete")
            {
                MessageBox.Show($"Eliminar proveedor {name}");
            }
        }

        // Carga datos de ejemplo en la lista de proveedores.
       

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
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos"; // Obtiene el estado seleccionado

            // Filtra la lista según el texto de búsqueda y el estado
            var filtered = suppliersList.Where(s =>
                (!hasQuery || (s.Nombre ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" ||
                 (estado == "Activo" && s.Estado) ||
                 (estado == "Inactivo" && s.Estado))
            ).ToList();

            BoardSupplier.Rows.Clear(); // Limpia la tabla
            foreach (var s in filtered)
            {
                // Agrega cada proveedor filtrado a la tabla
                BoardSupplier.Rows.Add(s.Nombre, s.Cuit, s.Email, s.Telefono, s.Estado);
            }
        }

        
    }
}
