using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Supplier
    {
        public int IdProveedor { get; set; }   // PK autoincremental
        public string Nombre { get; set; }        
        public long Cuit { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public String Estado { get; set; }     // true = activo, false = inactivo

        
    }
}
