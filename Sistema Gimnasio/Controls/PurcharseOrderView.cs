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
            
            LoadFakeData();   
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
