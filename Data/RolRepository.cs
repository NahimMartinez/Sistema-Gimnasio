using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Data
{
    public class RolRepository
    {
        public List<Rol> GetAll()
        {
            const string sql = "SELECT id_rol AS IdRol, nombre FROM rol";
            using (var cn = new SqlConnection(Connection.chain))
            return cn.Query<Rol>(sql).ToList();
        }
    }
}
