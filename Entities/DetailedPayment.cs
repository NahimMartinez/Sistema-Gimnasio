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
        public int PagoId { get; set; }
        
        public int MembresiaId { get; set; }
        public int ClaseId { get; set; }
    }
}
