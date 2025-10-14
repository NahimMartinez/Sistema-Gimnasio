using Business;
using Entities;
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
       
        public MembershipForm(int pIdPartner)
        {
            InitializeComponent();
            LoadDataFromService();
        }

        private void MembershipForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataFromService()
        {
            var data = classService.GetAllClassesForView();
            var classList = data.Select(c => new
            {
                IdClase = c.IdClase,
                Name = c.NombreActividad,
                Cupo = c.Cupo.ToString(),
                Dia = c.Dias,
                Horario = c.Horario
            }).ToList();

            BoardClass.AutoGenerateColumns = false;


        }
    }
}
