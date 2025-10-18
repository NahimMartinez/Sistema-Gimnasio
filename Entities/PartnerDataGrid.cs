using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PartnerDataGrid : Person
    {
        public string Membresia { get; set; }
        public bool EstadoMembresia { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
