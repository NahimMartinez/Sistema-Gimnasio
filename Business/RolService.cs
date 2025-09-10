using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RolService
    {
        private RolRepository rol;

        public RolService()
        {
            rol = new RolRepository();
        }
        public List<Entities.Rol> GetAll()
        {
            return rol.GetAll();
        }

    }
}
