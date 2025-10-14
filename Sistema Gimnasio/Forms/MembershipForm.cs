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
        private readonly List<Class> classMembership = new List<Class>();

        public MembershipForm(int pIdPartner)
        {
            InitializeComponent();
            LoadData();
            SetupActionIcons();
        }

        private void MembershipForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateTotalLabel()
        {
            decimal total = classMembership.Sum(c => c.Precio);
            LTotalSum.Text = total.ToString("0.00");
        }

        private void LoadData()
        {
            var data = classService.GetAllClassesForView();
            var classMembership = data.Select(c => new 
            {
                IdClase = c.IdClase,
                Name = c.NombreActividad,
                Cupo = c.Cupo.ToString(),
                Dia = c.Dias,
                Horario = c.Horario
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

                bool isCross = iconState.ContainsKey(e.RowIndex) && iconState[e.RowIndex];
                iconState[e.RowIndex] = !isCross;

                BoardClass.Rows[e.RowIndex].Cells["colAdd"].Value = isCross ? bmpCheck : bmpCross;
                BoardClass.Refresh();
            };
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (classMembership.Count == 0)
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
    }
}
