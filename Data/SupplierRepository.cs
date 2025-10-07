using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public class SupplierRepository
    {
        public void InsertSupplier(Supplier supplier)
        {
            const string sql = @"
                        INSERT INTO proveedor (nombre, apellido, cuit, email, telefono)
                        VALUES (@Nombre, @Apellido, @Cuit, @Email, @Telefono);";
            try
            {
                using (var cn = new SqlConnection(Connection.chain))
                {
                    cn.Execute(sql, supplier);
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                var constraint = SqlExceptionUtils.GetConstraintName(ex);
                var field = SqlExceptionUtils.MapConstraintToField(constraint);
                switch (field)
                {
                    case DuplicateField.Cuit:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El CUIT ya existe.");
                    case DuplicateField.Email:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El email ya existe.");
                    case DuplicateField.Telefono:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El teléfono ya existe.");
                    default:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "Ya existe un valor único duplicado.");
                }
            }             
               
        }

        public void UpdateSupplier(Supplier supplier)
        {
            const string sql = @"
                        UPDATE proveedor
                        SET nombre = @Nombre,
                            apellido = @Apellido,
                            cuit = @Cuit,
                            email = @Email,
                            telefono = @Telefono,
                            estado = @Estado
                        WHERE id_proveedor = @IdProveedor;";
            try
            {
                using (var cn = new SqlConnection(Connection.chain))
                {
                    cn.Execute(sql, supplier);
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                var constraint = SqlExceptionUtils.GetConstraintName(ex);
                var field = SqlExceptionUtils.MapConstraintToField(constraint);
                switch (field)
                {
                    case DuplicateField.Cuit:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El CUIT ya existe.");
                    case DuplicateField.Email:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El email ya existe.");
                    case DuplicateField.Telefono:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El teléfono ya existe.");
                    default:
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "Ya existe un valor único duplicado.");
                }
            }
        }

        public void DisableSupplier(int supplierId)
        {
            const string sql = @"
                        UPDATE proveedor SET estado = 0
                        WHERE id_proveedor = @IdProveedor;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Execute(sql, new { IdProveedor = supplierId });
            }
        }

        public void EnableSupplier(int supplierId)
        {
            const string sql = @"
                        UPDATE proveedor SET estado = 1
                        WHERE id_proveedor = @IdProveedor;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Execute(sql, new { IdProveedor = supplierId });
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            const string sql = @"
                        SELECT id_proveedor AS IdProveedor,
                               nombre AS Nombre,
                               apellido AS Apellido,
                               cuit AS Cuit,
                               email AS Email,
                               telefono AS Telefono,
                               estado AS Estado
                        FROM proveedor;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<Supplier>(sql).ToList();
            }
        }

        public bool ExistsCuit(long cuit, int excludeId)
        {
            const string sql = "SELECT COUNT(1) FROM proveedor WHERE cuit = @Cuit AND id_proveedor <> @ExcludeId";
            using (var cn = new SqlConnection(Connection.chain))
            {
                int count = cn.QuerySingle<int>(sql, new { Cuit = cuit, ExcludeId = excludeId });
                return count > 0;
            }
        }

        public bool ExistsEmail(string email, int excludeId)
        {
            const string sql = "SELECT COUNT(1) FROM proveedor WHERE email = @Email AND id_proveedor <> @ExcludeId";
            using (var cn = new SqlConnection(Connection.chain))
            {
                int count = cn.QuerySingle<int>(sql, new { Email = email, ExcludeId = excludeId });
                return count > 0;
            }
        }

        public bool ExistsTelefono(int telefono, int excludeId)
        {
            const string sql = "SELECT COUNT(1) FROM proveedor WHERE telefono = @Telefono AND id_proveedor <> @ExcludeId";
            using (var cn = new SqlConnection(Connection.chain))
            {
                int count = cn.QuerySingle<int>(sql, new { Telefono = telefono, ExcludeId = excludeId });
                return count > 0;
            }
        }
    }

}
