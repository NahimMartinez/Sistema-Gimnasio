﻿using Sistema_Gimnasio.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            LoadDataFromService();
            BoardClass.CellClick += BoardClass_CellClick;
            SetupActionIcons();
            this.Load += Clases_Load;

            TSearchClass.TextChanged += (s, e) => ApplyFilters();
            TSearchClass.GotFocus += (s, e) => {
                if (TSearchClass.Text == "Buscar clase...")
                {
                    TSearchClass.Text = "";
                    TSearchClass.ForeColor = Color.Black;
                }
            };
            TSearchClass.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(TSearchClass.Text))
                {
                    TSearchClass.Text = "Buscar clase...";
                    TSearchClass.ForeColor = Color.Gray;
                }
            };
            CBStatus.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        private void LoadDataFromService()
        {
            try
            {
                var data = classService.GetAllClassesForView();
                classList = data.Select(c => new ClassViewModel
                {
                    IdClase = c.IdClase,
                    Name = c.NombreActividad,
                    Coach = c.NombreCoach,
                    Cupo = c.Cupo.ToString(),
                    Dia = c.Dias,
                    Horario = c.Horario,
                    Estado = c.Estado ? "Activo" : "Inactivo"
                }).ToList();
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void ApplyFilters()
        {
            string query = TSearchClass.Text?.Trim().ToLowerInvariant();
            bool hasQuery = !string.IsNullOrWhiteSpace(query) && query != "buscar clase...";
            string estado = CBStatus.SelectedItem?.ToString() ?? "Todos";

            var filtered = classList.Where(c =>
                (!hasQuery || (c.Name ?? "").ToLower().Contains(query)) &&
                (estado == "Todos" || c.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            BoardClass.Rows.Clear();
            foreach (var c in filtered)
            {
                // SIEMPRE orden que coincida con el diseñador
                BoardClass.Rows.Add(c.IdClase, c.Name, c.Coach, c.Cupo, c.Dia, c.Horario, c.Estado);
            }
        }

        private void BoardClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = BoardClass.Columns[e.ColumnIndex].Name;

            if (colName == "colDelete" || colName == "colEdit" || colName == "colView")
            {
                int classId = Convert.ToInt32(BoardClass.Rows[e.RowIndex].Cells["id_clase"].Value);
                string className = BoardClass.Rows[e.RowIndex].Cells["name"].Value.ToString();
                string currentStatus = BoardClass.Rows[e.RowIndex].Cells["status"].Value.ToString();

                if (colName == "colDelete")
                {
                    string action = currentStatus == "Activo" ? "desactivar" : "activar";
                    DialogResult result = MessageBox.Show($"¿Está seguro de que desea {action} la clase '{className}'?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            classService.ChangeClassStatus(classId);
                            LoadDataFromService();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (colName == "colEdit")
                {
                    // Abre el formulario AddClass usando el nuevo constructor, pasándole el ID de la clase
                    using (var fEditClass = new AddClass(classId))
                    {
                        // Si el formulario se cerró con OK (es decir, se guardó correctamente)...
                        if (fEditClass.ShowDialog() == DialogResult.OK)
                        {
                            // ...recargamos los datos para mostrar los cambios en la tabla.
                            LoadDataFromService();
                        }
                    }
                }
                else if (colName == "colView")
                {
                    // Abre el formulario AddClass usando el constructor de edición/vista,
                    // pasándole el ID de la clase y la bandera 'isViewOnly' en 'true'.
                    using (var fViewClass = new AddClass(classId, true))
                    {
                        fViewClass.ShowDialog(); // Simplemente lo mostramos, no necesitamos recargar datos después.
                    }
                }
            }
        }


        private void Clases_Load(object sender, EventArgs e)
        {
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
            Bitmap bmpEnable = IconChar.UserCheck.ToBitmap(Color.Black, 30);
            colEdit.Image = bmpEdit;
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;
            BoardClass.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardClass.Columns[ev.ColumnIndex].Name;
                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete")
                {
                    var status = BoardClass.Rows[ev.RowIndex].Cells["status"].Value?.ToString();
                    bool activo = status?.Equals("Activo", StringComparison.OrdinalIgnoreCase) == true;
                    ev.Value = activo ? bmpDelete : bmpEnable;
                    ev.FormattingApplied = true;
                }
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
                        row.DefaultCellStyle.BackColor = BoardClass.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.ForeColor = BoardClass.DefaultCellStyle.ForeColor;
                        row.DefaultCellStyle.SelectionBackColor = BoardClass.DefaultCellStyle.SelectionBackColor;
                        row.DefaultCellStyle.SelectionForeColor = BoardClass.DefaultCellStyle.SelectionForeColor;
                    }
                }
            };
        }

        private void BNewClass_Click(object sender, EventArgs e)
        {
            using (var fNewClass = new AddClass())
            {
                if (fNewClass.ShowDialog() == DialogResult.OK)
                {
                    LoadDataFromService();
                }
            }
        }

        private class ClassViewModel
        {
            public int IdClase { get; set; }
            public string Name { get; set; }
            public string Coach { get; set; }
            public string Cupo { get; set; }
            public string Dia { get; set; }
            public string Horario { get; set; }
            public string Estado { get; set; }
        }
    }
}