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
    public partial class Reports : UserControl
    {
        private TableLayoutPanel tableLayout;

        public Reports()
        {
            InitializeComponent();
            InicializarLayout();                // << Nuevo método para armar layout
            ConfigurarGraficoRadarCapacidad();  // Para chartRadarClases
            ConfigurarGraficoRadarInventario(); // Para chartRadarInventario
        }

        private void InicializarLayout()
        {
            // Crear el TableLayoutPanel
            tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.ColumnCount = 2;
            tableLayout.RowCount = 1;

            // Configurar 50% de ancho para cada gráfico
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Quitar cualquier cosa que venga por defecto
            this.Controls.Clear();

            // Agregar los charts al layout
            chartRadarClases.Dock = DockStyle.Fill;
            chartRadarInventario.Dock = DockStyle.Fill;

            tableLayout.Controls.Add(chartRadarClases, 0, 0);
            tableLayout.Controls.Add(chartRadarInventario, 1, 0);

            // Agregar el layout al UserControl
            this.Controls.Add(tableLayout);
        }

        public void ConfigurarGraficoRadarCapacidad()
        {
            chartRadarClases.Series.Clear();
            chartRadarClases.Titles.Clear();
            chartRadarClases.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.Area3DStyle.Enable3D = false;
            chartArea.Position = new ElementPosition(0, 0, 100, 100);

            chartRadarClases.ChartAreas.Add(chartArea);

            chartRadarClases.Titles.Add("Cantidad de alumnos por clase");
            chartRadarClases.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartRadarClases.Titles[0].ForeColor = Color.DarkSlateGray;
            chartRadarClases.Titles[0].Docking = Docking.Top;
            chartRadarClases.Titles[0].IsDockedInsideChartArea = false;

            Series series = new Series("Capacidad");
            series.ChartType = SeriesChartType.Radar;
            series.BorderWidth = 3;
            series.Color = Color.SteelBlue;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.DarkBlue;
            series.BackGradientStyle = GradientStyle.DiagonalRight;

            series.Points.Add(new DataPoint(0, 20) { AxisLabel = "Crossfit" });
            series.Points.Add(new DataPoint(1, 15) { AxisLabel = "Yoga" });
            series.Points.Add(new DataPoint(2, 10) { AxisLabel = "Pilates" });
            series.Points.Add(new DataPoint(3, 25) { AxisLabel = "Zumba" });
            series.Points.Add(new DataPoint(4, 30) { AxisLabel = "Spinning" });

            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;
            series.LabelBackColor = Color.SteelBlue;
            series.LabelFormat = "# alumnos";

            chartRadarClases.Series.Add(series);

            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.ForeColor = Color.DarkSlateGray;
            chartArea.AxisY.LabelStyle.Format = "#";
            chartArea.AxisY.Maximum = 35;
            chartArea.AxisY.Interval = 5;

            chartRadarClases.ChartAreas[0].InnerPlotPosition = new ElementPosition(8, 8, 80, 80);

            chartArea.BackColor = Color.WhiteSmoke;
            chartArea.ShadowColor = Color.LightGray;
            chartArea.ShadowOffset = 2;

            series.IsVisibleInLegend = false;
        }

        public void ConfigurarGraficoRadarInventario()
        {
            chartRadarInventario.Series.Clear();
            chartRadarInventario.Titles.Clear();
            chartRadarInventario.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.Area3DStyle.Enable3D = false;
            chartArea.Position = new ElementPosition(0, 0, 100, 100);

            chartArea.BackColor = Color.WhiteSmoke;
            chartArea.ShadowColor = Color.LightGray;
            chartArea.ShadowOffset = 2;

            chartRadarInventario.ChartAreas.Add(chartArea);

            chartRadarInventario.Titles.Add("Items por Categoría");
            chartRadarInventario.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartRadarInventario.Titles[0].ForeColor = Color.DarkSlateGray;
            chartRadarInventario.Titles[0].Docking = Docking.Top;
            chartRadarInventario.Titles[0].IsDockedInsideChartArea = false;

            Series series = new Series("Cantidad");
            series.ChartType = SeriesChartType.Radar;
            series.BorderWidth = 3;
            series.Color = Color.SteelBlue;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.DarkBlue;
            series.BackGradientStyle = GradientStyle.DiagonalRight;

            series.Points.Add(new DataPoint(0, 20) { AxisLabel = "Pesas" });
            series.Points.Add(new DataPoint(1, 15) { AxisLabel = "Yoga" });
            series.Points.Add(new DataPoint(2, 40) { AxisLabel = "Cardio" });
            series.Points.Add(new DataPoint(3, 25) { AxisLabel = "Rehabilitación" });

            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;
            series.LabelBackColor = Color.SteelBlue;
            series.LabelFormat = "# items";
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series.ToolTip = "#AXISLABEL: #VAL items";

            chartRadarInventario.Series.Add(series);

            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.ForeColor = Color.DarkSlateGray;
            chartArea.AxisX.LabelStyle.Angle = 0;

            chartArea.AxisY.LabelStyle.Format = "#";
            chartArea.AxisY.Maximum = 50;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Interval = 10;
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            chartRadarInventario.ChartAreas[0].InnerPlotPosition = new ElementPosition(0, 0, 95, 95);

            series.IsVisibleInLegend = false;
        }
    }
}
