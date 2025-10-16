using Dapper;
using Entities;
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
    }
}
