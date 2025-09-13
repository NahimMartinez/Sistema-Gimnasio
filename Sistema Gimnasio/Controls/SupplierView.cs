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
    public partial class SupplierView : UserControl
    {
        public SupplierView()
        {
            InitializeComponent();
            LoadFakeData();  
        }

        private void SupplierView_Load(object sender, EventArgs e)
        {

        }

        private void BNewSupplier_Click(object sender, EventArgs e)
        {
            //creo una instancia del formulario
            using (var fNewSupllier = new AddSupplierForm())
            {
                //muestro el formulario como un cuadro de dialogo
                if (fNewSupllier.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

          

        private void LoadFakeData()
        {
            
            // IdSupplier, name, cuit, typeSupplier, email, phone, status, Actions
            BoardSupplier.Rows.Add(1, "Proveedor A", "20-12345678-9", "Servicios", "proveedorA@mail.com", "3794-111111", "Activo", null);
            BoardSupplier.Rows.Add(2, "Proveedor B", "23-87654321-0", "Insumos", "proveedorB@mail.com", "3794-222222", "Inactivo", null);
            BoardSupplier.Rows.Add(3, "Proveedor C", "27-11223344-5", "Equipos", "proveedorC@mail.com", "3794-333333", "Activo", null);
        }
    }
    
}
