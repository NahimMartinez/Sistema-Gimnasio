using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Data
{
    public class PaymentRepository
    {
        public List<PaymentMethod> GetPaymentMethods()
        {
            const string sql = @"
                        SELECT id_tipo_pago AS IdMetodoPago,
                               nombre          AS Nombre
                        FROM tipo_pago;"; 
            using (var cn = new SqlConnection(Connection.chain))
                return cn.Query<PaymentMethod>(sql).ToList();
        }

        public int Insert(Payment payment)
        {
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())

                    try
                    {
                        var id = Insert(payment, cn, tx);
                        tx.Commit();
                        return id;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
            }
        }

        public int Insert(Payment payment, IDbConnection connection, IDbTransaction transaction)
        {
            const string sqlPago = @"
                INSERT INTO pago (socio_id, tipo_pago_id, fecha, total, estado)
                OUTPUT INSERTED.id_pago
                VALUES (@IdSocio, @IdTipoPago, @Fecha, @Total, @Estado);";

            if (payment.Fecha == default) payment.Fecha = System.DateTime.Now;

            int newId = connection.ExecuteScalar<int>(sqlPago, new
            {
                payment.IdSocio,
                payment.IdTipoPago,
                payment.Fecha,
                payment.Total,
                payment.Estado
            }, transaction);

            const string sqlDet = @"
                INSERT INTO pago_detalle (pago_id, membresia_id, clase_id)
                VALUES (@IdPago, @IdMembresia, @IdClase);";

            foreach (var d in payment.Detalles)
            {
                connection.Execute(sqlDet, new
                {
                    IdPago = newId,
                    d.IdMembresia,
                    d.IdClase
                }, transaction);
            }

            return newId;
        }

        public decimal GetTotalGenerated() 
        { 
            const string sql = @"
                            SELECT
                                SUM(total)
                            FROM
                                pago";
            using (var cn = new SqlConnection(Connection.chain)) 
            {
                return cn.ExecuteScalar<decimal>(sql);
            }
        }

        public List<dynamic> GetTotalXMonth()
        {
            const string sql = @"
                SELECT
                    MONTH(fecha) AS Mes,
                    SUM(total) AS Total
                FROM
                    pago
                WHERE 
                    YEAR(fecha) = YEAR(GETDATE())
                GROUP BY
                    MONTH(fecha)
                ORDER BY
                    Mes;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<dynamic>(sql).ToList();
            }
        }

        
        public (PaymentPdfHeader header, List<PaymentPdfDetail> details) GetReceipt(int pagoId)
        {
            const string Sql = @"
                        SELECT  p.id_pago AS PagoId, p.fecha, p.total,
                                CONCAT(per.nombre,' ',per.apellido) AS SocioNombre,
                                per.email AS SocioEmail,
                                MAX(mt.nombre) AS Membresia
                        FROM pago p
                        JOIN socio s           ON s.id_socio     = p.socio_id
                        JOIN persona per       ON per.id_persona = s.id_socio
                        LEFT JOIN pago_detalle pd ON pd.pago_id  = p.id_pago
                        LEFT JOIN membresia m      ON m.id_membresia = pd.membresia_id
                        LEFT JOIN membresia_tipo mt ON mt.id_tipo    = m.tipo_id
                        WHERE p.id_pago = @pagoId
                        GROUP BY p.id_pago, p.fecha, p.total, per.nombre, per.apellido, per.email;

                        SELECT  a.nombre AS ClaseNombre,
                                c.precio AS Monto
                        FROM pago_detalle pd
                        JOIN clase c      ON c.id_clase      = pd.clase_id
                        JOIN actividad a  ON a.id_actividad  = c.actividad_id
                        WHERE pd.pago_id = @pagoId;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var multi = cn.QueryMultiple(Sql, new { pagoId }))
                {
                    var header = multi.ReadSingleOrDefault<PaymentPdfHeader>();
                    if (header == null) throw new InvalidOperationException($"Pago #{pagoId} no encontrado.");

                    var details = multi.Read<PaymentPdfDetail>().ToList();
                    return (header, details);
                }
            }
        }

        public int GetLastPaymentPartner(int pPartner)
        {
            const string sql = @"
                        SELECT TOP 1 p.id_pago
                        FROM pago p
                        INNER JOIN socio s ON s.id_socio = p.socio_id
                        WHERE s.id_socio = @pPartner
                        ORDER BY p.fecha DESC, p.id_pago DESC;";

            using (var cn = new SqlConnection(Connection.chain))
                return cn.QueryFirstOrDefault<int>(sql, new { pPartner });
        }
    }
}
