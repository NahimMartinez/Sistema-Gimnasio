using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DetailedPayment
    {
        public int IdDetalle { get; set; }
       
        public int IdPago { get; set; }
        public int IdMembresia { get; set; }
        public int IdClase { get; set; }
    }
}
