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
        
        public int InsertSupplier(Supplier supplier)
        {
            // validar antes de insertar
            if (ExistsTelefono(supplier.Telefono, supplier.IdProveedor))
                throw new Exception("El teléfono ya está registrado.");
            if (ExistsEmail(supplier.Email, supplier.IdProveedor))
                throw new Exception("El email ya está registrado.");
            if (ExistsCuit(supplier.Cuit, supplier.IdProveedor))
                throw new Exception("El CUIT ya está registrado.");

            const string sql = @"
                        INSERT INTO proveedor (nombre, cuit, email, telefono)
                        OUTPUT INSERTED.id_proveedor
                        VALUES (@Nombre, @Cuit, @Email, @Telefono);";
            try
            {
                using (var cn = new SqlConnection(Connection.chain))
                {
                    return cn.ExecuteScalar<int>(sql, supplier);
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
            // validar antes de insertar
            if (ExistsTelefono(supplier.Telefono, supplier.IdProveedor))
                throw new Exception("El teléfono ya está registrado.");
            if (ExistsEmail(supplier.Email, supplier.IdProveedor))
                throw new Exception("El email ya está registrado.");
            if (ExistsCuit(supplier.Cuit, supplier.IdProveedor))
                throw new Exception("El CUIT ya está registrado.");

            const string sql = @"
                        UPDATE proveedor
                        SET nombre = @Nombre,
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

        public long DisableSupplier(long c)
        {
            const string sql = @"
                        UPDATE proveedor SET estado = 0
                        WHERE cuit = @cuit;";
            using (var cn = new SqlConnection(Connection.chain))
            {
               return cn.Execute(sql, new { Cuit = c });
            }
        }

        public long EnableSupplier(long c)
        {
            const string sql = @"
                        UPDATE proveedor SET estado = 1
                        WHERE cuit = @cuit;";
            using (var cn = new SqlConnection(Connection.chain))
            {
               return cn.Execute(sql, new { Cuit = c });
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            const string sql = @"
                        SELECT id_proveedor AS IdProveedor,
                               nombre AS Nombre,
                               cuit AS Cuit,
                               email AS Email,
                               telefono AS Telefono,
                               CASE WHEN estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS estado
                        FROM proveedor;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<Supplier>(sql).ToList();
            }
        }

        public Supplier GetSupplierByCuit(long pCuit)
        {
            const string sql = @"
                        SELECT id_proveedor AS IdProveedor,
                               nombre AS Nombre,
                               cuit AS Cuit,
                               email AS Email,
                               telefono AS Telefono,
                               estado
                        FROM proveedor
                        WHERE cuit = @cuit;";
            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.QuerySingleOrDefault<Supplier>(sql, new { Cuit = pCuit });
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

        public bool ExistsTelefono(long telefono, int excludeId)
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
