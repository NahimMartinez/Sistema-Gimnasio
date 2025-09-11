using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    public partial class PartnersView : UserControl
    {
        public PartnersView()
        {
            InitializeComponent();
            SetupAcciones();
            LoadFakeData();   // solo para prueba
        }

       

        private void BNewMember_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewMember = new AddMemberForm())
           {
                //muestro el formulario como un cuadro de dialogo
                if (fNewMember.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        private void SetupAcciones()
        {
            // Insertar columna de Id oculta si no está
            if (!BoardMember.Columns.Contains("IdPersona"))
                BoardMember.Columns.Insert(0, new DataGridViewTextBoxColumn
                {
                    Name = "IdPersona",
                    Visible = false
                });

            // Si ya existe "Actions" en el Designer no se duplica
            if (!BoardMember.Columns.Contains("Actions"))
                BoardMember.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Actions",
                    HeaderText = "Acciones",
                    ReadOnly = true
                });

            // Enlazar helper reutilizable
            var acciones = new ActionColumn(BoardMember, "IdPersona", "Actions");
            acciones.OnEdit += id => MessageBox.Show($"Editar {id}");
            acciones.OnView += id => MessageBox.Show($"Ver {id}");
            acciones.OnDelete += id => MessageBox.Show($"Borrar {id}");
        }

        // Datos de prueba hardcodeados
        private void LoadFakeData()
        {
            BoardMember.Rows.Add(1, "Juan Pérez", "12345678", "3794-111111", "Mensual", "Activo", null);
            BoardMember.Rows.Add(2, "María López", "87654321", "3794-222222", "Semanal", "Inactivo", null);
            BoardMember.Rows.Add(3, "Carlos Gómez", "45678912", "3794-333333", "Diaria", "Activo", null);
        }

       


    }
}
