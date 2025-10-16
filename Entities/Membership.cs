using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Membership
    {
        public int IdMembresia { get; set; }
        public int IdSocio { get; set; }
        public int IdTipo { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }

        public List<Class> Clases { get; set; } = new List<Class>();
    }
}
