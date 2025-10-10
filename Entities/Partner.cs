using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Partner : Person
    {
        public long ContactoEmergencia { get; set; }
        public string Observaciones { get; set; }
    }
}
