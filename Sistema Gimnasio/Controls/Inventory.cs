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

namespace Sistema_Gimnasio
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
            LoadFakeData();
        }

        private void BNewItem_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewItem = new AddItemForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewItem.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void LoadFakeData()
        {
            //nombre, cantidad, fecha ingreso, categoria, estado
            BoardInventory.Rows.Add("Mancuernas 10 kg", 2, "20/10/2025", "Mancuerna", "Activo");
            BoardInventory.Rows.Add("Colchoneta", 5, "15/09/2025", "Colchoneta", "Activo");
            BoardInventory.Rows.Add("Bicicleta Estatica", 1, "01/08/2025", "Cardio", "Inactivo");
            BoardInventory.Rows.Add("Balon Medicinal 5 kg", 3, "10/11/2025", "Balon Medicinal", "Activo");
            BoardInventory.Rows.Add("Cinta de Correr", 1, "05/07/2025", "Cardio", "Activo");
        }
    }
}
