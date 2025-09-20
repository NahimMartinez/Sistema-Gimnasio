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
        public Reports()
        {
            InitializeComponent();
            ConfigurarGraficoRadarCapacidad();    // Para chartRadarClases
            ConfigurarGraficoRadarInventario();   // Para chartRadarInventario
        }

        public void ConfigurarGraficoRadarCapacidad()
        {
            // Limpiar gráfico existente - AHORA USA chartRadarClases
            chartRadarClases.Series.Clear();
            chartRadarClases.Titles.Clear();
            chartRadarClases.ChartAreas.Clear();

            // Configurar área del gráfico
            ChartArea chartArea = new ChartArea();
            chartArea.Area3DStyle.Enable3D = false;

            // ⭐⭐ ESTA LÍNEA ES CLAVE ⭐⭐
            chartArea.Position = new ElementPosition(0, 0, 100, 100);

            chartRadarClases.ChartAreas.Add(chartArea);

            // Título del gráfico
            chartRadarClases.Titles.Add("Cantidad de alumnos por clase");
            chartRadarClases.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartRadarClases.Titles[0].ForeColor = Color.DarkSlateGray;

            // Crear serie para el radar
            Series series = new Series("Capacidad");
            series.ChartType = SeriesChartType.Radar;
            series.BorderWidth = 3;
            series.Color = Color.SteelBlue;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.DarkBlue;
            series.BackGradientStyle = GradientStyle.DiagonalRight;

            // Agregar datos de capacidad de cada clase
            series.Points.Add(new DataPoint(0, 20) { AxisLabel = "Crossfit" });
            series.Points.Add(new DataPoint(1, 15) { AxisLabel = "Yoga" });
            series.Points.Add(new DataPoint(2, 10) { AxisLabel = "Pilates" });
            series.Points.Add(new DataPoint(3, 25) { AxisLabel = "Zumba" });
            series.Points.Add(new DataPoint(4, 30) { AxisLabel = "Spinning" });

            // Personalizar la serie
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;
            series.LabelBackColor = Color.SteelBlue;
            series.LabelFormat = "# alumnos";

            // Agregar serie al gráfico
            chartRadarClases.Series.Add(series);

            // Configurar ejes y apariencia
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.ForeColor = Color.DarkSlateGray;
            chartArea.AxisY.LabelStyle.Format = "#";
            chartArea.AxisY.Maximum = 35;
            chartArea.AxisY.Interval = 5;

            // Estilo visual profesional
            chartArea.BackColor = Color.WhiteSmoke;
            chartArea.ShadowColor = Color.LightGray;
            chartArea.ShadowOffset = 2;

            series.IsVisibleInLegend = false;
        }

        public void ConfigurarGraficoRadarInventario()
        {
            // Limpiar gráfico existente - AHORA USA chartRadarInventario
            chartRadarInventario.Series.Clear();
            chartRadarInventario.Titles.Clear();
            chartRadarInventario.ChartAreas.Clear();

            // Configurar área del gráfico (EXACTAMENTE IGUAL)
            ChartArea chartArea = new ChartArea();
            chartArea.Area3DStyle.Enable3D = false;

            // ⭐⭐ MISMA POSICIÓN QUE EL OTRO GRÁFICO ⭐⭐
            chartArea.Position = new ElementPosition(0, 0, 100, 100);

            // MISMA CONFIGURACIÓN VISUAL
            chartArea.BackColor = Color.WhiteSmoke;
            chartArea.ShadowColor = Color.LightGray;
            chartArea.ShadowOffset = 2;

            chartRadarInventario.ChartAreas.Add(chartArea);

            // Título del gráfico (EXACTAMENTE IGUAL)
            chartRadarInventario.Titles.Add("Items por Categoría");
            chartRadarInventario.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartRadarInventario.Titles[0].ForeColor = Color.DarkSlateGray;

            // Crear serie para el radar (EXACTAMENTE IGUAL)
            Series series = new Series("Cantidad");
            series.ChartType = SeriesChartType.Radar;
            series.BorderWidth = 3;
            series.Color = Color.SteelBlue;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.MarkerColor = Color.DarkBlue;
            series.BackGradientStyle = GradientStyle.DiagonalRight;

            // Agregar datos de cantidad por categoría
            series.Points.Add(new DataPoint(0, 20) { AxisLabel = "Pesas" });
            series.Points.Add(new DataPoint(1, 15) { AxisLabel = "Yoga" });
            series.Points.Add(new DataPoint(2, 40) { AxisLabel = "Cardio" });
            series.Points.Add(new DataPoint(3, 25) { AxisLabel = "Rehabilitación" });

            // Personalizar la serie (EXACTAMENTE IGUAL)
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White;
            series.LabelBackColor = Color.SteelBlue;
            series.LabelFormat = "# items";
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series.ToolTip = "#AXISLABEL: #VAL items";

            // Agregar serie al gráfico
            chartRadarInventario.Series.Add(series);

            // Configurar ejes y apariencia (EXACTAMENTE IGUAL)
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chartArea.AxisX.LabelStyle.ForeColor = Color.DarkSlateGray;
            chartArea.AxisX.LabelStyle.Angle = 0;

            chartArea.AxisY.LabelStyle.Format = "#";
            chartArea.AxisY.Maximum = 50;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Interval = 10;
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            series.IsVisibleInLegend = false;
        }
    }
}