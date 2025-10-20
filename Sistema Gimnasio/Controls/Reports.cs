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
            // Aplicamos el MISMO estilo a ambos gráficos PRIMERO.
            ApplyUnifiedChartStyle(chartRadarClases, "Cantidad de Alumnos por Clase", "Capacidad", "# ");
            ApplyUnifiedChartStyle(chartRadarInventario, "Items por Categoría", "Cantidad", "# ");

            // Cargamos los datos DESPUÉS de que los estilos están definidos.
            LoadClassDataIntoChart();
            LoadInventoryDataIntoChart();
        }

        // MÉTODO DE ESTILO UNIFICADO
        private void ApplyUnifiedChartStyle(Chart chart, string titleText, string seriesName, string labelFormat)
        {
            chart.ChartAreas.Clear();
            chart.Series.Clear();
            chart.Titles.Clear();

            ChartArea chartArea = new ChartArea("ChartArea1")
            {
                BackColor = Color.WhiteSmoke,
                ShadowColor = Color.LightGray,
                ShadowOffset = 2
            };

            chartArea.Position = new ElementPosition(0, 15, 100, 85);

            chartArea.InnerPlotPosition = new ElementPosition(10, 5, 80, 80);
            chartArea.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;

            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.ForeColor = Color.DarkSlateGray;
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Format = "#";

            chart.ChartAreas.Add(chartArea);

            Title title = new Title(titleText, Docking.Top, new Font("Segoe UI", 12F, FontStyle.Bold), Color.DarkSlateGray)
            {
                Position = new ElementPosition(5, 15, 90, 10)
            };
            chart.Titles.Add(title);

            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Radar,
                ChartArea = "ChartArea1",
                BackGradientStyle = GradientStyle.DiagonalRight,
                BorderWidth = 3,
                Color = Color.SteelBlue,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                IsValueShownAsLabel = true,
                IsVisibleInLegend = false,
                LabelBackColor = Color.SteelBlue,
                LabelForeColor = Color.White,
                LabelFormat = labelFormat,
                MarkerColor = Color.DarkBlue,
                MarkerSize = 8,
                MarkerStyle = MarkerStyle.Circle,
                ToolTip = "#AXISLABEL: #VAL"
            };
            chart.Series.Add(series);
        }

        private void LoadClassDataIntoChart()
        {
            Series series = chartRadarClases.Series["Capacidad"];
            series.Points.Clear();

            try
            {
                var data = classService.GetPartnerCountByClassService();
                if (data.Count == 0) { chartRadarClases.Titles.Add("No hay datos de clases."); return; }

                foreach (var item in data)
                {
                    series.Points.Add(new DataPoint(0, (double)item.CantidadSocios) { AxisLabel = item.Clase });
                }

                double maxValue = data.Max(item => (double)item.CantidadSocios);
                chartRadarClases.ChartAreas[0].AxisY.Maximum = maxValue + (maxValue * 0.2);
                chartRadarClases.ChartAreas[0].AxisY.Interval = Math.Ceiling(maxValue / 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico de socios por clase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInventoryDataIntoChart()
        {
            Series series = chartRadarInventario.Series["Cantidad"];
            series.Points.Clear();

            try
            {
                var data = inventoryService.GetInventoryCountByCategory();
                if (data.Count == 0) { chartRadarInventario.Titles.Add("No hay datos de inventario."); return; }

                foreach (var item in data)
                {
                    series.Points.Add(new DataPoint(0, (double)item.Cantidad) { AxisLabel = item.Categoria });
                }

                double maxValue = data.Max(item => (double)item.Cantidad);
                chartRadarInventario.ChartAreas[0].AxisY.Maximum = maxValue + (maxValue * 0.1);
                chartRadarInventario.ChartAreas[0].AxisY.Interval = Math.Ceiling(maxValue / 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico de inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}