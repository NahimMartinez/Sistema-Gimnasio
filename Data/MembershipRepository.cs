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

        // Trae todas las membresías con su tipo y clases asociadas
        public List<dynamic> GetAllMembershipsForView()
        {
            const string sql = @"
                SELECT
                    m.id_membresia AS IdMembresia,
                    tm.nombre AS Tipo,
                    s.nombre AS NombreSocio,
                    s.apellido AS ApellidoSocio,
                    m.fecha_inicio AS FechaInicio,
                    m.estado AS Estado
                FROM membresia m
                INNER JOIN tipo_membresia tm ON m.tipo_membresia_id = tm.id_tipo_membresia
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

        public void Insert(Membership membership, IDbConnection connection, IDbTransaction transaction)
        {
            const string sqlMembresia = @"
                INSERT INTO membresia (socio_id, tipo_membresia_id, fecha_inicio, fecha_fin, estado)
                OUTPUT INSERTED.id_membresia
                VALUES (@SocioId, @TipoMembresiaId, @FechaInicio, @FechaFin, @Estado);";

            int newMembershipId = connection.ExecuteScalar<int>(sqlMembresia, membership, transaction);

            const string sqlMembClase = "INSERT INTO membresia_clase (membresia_id, clase_id) VALUES (@MembresiaId, @ClaseId);";
            foreach (var c in membership.Clases)
            {
                connection.Execute(sqlMembClase, new { MembresiaId = newMembershipId, ClaseId = c.IdClase }, transaction);
            }
        }

        public Membership GetById(int idMembresia)
        {
            const string sql = @"
                SELECT id_membresia AS IdMembresia, socio_id AS SocioId, tipo_membresia_id AS TipoMembresiaId,
                       fecha_inicio AS FechaInicio, fecha_fin AS FechaFin, estado AS Estado
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

        public void Update(Membership membership, IDbConnection connection, IDbTransaction transaction)
        {
            const string sqlUpdate = @"
                UPDATE membresia SET
                    socio_id = @SocioId,
                    tipo_membresia_id = @TipoMembresiaId,
                    fecha_inicio = @FechaInicio,
                    fecha_fin = @FechaFin,
                    estado = @Estado
                WHERE id_membresia = @IdMembresia;";

            connection.Execute(sqlUpdate, membership, transaction);

            const string sqlDelete = "DELETE FROM membresia_clase WHERE membresia_id = @IdMembresia;";
            connection.Execute(sqlDelete, new { membership.IdMembresia }, transaction);

            const string sqlInsertClase = "INSERT INTO membresia_clase (membresia_id, clase_id) VALUES (@MembresiaId, @ClaseId);";
            foreach (var c in membership.Clases)
            {
                connection.Execute(sqlInsertClase, new { MembresiaId = membership.IdMembresia, ClaseId = c.IdClase }, transaction);
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


    }
}
