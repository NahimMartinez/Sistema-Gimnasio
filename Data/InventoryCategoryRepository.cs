using Dapper;
using Entities; 
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Data
{
    public class InventoryCategoryRepository
    {
        // Método para obtener TODAS las categorías para los ComboBox
        public List<InventoryCategory> GetAllCategories()
        {
            const string sql = "SELECT id_inventario_categoria AS IdInventarioCategoria, nombre AS Nombre FROM inventario_categoria;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                return cn.Query<InventoryCategory>(sql).ToList();
            }
        }

        // Método para insertar una nueva categoría
        public void InsertCategory(InventoryCategory category)
        {
            const string sql = "INSERT INTO inventario_categoria (nombre) VALUES (@Nombre);";

            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Execute(sql, category);
            }
        }
    }
}
