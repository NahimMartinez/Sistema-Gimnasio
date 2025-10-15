using Business;
using Entities;
using FontAwesome.Sharp;
using Sistema_Gimnasio.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sistema_Gimnasio.Forms
{
    public partial class MembershipForm : Form
    {
        private readonly ClassService classService = new ClassService();
        private readonly List<dynamic> classMembership = new List<dynamic>();
        private readonly List<dynamic> selectedClasses = new List<dynamic>();
        private readonly MembershipService membershipService = new MembershipService();
        private readonly PaymentService paymentService = new PaymentService();
        private bool fReady;

        public MembershipForm(int pIdPartner)
        {
            InitializeComponent();
            LoadData();
            SetupActionIcons();
            this.Load += MembershipForm_Load;
        }

        private void MembershipForm_Load(object sender, EventArgs e)
        {
            LoadMembershipTypes();
            LoadPayMethods();
            CBMembership.SelectedIndexChanged += (s, ev) =>
            {
                if (fReady) UpdateTotalLabel();
            };
        }

        private decimal UpdateTotalLabel()
        {
            decimal total = 0m;
            var item = CBMembership.SelectedItem as MembershipType;
            foreach (var c in selectedClasses)
            {
                var price = c.Precio;
                if (price != null) total += Convert.ToDecimal(price);
            }
            int dias = item?.DuracionDias ?? 1;
            total = total * dias;
            LTotalSum.Text = total.ToString("0.00");
            return total;
        }

        private void LoadData()
        {
            var data = classService.GetAllClassesActive();
            var classMembership = data.Select(c => new 
            {
                IdClase = c.IdClase,
                Name = c.NombreActividad,
                Cupo = c.Cupo.ToString(),
                Dia = c.Dias,
                Horario = c.Horario,
                Precio = c.Precio.ToString("0.00"),
            }).ToList();
            
            BoardClass.AutoGenerateColumns = false;
            BoardClass.DataSource = classMembership;

        }

        private void SetupActionIcons()
        {
            
            Bitmap bmpCheck = IconChar.Check.ToBitmap(Color.Black, 30); // Icono de Aceptar/Tick.
            Bitmap bmpCross = IconChar.Times.ToBitmap(Color.Black, 30); // Icono de  Cancelar/Quitar X

            // Asigna los iconos a las columnas correspondientes.
            
            colAdd.Image = bmpCheck;
            var iconState = new Dictionary<int, bool>();

            BoardClass.CellFormatting += (s, e) => 
            {
                if (e.RowIndex < 0 || e.ColumnIndex != BoardClass.Columns["colAdd"].Index) return;
                bool isCross = iconState.ContainsKey(e.RowIndex) && iconState[e.RowIndex];
                e.Value = isCross ? bmpCross : bmpCheck;
                e.FormattingApplied = true;
                var row = BoardClass.Rows[e.RowIndex];
                row.Cells["colAdd"].Value = isCross ? bmpCheck : bmpCross;
                // cambia color según ícono
                if (isCross)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                }

                
            };

            BoardClass.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex != BoardClass.Columns["colAdd"].Index) return;

                bool isSelected = iconState.ContainsKey(e.RowIndex) && iconState[e.RowIndex];
                dynamic item = BoardClass.Rows[e.RowIndex].DataBoundItem;

                int id = (int)item.IdClase;
                if (!isSelected)
                {
                    if (!selectedClasses.Any(x => (int)x.IdClase == id))
                        selectedClasses.Add(item);
                }
                else
                {
                    var rem = selectedClasses.FirstOrDefault(x => (int)x.IdClase == id);
                    if (rem != null) selectedClasses.Remove(rem);
                }

                iconState[e.RowIndex] = !isSelected;
                BoardClass.InvalidateRow(e.RowIndex);
                UpdateTotalLabel();
            };
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (selectedClasses.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Se registro la membresia correctamente");
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadPayMethods()
        {
            var paymentMethods = paymentService.GetPaymentMethods();
            CBPayMethod.DataSource = null;              // limpia por si había Items
            CBPayMethod.DisplayMember = "Nombre";
            CBPayMethod.DataSource = paymentMethods;
            CBPayMethod.SelectedIndex = -1; // No seleccionar nada por defecto
        }
        private void LoadMembershipTypes()
        {
            fReady = false;
            var types = membershipService.GetMembershipType();
            CBMembership.DataSource = null;              // limpia por si había Items            
            CBMembership.DisplayMember = "Nombre";
            CBMembership.ValueMember = "DuracionDias";
            CBMembership.DataSource = types;
            CBMembership.SelectedIndex = 2; // Por defecto mes
            fReady = true;
        }
    }
}
