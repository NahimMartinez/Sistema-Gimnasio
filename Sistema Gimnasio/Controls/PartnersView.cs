using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_Gimnasio.Form1;

namespace Sistema_Gimnasio
{
    
    
    public partial class PartnersView : UserControl
    {
        public Roles CurrentRole { get; set; } = Roles.None;

        private readonly Dictionary<DataGridViewColumn, Roles> Acl = new Dictionary<DataGridViewColumn, Roles>();
        public PartnersView()
        {
            InitializeComponent();
            this.Load += PartnersView_Load;            
            LoadFakeData();   // solo para prueba
            BoardMember.CellClick += BoardMember_CellClick;
        }

       

        private void BNewMember_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewMember = new AddMemberForm())
           {
                //muestro el formulario como un cuadro de dialogo
                if (fNewMember.ShowDialog() == DialogResult.OK)
                {
                    //aca tenemos que volver a cargar los datos cuando se guarde el nuevo proveedor(cuando sea dinamico)
                }
            }
        }
        private void BoardMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var id = BoardMember.Rows[e.RowIndex].Cells["dni"].Value; 
            var name = BoardMember.Rows[e.RowIndex].Cells["name"].Value;
            var col = BoardMember.Columns[e.ColumnIndex].Name;

            if (col == "colEdit")
            {
                MessageBox.Show($"Editar socio {name}");
            }
            else if (col == "colView")
            {
                MessageBox.Show($"Ver socio {name}");
            }
            else if (col == "colDelete")
            {
                MessageBox.Show($"Eliminar socio {name}");
            }
        }
        

        // Datos de prueba hardcodeados
        private void LoadFakeData()
        {
            BoardMember.Rows.Add("Juan Pérez", "12345678", "3794-111111", "Mensual", "Activo");
            BoardMember.Rows.Add("María López", "87654321", "3794-222222", "Semanal", "Inactivo");
            BoardMember.Rows.Add("Carlos Gómez", "45678912", "3794-333333", "Diaria", "Activo");
        }

        private void PartnersView_Load(object sender, EventArgs e)
        {
            BoardMember.AutoGenerateColumns = false;

            colEdit.DataPropertyName = null;
            colView.DataPropertyName = null;
            colDelete.DataPropertyName = null;

            Bitmap bmpEdit = IconChar.PenToSquare.ToBitmap(Color.Black, 30);
            Bitmap bmpView = IconChar.Eye.ToBitmap(Color.Black, 30);
            Bitmap bmpDelete = IconChar.Trash.ToBitmap(Color.Black, 30);

            colEdit.Image = bmpEdit;    // se usa cuando el valor es null
            colView.Image = bmpView;
            colDelete.Image = bmpDelete;

            // Forzar que cada celda use la imagen
            BoardMember.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex < 0) return;
                string col = BoardMember.Columns[ev.ColumnIndex].Name;

                if (col == "colEdit") { ev.Value = bmpEdit; ev.FormattingApplied = true; }
                if (col == "colView") { ev.Value = bmpView; ev.FormattingApplied = true; }
                if (col == "colDelete") { ev.Value = bmpDelete; ev.FormattingApplied = true; }
            };

            BuildAcl();
            ApplyAcl();
        }

        private void BuildAcl()
        {
            Acl[colEdit] = Roles.Admin | Roles.Recep;                          
            Acl[colDelete] = Roles.Admin | Roles.Recep;                          
            Acl[colView] = Roles.Admin | Roles.Recep | Roles.Coach; 
        }

        private void ApplyAcl()
        {
            foreach (var keyValue in Acl)
                keyValue.Key.Visible = (CurrentRole & keyValue.Value) != 0;
        }


    }
}
