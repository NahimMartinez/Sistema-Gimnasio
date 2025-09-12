using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : Person
    {
        public int IdUsuario { get; set; }     // PK, también FK a Persona
        public string Username { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }         // FK a Rol
        public Rol Rol { get; set; }          // Propiedad de navegación a Rol

        
    }
}
