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
        private List<ClassViewModel> classList = new List<ClassViewModel>();

        public Clases()
        {
            InitializeComponent();
            LoadFakeData();
            BoardClass.CellClick += BoardClass_CellClick;
            SetupActionIcons();
            this.Load += Clases_Load;

            // Filtros
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

        private void Clases_Load(object sender, EventArgs e)
        {
            // Inicializamos placeholder al cargar
            if (string.IsNullOrWhiteSpace(TSearchClass.Text))
            {
                TSearchClass.Text = "Buscar clase...";
                TSearchClass.ForeColor = Color.Gray;
            }
        }

        private void SetupActionIcons()
        {
            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);

            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            BoardClass.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardClass.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };
        }

        private void BoardClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var name = BoardClass.Rows[e.RowIndex].Cells["name"].Value;
            var col = BoardClass.Columns[e.ColumnIndex].Name;
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
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string query = TSearchClass.Text?.Trim().ToLowerInvariant();
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar clase...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos";

            var filtered = classList.Where(c =>
                (!hasQuery || (c.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" ||
                 (estado == "Activo" && c.Estado.Equals("Activo", StringComparison.OrdinalIgnoreCase)) ||
                 (estado == "Inactivo" && c.Estado.Equals("Inactivo", StringComparison.OrdinalIgnoreCase)))
            ).ToList();

            BoardClass.Rows.Clear();
            foreach (var c in filtered)
            {
                BoardClass.Rows.Add(c.Name, c.Coach, c.Cupo, c.Dia, c.Horario, c.Estado);
            }
        }

        private void BNewClass_Click(object sender, EventArgs e)
        {
            using (var fNewClass = new AddClass())
            {
                if (fNewClass.ShowDialog() == DialogResult.OK)
                {
                    // recargar datos si es necesario
                }
            }
        }

        private class ClassViewModel
        {
            public string Name { get; set; }
            public string Coach { get; set; }
            public string Cupo { get; set; }
            public string Dia { get; set; }
            public string Horario { get; set; }
            public string Estado { get; set; }
        }
    }
}
