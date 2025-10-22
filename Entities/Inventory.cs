using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Inventory
    {
        public int IdInventario { get; set; }
        public int IdInventarioCategoria { get; set; }
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public InventoryCategory InventarioCategoria { get; set; }
    }
}
