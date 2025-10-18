using Business;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistema_Gimnasio.Controls
{
    public partial class Reports : UserControl
    {
        private readonly InventoryService inventoryService = new InventoryService();
        private readonly ClassService classService = new ClassService();

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadInventoryDataIntoChart();
            ConfigurarGraficoRadarCapacidad();
        }

        // Carga los datos dinámicos del inventario en el gráfico.
        private void LoadInventoryDataIntoChart()
        {
            // Obtenemos la serie que ya fue creada por el diseñador.
            Series series = chartRadarInventario.Series["Cantidad"];
            // Limpiamos solo los puntos, no toda la configuración.
            series.Points.Clear();

            try
            {
                var data = inventoryService.GetInventoryCountByCategory();

                if (data.Count == 0)
                {
                    chartRadarInventario.Titles.Add("No hay datos de inventario.");
                    return;
                }

                // Agregamos los nuevos puntos dinámicos.
                foreach (var item in data)
                {
                    series.Points.Add(new DataPoint(0, (double)item.Cantidad) { AxisLabel = item.Categoria });
                }

                // Ajustamos el eje Y dinámicamente.
                double maxValue = data.Max(item => (double)item.Cantidad);
                ChartArea chartArea = chartRadarInventario.ChartAreas[0];
                chartArea.AxisY.Maximum = maxValue + (maxValue * 0.1);
                chartArea.AxisY.Interval = Math.Ceiling(maxValue / 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del gráfico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chartRadarInventario.Titles.Add("Error al cargar datos");
            }
        }

        public void ConfigurarGraficoRadarCapacidad()
        {
            // Limpiamos el gráfico para empezar de cero
            chartRadarClases.Series.Clear();
            chartRadarClases.Titles.Clear();
            chartRadarClases.ChartAreas.Clear();

            // Recreamos el área y el título
            ChartArea chartArea = new ChartArea();
            chartRadarClases.ChartAreas.Add(chartArea);
            chartRadarClases.Titles.Add("Cantidad de alumnos por clase");
            chartRadarClases.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Creamos la serie
            Series series = new Series("Capacidad")
            {
                ChartType = SeriesChartType.Radar,
                BorderWidth = 3,
                Color = Color.SteelBlue,
                IsValueShownAsLabel = true,
                LabelFormat = "# alumnos" // Tu formato original
            };
            chartRadarClases.Series.Add(series);

            try
            {
                // Obtenemos los datos desde la base de datos
                var data = classService.GetPartnerCountByClassService();

                if (data.Count == 0)
                {
                    chartRadarClases.Titles.Add("No hay datos de clases para mostrar.");
                    return;
                }

                // Agregamos los datos dinámicos al gráfico
                foreach (var item in data)
                {
                    series.Points.Add(new DataPoint(0, (double)item.CantidadSocios) { AxisLabel = item.Clase });
                }

                // Ajustamos el eje Y dinámicamente
                double maxValue = data.Max(item => (double)item.CantidadSocios);
                chartArea.AxisY.Maximum = maxValue + (maxValue * 0.2); // 20% de margen
                chartArea.AxisY.Interval = Math.Ceiling(maxValue / 4); // 4 divisiones en el eje
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico de socios por clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chartRadarClases.Titles.Add("Error al cargar datos");
            }
        }
    }
}