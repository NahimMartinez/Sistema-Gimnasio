using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        public int IdPago { get; set; }
        public int IdSocio { get; set; }
        public int IdTipoPago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; } = true;

        public List<DetailedPayment> Detalles { get; set; } = new List<DetailedPayment>();

    }
}
