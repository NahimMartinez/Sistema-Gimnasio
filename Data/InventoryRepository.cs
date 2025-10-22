using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Entities;
using System;

namespace Data
{
    public class InventoryRepository
    {
        public List<dynamic> GetAllInventoriesForView()
        {
            // Consulta SQL
            const string sql = @"
                SELECT 
                    i.id_inventario                   AS IdInventario,
                    i.nombre                          AS Articulo,
                    ic.nombre                         AS Categoria,
                    i.cantidad                        AS Cantidad,
                    FORMAT(i.fecha_ingreso, 'dd/MM/yyyy') AS FechaIngreso,
                    p.nombre                          AS Proveedor,
                    i.estado                          AS Estado
                FROM 
                    inventario i
                INNER JOIN 
                    inventario_categoria ic ON i.id_categoria_inventario = ic.id_inventario_categoria
                LEFT JOIN
                    proveedor p ON i.proveedor_id = p.id_proveedor;
            ";

            using (var cn = new SqlConnection(Connection.chain))
            {
                // Dapper mapea el resultado a una lista de objetos dinámicos
                var inventarios = cn.Query<dynamic>(sql).ToList();
                return inventarios;
            }
        }

        public void InsertInventory(Inventory inventario)
        {
            const string sql = @"
                INSERT INTO inventario (id_categoria_inventario, nombre, cantidad, estado, proveedor_id)
                VALUES (@IdInventarioCategoria, @Nombre, @Cantidad, @Estado, @IdProveedor);
            ";
            // La fecha de ingreso se asigna automaticamente

            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Execute(sql, inventario);
            }
        }

        public Inventory GetById(int idInventario)
        {
            const string sql = @"
            SELECT 
                id_inventario AS IdInventario,
                id_categoria_inventario AS IdInventarioCategoria,
                nombre AS Nombre,
                cantidad AS Cantidad,
                fecha_ingreso AS FechaIngreso,
                estado AS Estado,
                proveedor_id AS IdProveedor
            FROM inventario 
            WHERE id_inventario = @IdInventario;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                // QuerySingleOrDefault devuelve un solo objeto o null si no lo encuentra
                return cn.QuerySingleOrDefault<Inventory>(sql, new { IdInventario = idInventario });
            }
        }

        // Método para actualizar un artículo existente
        public void Update(Inventory inventario)
        {
            const string sql = @"
            UPDATE inventario SET
                nombre = @Nombre,
                cantidad = @Cantidad,
                id_categoria_inventario = @IdInventarioCategoria,
                proveedor_id = @IdProveedor
                -- No actualizamos el estado aquí, eso se hará por separado
            WHERE id_inventario = @IdInventario;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Execute(sql, inventario);
            }
        }

        public void ChangeStatus(int idInventario)
        {
            // Esta consulta SQL invierte el valor del campo 'estado'.
            // Si es 1 (true), lo convierte en 0 (false), y viceversa.
            const string sql = @"
            UPDATE inventario 
            SET estado = CASE WHEN estado = 1 THEN 0 ELSE 1 END 
            WHERE id_inventario = @IdInventario;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Execute(sql, new { IdInventario = idInventario });
            }
        }

        public List<dynamic> GetInventoryCountByCategory()
        {
            const string sql = @"
            SELECT 
                ic.nombre AS Categoria, 
                COUNT(i.id_inventario) AS Cantidad
            FROM 
                inventario i
            INNER JOIN 
                inventario_categoria ic ON i.id_categoria_inventario = ic.id_inventario_categoria
            WHERE
                i.estado = 1 -- Contar solo los artículos activos
            GROUP BY 
                ic.nombre
            ORDER BY
                Cantidad DESC; -- Ordena de mayor a menor para que el gráfico se vea mejor";

            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<dynamic>(sql).ToList();
            }
        }
    }
}