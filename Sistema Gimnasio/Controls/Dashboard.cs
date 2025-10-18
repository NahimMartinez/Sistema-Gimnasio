using Business;
using Sistema_Gimnasio.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private readonly PaymentService paymentService = new PaymentService();

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

            decimal totalRevenue = paymentService.GetTotalGeneratedService();
            labelRevenueAmount.Text = "$ " + totalRevenue;
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
            try
            {
                var ingresosData = paymentService.GetTotalXMonthService();

                // Creamos un diccionario para los 12 meses, inicializados en 0.
                var ingresosPorMes = new Dictionary<int, decimal>();
                for (int i = 1; i <= 12; i++)
                {
                    ingresosPorMes.Add(i, 0m);
                }

                // Rellenamos el diccionario con los datos reales.
                foreach (var ingreso in ingresosData)
                {
                    ingresosPorMes[(int)ingreso.Mes] = (decimal)ingreso.Total;
                }

                // Limpiamos y preparamos el gráfico.
                chartIngresosMensuales.Series.Clear();
                Series serie = new Series("Ingresos")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.FromArgb(65, 105, 225),
                    IsValueShownAsLabel = false
                };
                chartIngresosMensuales.Series.Add(serie);

                // Agregamos los 12 puntos al gráfico.
                foreach (var mesData in ingresosPorMes)
                {
                    // Obtenemos el nombre abreviado del mes (Ene, Feb, etc.)
                    string nombreMes = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mesData.Key);
                    // Agregamos el punto al gráfico, dividiendo por 1000 para mostrar en miles.
                    serie.Points.AddXY(nombreMes, mesData.Value / 1000);
                }

                chartIngresosMensuales.ChartAreas[0].AxisY.Title = "Miles de $";
                chartIngresosMensuales.ChartAreas[0].AxisX.Title = "Meses";
                chartIngresosMensuales.ChartAreas[0].AxisY.LabelStyle.Format = "{0}k";
                chartIngresosMensuales.Series[0].SetCustomProperty("PixelPointWidth", "20");
                chartIngresosMensuales.Legends.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico de ingresos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadCPMemberships()
        {
            try
            {
                var data = partnerService.GetPartnerCountByMembershipTypeService();

                // Limpiamos el gráfico.
                CPMemberships.Series.Clear();
                CPMemberships.Titles.Clear();
                CPMemberships.Legends.Clear();

                // Creamos la serie para el gráfico Pie.
                Series serie = new Series(" ")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true, // Muestra el número en cada porción.
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    LabelForeColor = Color.White,
                    // Formato: "Nombre (Porcentaje%)"
                    Label = "#AXISLABEL (#PERCENT{P0})"
                };

                // Agregamos los datos de la base de datos a la serie.
                foreach (var item in data)
                {
                    serie.Points.AddXY(item.Membresia, item.Cantidad);
                }

                // Añadimos la serie al gráfico.
                CPMemberships.Series.Add(serie);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico de membresías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
   