using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool InactiveMembership(int socioId)
        {
            const string sql = @"
                SELECT TOP 1 estado
                FROM membresia
                WHERE socio_id = @IdSocio
                ORDER BY fecha_inicio DESC;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                int estado = cn.QuerySingle<int>(sql, new { IdSocio = socioId });
                return estado == 0;
            }
        }

        // Trae todas las membresías con su tipo y clases asociadas
        public List<dynamic> GetAllMembershipsForView()
        {
            const string sql = @"
                SELECT
                    m.id_membresia AS IdMembresia,
                    tm.nombre AS Tipo,
                    s.nombre AS Nombre,
                    s.apellido AS ApellidoSocio,
                    m.fecha_inicio AS FechaInicio,
                    m.estado AS Estado
                FROM membresia m
                INNER JOIN tipo_membresia tm ON m.tipo_id = tm.id_tipo
                INNER JOIN socio s ON m.socio_id = s.id_socio;
            ";

            using (var cn = new SqlConnection(Connection.chain))
            {
                var memberships = cn.Query<dynamic>(sql).ToList();

                foreach (var memb in memberships)
                {
                    const string sqlClases = @"
                        SELECT a.nombre 
                        FROM membresia_clase mc
                        INNER JOIN clase c ON mc.clase_id = c.id_clase
                        INNER JOIN actividad a ON c.actividad_id = a.id_actividad
                        WHERE mc.membresia_id = @IdMembresia";

                    var clasesList = cn.Query<string>(sqlClases, new { IdMembresia = memb.IdMembresia }).ToList();
                    ((IDictionary<string, object>)memb)["Clases"] = string.Join(", ", clasesList);
                }

                return memberships;
            }
        }

        public int Insert(Membership membership, IDbConnection connection, IDbTransaction transaction)
        {
            const string sqlMembresia = @"
                INSERT INTO membresia (socio_id, usuario_id, tipo_id, fecha_inicio, estado)
                OUTPUT INSERTED.id_membresia
                VALUES (@IdSocio, @IdUsuario ,@IdTipo, @FechaInicio, @Estado);";

            int newMembershipId = connection.ExecuteScalar<int>(sqlMembresia, membership, transaction);

            const string sqlMembClase = "INSERT INTO membresia_clase (membresia_id, clase_id) VALUES (@IdMembresia, @IdClase);";
            foreach (var c in membership.Clases)
            {
                connection.Execute(sqlMembClase, new { IdMembresia = newMembershipId, IdClase = c.IdClase }, transaction);
            }
            return newMembershipId; 
        }

        public Membership GetById(int idMembresia)
        {
            const string sql = @"
                SELECT id_membresia AS IdMembresia, socio_id AS IdSocio, tipo_id AS IdTipo,
                       fecha_inicio AS FechaInicio, estado AS Estado
                FROM membresia
                WHERE id_membresia = @IdMembresia;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                var memb = cn.QuerySingleOrDefault<Membership>(sql, new { IdMembresia = idMembresia });

                if (memb != null)
                {
                    const string sqlClases = "SELECT clase_id AS IdClase FROM membresia_clase WHERE membresia_id = @IdMembresia;";
                    var clasesIds = cn.Query<int>(sqlClases, new { IdMembresia = idMembresia }).ToList();
                    memb.Clases = clasesIds.Select(id => new Class { IdClase = id }).ToList();
                }
                return memb;
            }
        }

        public void Update(Membership membership, IDbConnection cn, IDbTransaction tr)
        {
            const string sqlUpdate = @"
                UPDATE membresia SET
                    socio_id = @IdSocio,
                    tipo_id = @IdTipo,
                    fecha_inicio = @FechaInicio,                    
                    estado = @Estado
                WHERE id_membresia = @IdMembresia;";

            cn.Execute(sqlUpdate, membership, tr);

            const string sqlDelete = "DELETE FROM membresia_clase WHERE membresia_id = @IdMembresia;";
            cn.Execute(sqlDelete, new { membership.IdMembresia }, tr);

            const string sqlInsertClase = "INSERT INTO membresia_clase (membresia_id, clase_id) VALUES (@IdMembresia, @IdClase);";
            foreach (var c in membership.Clases)
            {
                cn.Execute(sqlInsertClase, new { IdMembresia = membership.IdMembresia, IdClase = c.IdClase }, tr);
            }
        }

        public void ChangeStatus(int idMembresia)
        {
            const string sql = @"
                UPDATE membresia
                SET estado = CASE WHEN estado = 1 THEN 0 ELSE 1 END
                WHERE id_membresia = @IdMembresia;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Execute(sql, new { IdMembresia = idMembresia });
            }
        }

        public int GetTotalActiveMemberships()
        {
            const string sql = "SELECT COUNT(*) FROM membresia WHERE estado = 1;";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.ExecuteScalar<int>(sql);
        }

        public List<int> DesactiveMembership(IDbConnection cn, IDbTransaction tx)
        {
            // Obtenemos los ids de todas las membresías que vencieron hoy o antes
            // y que todavía figuran como activas (estado = 1).
            const string sqlExpiredIds = @"
                        SELECT m.id_membresia 
                        FROM membresia m
                        INNER JOIN membresia_tipo mt ON m.tipo_id = mt.id_tipo
                        WHERE m.estado = 1 
                            AND DATEADD(day, mt.duracion_dias, m.fecha_inicio) < @Today";

            var expiredMembershipIds = cn.Query<int>(sqlExpiredIds, new { Today = DateTime.Now.Date }, tx).ToList();

            // Si no hay ninguna vencida, devolvemos una lista vacia
            if (!expiredMembershipIds.Any())
            {
                return new List<int>();
            }

            // Obtenemos los id de las clases asociadas a las membresías vencidas
            const string sqlClassIds = @"
                        SELECT clase_id 
                        FROM membresia_clase 
                        WHERE membresia_id IN @Ids";

            var classIdsToRelease = cn.Query<int>(sqlClassIds, new { Ids = expiredMembershipIds }, tx).ToList();

            // Desactivar las membresías vencidas
            const string sqlDeactivate = @"
                        UPDATE membresia 
                        SET estado = 0 
                        WHERE id_membresia IN @Ids";

            cn.Execute(sqlDeactivate, new { Ids = expiredMembershipIds }, tx);

            // Devolvemos los id de las clases 
            return classIdsToRelease;
        }

        public List<int> GetActiveClassesByPartner(int partnerId)
        {
            const string sql = @"
        SELECT DISTINCT c.id_clase
        FROM membresia m
        JOIN membresia_clase mc ON mc.membresia_id = m.id_membresia
        JOIN clase c ON c.id_clase = mc.clase_id
        WHERE m.socio_id = @partnerId
          AND m.estado = 1;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<int>(sql, new { partnerId }).ToList();
            }
        }

    }
}
