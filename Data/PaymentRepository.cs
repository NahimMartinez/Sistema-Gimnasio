using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Data
{
    public class PaymentRepository
    {
        public List<PaymentMethod> GetPaymentMethods()
        {
            const string sql = @"
                        SELECT id_tipo_pago AS IdTipoPago,
                               nombre          AS Nombre
                        FROM tipo_pago;"; 
            using (var cn = new SqlConnection(Connection.chain))
                return cn.Query<PaymentMethod>(sql).ToList();
        }
    }
}
