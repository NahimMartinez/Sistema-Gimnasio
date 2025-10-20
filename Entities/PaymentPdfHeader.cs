using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PaymentPdfHeader
    {
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string SocioNombre { get; set; }
        public string SocioEmail { get; set; }
        public string Membresia { get; set; }
    }
}
