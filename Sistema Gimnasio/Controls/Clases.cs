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
using Business;

namespace Sistema_Gimnasio.Controls
{
    public partial class Clases : UserControl
    {
        private readonly ClassService classService = new ClassService();
        private List<ClassViewModel> classList = new List<ClassViewModel>();

        public Clases()
        {
            InitializeComponent();
            LoadDataFromService(); // Carga datos reales
            BoardClass.CellClick += BoardClass_CellClick;
            SetupActionIcons();
            this.Load += Clases_Load;

            TSearchClass.TextChanged += (s, e) => ApplyFilters();
            TSearchClass.GotFocus += (s, e) => {
                if (TSearchClass.Text == "Buscar clase...") {
                    TSearchClass.Text = "";
                    TSearchClass.ForeColor = Color.Black;
                }
            };
            TSearchClass.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearchClass.Text)) {
                    TSearchClass.Text = "Buscar clase...";
                    TSearchClass.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        private void LoadDataFromService()
        {
            // Obtiene la lista dinámica del servicio y la mapea a la vista
            var data = classService.GetAllClassesForView();
            classList = data.Select(c => new ClassViewModel
            {
                Name = c.NombreActividad,
                Coach = c.NombreCoach,
                Cupo = c.Cupo.ToString(),
                Dia = c.Dias, // ya es string con los días
                Horario = c.Horario,
                Estado = (c.Estado is bool b) ? (b ? "Activo" : "Inactivo") : (c.Estado?.ToString() == "1" ? "Activo" : "Inactivo")
            }).ToList();
            ApplyFilters();
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
            Bitmap bmpEnable = IconChar.UserCheck.ToBitmap(Color.Black, 30); // Icono de alta

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
                if (col == "colDelete") {
                    var status = BoardClass.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = status?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    ev.Value = activo ? bmpDelete : bmpEnable; 
                    ev.FormattingApplied = true; }

                if (col == "status")
                {
                    var st = BoardClass.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = st?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;

                    var row = BoardClass.Rows[ev.RowIndex];
                    if (!activo)
                    {
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                        row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        // Resetea a valores por defecto
                        row.DefaultCellStyle.BackColor = BoardClass.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = BoardClass.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.SelectionBackColor = BoardClass.DefaultCellStyle.SelectionBackColor;
                        row.DefaultCellStyle.SelectionForeColor = BoardClass.DefaultCellStyle.SelectionForeColor;
                    }
                }
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
            using (var fNewClass = new AddClass())
            {
                // Si el formulario AddClass se cerró con "OK" (o sea, se guardó exitosamente)...
                if (fNewClass.ShowDialog() == DialogResult.OK)
                {
                    // ...entonces volvemos a llamar al método que carga los datos desde la base de datos.
                    LoadDataFromService();
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
