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

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadInventoryDataIntoChart();
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

    }
}