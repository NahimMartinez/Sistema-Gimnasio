
using Sistema_Gimnasio.Forms; 
using System;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using FontAwesome.Sharp;

namespace Sistema_Gimnasio.Controls
{
    
    public partial class Clases : UserControl
    {
        // Lista que almacena la información de las clases 
        private List<ClassViewModel> classList = new List<ClassViewModel>();

        // Constructor: se ejecuta al crear el control.
        public Clases()
        {
            InitializeComponent(); // Inicializa los componentes gráficos.
            LoadFakeData(); // Carga datos de ejemplo en la lista de clases.
            BoardClass.CellClick += BoardClass_CellClick; // Asocia el evento de clic en celda a un método.
            SetupActionIcons(); // Configura los iconos de acción (editar, ver, eliminar).
            this.Load += Clases_Load; // Asocia el evento de carga del control a un método.

            // Configura los filtros de búsqueda y estado.
            TSearchClass.TextChanged += (s, e) => ApplyFilters(); // Filtra al escribir en la caja de búsqueda.
            TSearchClass.GotFocus += (s, e) => {
                // Limpia el texto de placeholder al enfocar la caja de búsqueda.
                if (TSearchClass.Text == "Buscar clase...") {
                    TSearchClass.Text = "";
                    TSearchClass.ForeColor = Color.Black;
                }
            };
            TSearchClass.LostFocus += (s, e) => {
                // Restaura el placeholder si la caja queda vacía al perder el foco.
                if (string.IsNullOrWhiteSpace(TSearchClass.Text)) {
                    TSearchClass.Text = "Buscar clase...";
                    TSearchClass.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters(); // Filtra al cambiar el estado.
        }

        // Evento que se ejecuta al cargar el control.
        private void Clases_Load(object sender, EventArgs e)
        {
            // Inicializa el texto de búsqueda con un placeholder si está vacío.
            if (string.IsNullOrWhiteSpace(TSearchClass.Text))
            {
                TSearchClass.Text = "Buscar clase...";
                TSearchClass.ForeColor = Color.Gray;
            }
        }

        // Configura los iconos de las columnas de acción en la tabla.
        private void SetupActionIcons()
        {
            // Crea imágenes para los iconos usando FontAwesome.
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);

            // Asigna los iconos a las columnas correspondientes.
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            // Evento para mostrar los iconos en las celdas de acción.
            BoardClass.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return; // Ignora encabezados
                string col = BoardClass.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        // Evento que se ejecuta al hacer clic en una celda de la tabla.
        private void BoardClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clics fuera de las filas de datos
            var name = BoardClass.Rows[e.RowIndex].Cells["name"].Value; // Obtiene el nombre de la clase
            var col = BoardClass.Columns[e.ColumnIndex].Name; // Obtiene la columna clickeada
            // Muestra un mensaje según la acción seleccionada
            if (col == "colEdit")
            {
                MessageBox.Show($"Editar clase {name}");
            }
            else if (col == "colView")
            {
                MessageBox.Show($"Ver clase {name}");
            }
            else if (col == "colDelete")
            {
                MessageBox.Show($"Eliminar clase {name}");
            }
        }

        // Carga datos de ejemplo en la lista de clases.
        private void LoadFakeData()
        {
            classList = new List<ClassViewModel>
            {
                new ClassViewModel { Name = "Crossfit", Coach = "Juan Perez", Cupo = "20", Dia = "Lunes, Miercoles, Viernes", Horario = "6:00 - 7:00", Estado = "Activo" },
                new ClassViewModel { Name = "Yoga", Coach = "Maria Lopez", Cupo = "15", Dia = "Martes, Jueves", Horario = "7:00 - 8:00", Estado = "Activo" },
                new ClassViewModel { Name = "Pilates", Coach = "Carlos Gomez", Cupo = "10", Dia = "Lunes, Miercoles", Horario = "8:00 - 9:00", Estado = "Inactivo" },
                new ClassViewModel { Name = "Zumba", Coach = "Ana Martinez", Cupo = "25", Dia = "Viernes", Horario = "18:00 - 19:00", Estado = "Activo" },
                new ClassViewModel { Name = "Spinning", Coach = "Luis Rodriguez", Cupo = "30", Dia = "Martes, Jueves", Horario = "19:00 - 20:00", Estado = "Activo" }
            };
            ApplyFilters(); // Aplica los filtros para mostrar los datos en la tabla.
        }

        // Aplica los filtros de búsqueda y estado a la lista de clases y actualiza la tabla.
        private void ApplyFilters()
        {
            string query = TSearchClass.Text?.Trim().ToLowerInvariant(); // Obtiene el texto de búsqueda en minúsculas
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar clase...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos"; // Obtiene el estado seleccionado

            // Filtra la lista según el texto de búsqueda y el estado
            var filtered = classList.Where(c =>
                (!hasQuery || (c.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" ||
                 (estado == "Activo" && c.Estado.Equals("Activo", StringComparison.OrdinalIgnoreCase)) ||
                 (estado == "Inactivo" && c.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase)))
            ).ToList();

            BoardClass.Rows.Clear(); // Limpia la tabla
            foreach (var c in filtered)
            {
                // Agrega cada clase filtrada a la tabla
                BoardClass.Rows.Add(c.Name, c.Coach, c.Cupo, c.Dia, c.Horario, c.Estado);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para agregar una nueva clase.
        private void BNewClass_Click(object sender, EventArgs e)
        {
            using (var fNewClass = new AddClass()) // Crea el formulario para agregar clase
            {
                if (fNewClass.ShowDialog() == DialogResult.OK)
                {
                    // Aquí se podría recargar los datos 
                }
            }
        }

        // Clase interna que representa la información de una clase.
        private class ClassViewModel
        {
            public string Name { get; set; } // Nombre de la clase
            public string Coach { get; set; } // Nombre del entrenador
            public string Cupo { get; set; } // Cupo máximo de participantes
            public string Dia { get; set; } // Días en que se imparte la clase
            public string Horario { get; set; } // Horario de la clase
            public string Estado { get; set; } // Estado de la clase (Activo/Inactivo)
        }
    }
}
