using Business;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistema_Gimnasio.Controls
{
    public partial class Dashboard : UserControl
    {
        private readonly ClassService classService = new ClassService();
        private readonly PartnerService partnerService = new PartnerService();

        public Dashboard()
        {
            InitializeComponent();
            LoadRecentPartnersGrid();
            LoadIngresosMensuales();
            LoadCPMemberships();
            Dashboard_Load();

            int totalClasses = classService.GetTotalActiveClasses();
            labelClassesCount.Text = totalClasses.ToString();

            int totalPartners = partnerService.GetTotalActivePartnersService();
            labelPartnersCount.Text = totalPartners.ToString();
        }

        private void LoadRecentPartnersGrid()
        {
            try
            {
                var recentPartnersRaw = partnerService.GetRecentPartnersService();

                // Proyectamos los datos dinámicos a nuestro ViewModel limpio.
                var recentPartnersView = recentPartnersRaw.Select(p => new RecentPartnerViewModel
                {
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Membresia = p.Membresia,
                    FechaIngreso = ((DateTime)p.FechaIngreso).ToString("dd/MM/yyyy") // Convertimos la fecha a un formato legible
                }).ToList();

                // Asignamos la lista limpia al DataSource.
                BoardRecent.DataSource = recentPartnersView;
                BoardRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los socios recientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BoardClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadIngresosMensuales()
        {
            // Configurar el gráfico            
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
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = false;

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

            // Formato de números en los ejes
            chartIngresosMensuales.ChartAreas[0].AxisY.LabelStyle.Format = "{0}k";

            // Ajustar el ancho de las barras
            chartIngresosMensuales.Series[0].SetCustomProperty("PixelPointWidth", "15");
        }



        private void LoadCPMemberships()
        {
            // Limpiar series existentes
            CPMemberships.Series.Clear();

            // Crear nueva serie tipo Pie
            Series serie = new Series("Socios por membresía");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;

            // Hardcodear datos: cantidad de socios por membresía
            serie.Points.AddXY("Diario", 20);
            serie.Points.AddXY("Semanal", 49);
            serie.Points.AddXY("Mensual", 213);

            // Colores personalizados
            serie.Points[0].Color = Color.FromArgb(65, 105, 225); // Azul
            serie.Points[1].Color = Color.FromArgb(60, 179, 113); // Verde
            serie.Points[2].Color = Color.FromArgb(255, 165, 0); // Naranja

            // Agregar serie al chart
            CPMemberships.Series.Add(serie);

            // Opcional: título del gráfico
            CPMemberships.Titles.Clear();
        }


        private void Dashboard_Load()
        {
            iconPartner.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            iconClass.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            iconIncome.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
        }

        private void BBackup_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewItem = new BackupForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        // ViewModel para mostrar socios recientes
        public class RecentPartnerViewModel
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Membresia { get; set; }
            [DisplayName("Fecha de Ingreso")]
            public string FechaIngreso { get; set; }
        }
    }
}
   