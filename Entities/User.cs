using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class User
    {
        public int IdUsuario { get; set; }     // PK, también FK a Persona
        public string Username { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }         // FK a Rol
    }
}
