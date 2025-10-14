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
        private TableLayoutPanel tableLayout;

        private readonly InventoryService inventoryService = new InventoryService();

        public Reports()
        {
            InitializeComponent();
            InicializarLayout();
            ConfigurarGraficoRadarCapacidad(); 
            ConfigurarGraficoRadarInventario();
        }

        private void InicializarLayout()
        {
            tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.ColumnCount = 2;
            tableLayout.RowCount = 1;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Clear();
            chartRadarClases.Dock = DockStyle.Fill;
            chartRadarInventario.Dock = DockStyle.Fill;
            tableLayout.Controls.Add(chartRadarClases, 0, 0);
            tableLayout.Controls.Add(chartRadarInventario, 1, 0);
            this.Controls.Add(tableLayout);
        }

        public void ConfigurarGraficoRadarCapacidad()
        {
            chartRadarClases.Series.Clear();
            chartRadarClases.Titles.Clear();
            chartRadarClases.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartRadarClases.ChartAreas.Add(chartArea);
            chartRadarClases.Titles.Add("Cantidad de alumnos por clase");
            chartRadarClases.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            Series series = new Series("Capacidad");
            series.ChartType = SeriesChartType.Radar;
            series.BorderWidth = 3;
            series.Color = Color.SteelBlue;
            series.Points.Add(new DataPoint(0, 20) { AxisLabel = "Crossfit" });
            series.Points.Add(new DataPoint(1, 15) { AxisLabel = "Yoga" });
            series.Points.Add(new DataPoint(2, 10) { AxisLabel = "Pilates" });
            series.Points.Add(new DataPoint(3, 25) { AxisLabel = "Zumba" });
            series.Points.Add(new DataPoint(4, 30) { AxisLabel = "Spinning" });
            series.IsValueShownAsLabel = true;
            chartRadarClases.Series.Add(series);
        }


        public void ConfigurarGraficoRadarInventario()
        {
            // Limpiamos todo para asegurarnos de que no hay datos viejos
            chartRadarInventario.Series.Clear();
            chartRadarInventario.Titles.Clear();
            chartRadarInventario.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.WhiteSmoke;
            chartRadarInventario.ChartAreas.Add(chartArea);
            chartRadarInventario.Titles.Add("Items por Categoría");
            chartRadarInventario.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            Series series = new Series("Cantidad");
            series.ChartType = SeriesChartType.Radar;
            series.BorderWidth = 3;
            series.Color = Color.SteelBlue;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#";
            series.IsVisibleInLegend = false;
            chartRadarInventario.Series.Add(series);

            try
            {
                // Obtenemos los datos dinámicos desde la base de datos
                var data = inventoryService.GetInventoryCountByCategory();

                if (data.Count == 0)
                {
                    // Si no hay datos, mostramos un mensaje en el gráfico
                    chartRadarInventario.Titles.Add("No hay datos de inventario para mostrar.");
                    return;
                }

                // Recorremos los datos y los agregamos a la serie del gráfico
                foreach (var item in data)
                {
                    series.Points.Add(new DataPoint(0, (double)item.Cantidad) { AxisLabel = item.Categoria });
                }

                // Ajustamos el máximo del eje Y dinámicamente para que se vea bien
                double maxValue = data.Max(item => (double)item.Cantidad);
                chartArea.AxisY.Maximum = maxValue + (maxValue * 0.1); // Añade un 10% de margen
                chartArea.AxisY.Interval = Math.Ceiling(maxValue / 5); // Calcula un intervalo razonable
            }
            catch (Exception ex)
            {
                // Si hay un error, lo capturamos
                MessageBox.Show("Error al cargar los datos del gráfico de inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chartRadarInventario.Titles.Add("Error al cargar datos");
            }
        }
    }
}