using Dapper;
using Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Data
{
    public class ActivityRepository
    {
        public List<Activity> GetAll()
        {
            const string sql = "SELECT id_actividad AS IdActividad, nombre AS Nombre FROM actividad";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<Activity>(sql).ToList();
            }
        }
    }
}