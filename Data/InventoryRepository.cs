using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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
                    i.estado                          AS Estado
                FROM 
                    inventario i
                INNER JOIN 
                    inventario_categoria ic ON i.id_categoria_inventario = ic.id_inventario_categoria;
            ";

            using (var cn = new SqlConnection(Connection.chain))
            {
                // Dapper mapea el resultado a una lista de objetos dinámicos
                var inventarios = cn.Query<dynamic>(sql).ToList();
                return inventarios;
            }
        }
    }
}