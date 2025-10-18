using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Dapper;
using System.Data.SqlClient;

namespace Data
{
    public class PartnerRepository
    {

        public void InsertPartner(int idPersona, Partner p, IDbConnection cn, IDbTransaction tr)
        {
            const string sql = @" 
                            INSERT INTO socio (id_socio, contacto_emergencia, observaciones)
                            VALUES (@IdPersona, @ContactoEmergencia, @Observaciones);";
            try
            {
                cn.Execute(sql, new { IdPersona = idPersona, p.ContactoEmergencia, p.Observaciones }, tr);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                var constraint = SqlExceptionUtils.GetConstraintName(ex);
                var field = SqlExceptionUtils.MapConstraintToField(constraint);
                throw new Data.Exceptions.DuplicateKeyException(field, constraint, "Ya existe ese socio.");
            }
        }

        public void UpdatePartner(Partner p)
        {
            const string sql = @"
                UPDATE socio
                SET contacto_emergencia=@ContactoEmergencia, observaciones=@Observaciones
                WHERE id_socio=@IdPersona;";
            using (var cn = new SqlConnection(Connection.chain))
                cn.Execute(sql, p);
        }

        public List<Partner> GetAllPartner()
        {
            const string sql = @"
                SELECT p.id_persona AS IdPersona, p.nombre AS Nombre, p.apellido AS Apellido, p.dni AS Dni, 
                       p.telefono AS Telefono, p.email AS Email, p.estado AS Estado,
                       s.contacto_emergencia AS ContactoEmergencia, s.observaciones AS Observaciones
                FROM persona p
                JOIN socio s ON p.id_persona = s.id_socio;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<Partner>(sql).ToList();
            }
        }

            public List<dynamic> GetRecentPartners()
            {
                const string sql = @"
                    SELECT TOP 10
                        p.nombre AS Nombre,
                        p.apellido AS Apellido,
                        t.nombre AS Membresia,
                        p.fecha_alta AS FechaIngreso
                    FROM
                        socio s
                    INNER JOIN
                        persona p ON p.id_persona = s.id_socio
                    INNER JOIN 
                        membresia m ON m.socio_id = s.id_socio
                    INNER JOIN
                        membresia_tipo t ON t.id_tipo = m.tipo_id
                    WHERE 
                        p.estado = 1
                    ORDER BY
                        p.fecha_alta DESC;";

                using (var cn = new SqlConnection(Connection.chain))
                {
                    return cn.Query<dynamic>(sql).ToList();
                }
        }

        public Partner GetByDni(string pDni)
        {
            const string sql = @"
                SELECT p.id_persona AS IdPersona, p.nombre AS Nombre, p.apellido AS Apellido, p.dni AS Dni, 
                       p.telefono AS Telefono, p.email AS Email,
                       s.contacto_emergencia AS ContactoEmergencia, s.observaciones AS Observaciones
                FROM persona p
                JOIN socio s ON s.id_socio = p.id_persona
                WHERE p.dni = @dni;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.QueryFirstOrDefault<Partner>(sql, new { dni = pDni });
            }
        }

        public int DisablePartner(string pDni)
        {
            const string sql = @"
                UPDATE persona
                SET estado = 0
                WHERE dni = @dni;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Execute(sql, new { dni = pDni });
            }
        }

        public int EnablePartner(string pDni)
        {
                       const string sql = @"
                UPDATE persona
                SET estado = 1
                WHERE dni = @dni;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Execute(sql, new { dni = pDni });
            }
        }

        public int GetTotalActivePartners()
        {
            const string sql = @"
            SELECT COUNT(*) 
            FROM socio s
            INNER JOIN persona p ON s.id_socio = p.id_persona
            WHERE p.estado = 1;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.ExecuteScalar<int>(sql);
            }
        }

        public List<dynamic> GetPartnerCountByMembershipType()
        {
            const string sql = @"
                SELECT
                    mt.nombre AS Membresia,
                    COUNT(s.id_socio) AS Cantidad
                FROM
                    socio s
                INNER JOIN
                    persona p ON s.id_socio = p.id_persona
                INNER JOIN
                    membresia m ON s.id_socio = m.socio_id
                INNER JOIN
                    membresia_tipo mt ON m.tipo_id = mt.id_tipo
                WHERE
                    p.estado = 1
                GROUP BY
                    mt.nombre;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<dynamic>(sql).ToList();
            }
        }
    }
}
