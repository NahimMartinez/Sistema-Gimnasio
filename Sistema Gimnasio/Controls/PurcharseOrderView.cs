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
    public partial class PurcharseOrderView : UserControl
    {
        public PurcharseOrderView()
        {
            InitializeComponent();
            SetupAcciones();
            LoadFakeData();   
        }

        private void SetupAcciones()
        {
            // Aseguramos una columna de ID oculta si no existe
            if (!BoardOrderP.Columns.Contains("IdOrdenInterno"))
                BoardOrderP.Columns.Insert(0, new DataGridViewTextBoxColumn
                {
                    Name = "IdOrdenInterno",
                    Visible = false
                });

            // Si la columna Actions no está definida en el Designer, la creamos
            if (!BoardOrderP.Columns.Contains("Actions"))
                BoardOrderP.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Actions",
                    HeaderText = "Acciones",
                    ReadOnly = true
                });

            // Enganchamos la clase ActionColumn
            var acciones = new ActionColumn(BoardOrderP, "IdOrdenInterno", "Actions");
            acciones.OnEdit += id => MessageBox.Show($"Editar orden {id}");
            acciones.OnView += id => MessageBox.Show($"Ver orden {id}");
            acciones.OnDelete += id => MessageBox.Show($"Borrar orden {id}");
        }

        private void LoadFakeData()
        {
            // El orden debe coincidir con tus columnas: 
            // IdOrdenInterno, Id_Orden, Supplier, Date, Status, Actions
            BoardOrderP.Rows.Add(1, "ORD-001", "Proveedor A", DateTime.Now.AddDays(-3).ToShortDateString(), "Pendiente", null);
            BoardOrderP.Rows.Add(2, "ORD-002", "Proveedor B", DateTime.Now.AddDays(-1).ToShortDateString(), "Recibida", null);
            BoardOrderP.Rows.Add(3, "ORD-003", "Proveedor C", DateTime.Now.ToShortDateString(), "Cancelada", null);
        }
    }

    
}
