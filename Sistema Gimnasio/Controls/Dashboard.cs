using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistema_Gimnasio.Controls
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadFakeData();
            LoadIngresosMensuales();
        }


        private void LoadFakeData()
        {
            // nombre socio, apellido socio, membresia, fecha alta
            BoardRecent.Rows.Add("María", "Gómez", "Diaria", "13/09/2025");
            BoardRecent.Rows.Add("Carlos", "Rodríguez", "Mensual", "12/09/2025");
            BoardRecent.Rows.Add("Ana", "Martínez", "Semanal", "12/09/2025");
            BoardRecent.Rows.Add("Juan", "Pérez", "Diaria", "10/09/2025");
            BoardRecent.Rows.Add("Laura", "García", "Mensual", "09/09/2025");
            BoardRecent.Rows.Add("Diego", "Fernández", "Semanal", "09/09/2025");
        }


        private void BoardClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadIngresosMensuales()
        {
            // Configurar el gráfico
            chartIngresosMensuales.Titles.Add("Ingresos Mensuales 2025");
            chartIngresosMensuales.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartIngresosMensuales.ChartAreas[0].AxisX.Interval = 1;

            // Datos fake de ingresos por mes (en miles)
            var ingresos = new Dictionary<string, decimal>
            {
                {"1", 8.5m}, {"2", 13.2m}, {"3", 10.1m},
                {"4", 11.3m}, {"5", 12.8m}, {"6", 14.2m},
                {"7", 15.5m}, {"8", 11.8m}, {"9", 0m},
                {"10", 0m}, {"11", 0m}, {"12", 0m}
            };

            // Limpiar series existentes
            chartIngresosMensuales.Series.Clear();

            // Crear nueva serie
            Series serie = new Series("Ingresos");
            serie.ChartType = SeriesChartType.Column; // Tipo de gráfico de columnas
            serie.IsValueShownAsLabel = false; // ← CAMBIO AQUÍ: false en lugar de true

            // Agregar datos
            foreach (var ingreso in ingresos)
            {
                serie.Points.AddXY(ingreso.Key, ingreso.Value);
            }

            // Agregar serie al chart
            chartIngresosMensuales.Series.Add(serie);

            // Formatear ejes
            chartIngresosMensuales.ChartAreas[0].AxisY.Title = "Miles de $";
            chartIngresosMensuales.ChartAreas[0].AxisX.Title = "Meses";

            // Personalizar colores
            serie.Color = Color.FromArgb(65, 105, 225); // Color azul
                                                        // serie.LabelForeColor = Color.White; ← ESTA LÍNEA YA NO ES NECESARIA

            // Formato de números en los ejes
            chartIngresosMensuales.ChartAreas[0].AxisY.LabelStyle.Format = "{0}k";
        }
    }
}
