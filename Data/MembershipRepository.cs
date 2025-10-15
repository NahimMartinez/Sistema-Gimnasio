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
    public class MembershipRepository
    {
        public List<MembershipType> GetMembershipType()
        {
            const string sql = @"
                        SELECT id_tipo   AS IdTipo,
                               nombre    AS Nombre,
                               duracion_dias AS DuracionDias
                        FROM membresia_tipo;";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.Query<MembershipType>(sql).ToList();
        }


    }
}
