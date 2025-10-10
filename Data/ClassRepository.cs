using Dapper;
using Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Data
{
    public class ClassRepository
    {
        // El método devuelve una lista de objetos dinámicos
        public List<dynamic> GetAllClassesForView()
        {
            // consulta SQL
            const string sql = @"
                SELECT
                    c.id_clase AS IdClase,
                    a.nombre AS NombreActividad,
                    p.nombre AS NombreCoach,
                    c.cupo AS Cupo,
                    FORMAT(c.hora_desde, 'hh\:mm') + ' - ' + FORMAT(c.hora_hasta, 'hh\:mm') AS Horario,
                    c.estado AS Estado
                FROM clase c
                INNER JOIN actividad a ON c.actividad_id = a.id_actividad
                INNER JOIN usuario u ON c.usuario_id = u.id_usuario
                INNER JOIN persona p ON u.id_usuario = p.id_persona;
            ";

            using (var cn = new SqlConnection(Connection.chain))
            {
                // Dapper mapea el resultado a una lista de objetos dinámicos
                var classes = cn.Query<dynamic>(sql).ToList();

                // Ahora, para cada objeto dinámico, le agregamos la propiedad 'Dias'
                foreach (var cls in classes)
                {
                    const string sqlDias = "SELECT d.nombre FROM clase_dia cd " +
                                           "INNER JOIN dia d ON cd.dia_id = d.id_dia " +
                                           "WHERE cd.clase_id = @IdClase";

                    var diasList = cn.Query<string>(sqlDias, new { IdClase = cls.IdClase }).ToList();

                    // Creamos el string "Lunes, Martes, etc."
                    // y lo asignamos a una nueva propiedad 'Dias' en nuestro objeto dinámico
                    ((IDictionary<string, object>)cls)["Dias"] = string.Join(", ", diasList);
                }
                return classes;
            }
        }

        public void InsertClass(Class clase, IDbConnection connection, IDbTransaction transaction)
        {
            // 1. Insertar en la tabla 'clase' y obtener el ID de la nueva fila
            const string sqlClase = @"
            INSERT INTO clase (actividad_id, usuario_id, hora_desde, hora_hasta, precio, cupo, estado)
            OUTPUT INSERTED.id_clase
            VALUES (@ActividadId, @UsuarioId, @HoraDesde, @HoraHasta, @Precio, @Cupo, @Estado);";

            int newClassId = connection.ExecuteScalar<int>(sqlClase, clase, transaction);

            // 2. Insertar en la tabla de unión 'clase_dia' por cada día seleccionado
            const string sqlClaseDia = "INSERT INTO clase_dia (clase_id, dia_id) VALUES (@ClaseId, @DiaId);";
            foreach (var dia in clase.Dias)
            {
                connection.Execute(sqlClaseDia, new { ClaseId = newClassId, DiaId = dia.IdDia }, transaction);
            }
        }

        public void ChangeStatus(int classId)
        {
            const string sql = @"
            UPDATE clase 
            SET estado = CASE WHEN estado = 1 THEN 0 ELSE 1 END 
            WHERE id_clase = @IdClase;";

            using (var cn = new SqlConnection(Connection.chain))
            {
                // El nombre del parámetro (@IdClase) que coincide con el objeto
                cn.Execute(sql, new { IdClase = classId });
            }
        }
    }
}