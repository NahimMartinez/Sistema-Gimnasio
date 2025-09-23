using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class UserRepository
    {

        // crea entrada en usuario (persona ya insertada antes)
        public void InsertUser(int idPersona, User u)
        {
            const string sql = @"
        INSERT INTO usuario (id_usuario, username, [password], rol_id)
        VALUES (@IdPersona, @Username, @Password, @RolId);";

            using (var cn = new SqlConnection(Connection.chain))
            {
                // manejo de excepciones para claves duplicadas
                try
                {
                    cn.Execute(sql, new { IdPersona = idPersona, u.Username, u.Password, u.RolId });
                }
                catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
                {
                    var constraint = SqlExceptionUtils.GetConstraintName(ex);
                    var field = SqlExceptionUtils.MapConstraintToField(constraint);
                    if (field == DuplicateField.Username)
                        throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El nombre de usuario ya existe.");
                    // puede ser que la constraint apunte a persona (si tu FK está única). 
                    throw new Data.Exceptions.DuplicateKeyException(field, constraint, "Ya existe un valor único duplicado.");
                }
            }
        }

        // Sobrecarga de Insert que acepta conexión y transacción externas
        // Para inserciones dentro de transacciones más grandes (usuario + persona)
        public void InsertUser(int idPersona, User u, IDbConnection cn, IDbTransaction tr)
        {
            const string sql = @"
        INSERT INTO usuario (id_usuario, username, [password], rol_id)
        VALUES (@IdPersona, @Username, @Password, @RolId);";
            try
            {
                cn.Execute(sql, new { IdPersona = idPersona, u.Username, u.Password, u.RolId }, tr);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                var constraint = SqlExceptionUtils.GetConstraintName(ex);
                var field = SqlExceptionUtils.MapConstraintToField(constraint);
                if (field == DuplicateField.Username)
                    throw new Data.Exceptions.DuplicateKeyException(field, constraint, "El nombre de usuario ya existe.");
                throw new Data.Exceptions.DuplicateKeyException(field, constraint, "Ya existe un valor único duplicado.");
            }
        }


        // update solo de tabla usuario
        public void UpdateUser(User u)
        {
            const string sql = @"
            UPDATE usuario
            SET username=@Username, [password]=@Password, rol_id=@RolId
            WHERE id_usuario=@IdPersona;";

            using (var cn = new SqlConnection(Connection.chain))
            cn.Execute(sql, u);
        }

        public List<UserView> GetAllUsersView()
        {
            const string sql = @"
            SELECT 
                p.nombre AS Nombre,
                p.dni AS Dni,
                u.username AS Usuario,
                r.nombre AS Rol,
                CASE WHEN p.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Status
            FROM usuario u
            INNER JOIN persona p ON u.id_usuario = p.id_persona
            INNER JOIN rol r ON u.rol_id = r.id_rol;";

            using (var cn = new SqlConnection(Connection.chain))
                return cn.Query<UserView>(sql).ToList();
        }

        // recuperar usuario + persona + rol
        public User GetByUsernameActivo(string username)
        {
            const string sql = @"
            SELECT p.id_persona AS IdPersona, p.nombre, p.apellido, p.dni, p.telefono, p.email, p.estado,
                   u.username   AS Username, u.[password] AS [Password], u.rol_id AS RolId,
                   r.id_rol     AS IdRol, r.nombre AS Nombre
            FROM usuario u
            JOIN persona p ON p.id_persona = u.id_usuario
            JOIN rol r     ON r.id_rol = u.rol_id
            WHERE u.username = @Username AND p.estado = 1;";

            using (var cn = new SqlConnection(Connection.chain))
                //mapeo de dapper person, user, rol y user al final
                return cn.Query<Person, User, Rol, User>(
                sql,
                (p, u, r) => {
                    // copiar datos de persona a user
                    u.IdPersona = p.IdPersona;
                    u.Nombre = p.Nombre;
                    u.Apellido = p.Apellido;
                    u.Dni = p.Dni;
                    u.Telefono = p.Telefono;
                    u.Email = p.Email;
                    u.Estado = p.Estado;
                    u.Rol = r;
                    return u;
                },
                new { Username = username },
                splitOn: "Username,IdRol"//spliton indica donde empieza cada objeto
            ).SingleOrDefault();
        }
        // Recupera un usuario por DNI activo o inactivo
        public User GetByUser(string pDni)
        {
            const string sql = @"
                        SELECT p.id_persona AS IdPersona, p.nombre, p.apellido, p.dni, p.telefono, p.email, p.estado,
                               u.username   AS Username, u.[password] AS [Password], u.rol_id AS RolId,
                               r.id_rol     AS IdRol, r.nombre AS Nombre
                        FROM usuario u
                        JOIN persona p ON p.id_persona = u.id_usuario
                        JOIN rol r     ON r.id_rol = u.rol_id
                        WHERE p.dni = @Dni";

            using (var cn = new SqlConnection(Connection.chain))
                return cn.Query<Person, User, Rol, User>(
                    sql,
                    (p, u, r) => {
                        // copiar datos de persona a user
                        u.IdPersona = p.IdPersona;
                        u.Nombre = p.Nombre;
                        u.Apellido = p.Apellido;
                        u.Dni = p.Dni;
                        u.Telefono = p.Telefono;
                        u.Email = p.Email;
                        u.Estado = p.Estado;
                        u.Rol = r;
                        return u;
                    },
                    new { Dni = pDni },
                    splitOn: "Username,IdRol"
                ).SingleOrDefault();
        }

        public int DisableUser(string pDni)
        {
            const string sql = @"UPDATE p
                        SET p.estado = 0
                        FROM persona p
                        JOIN usuario u ON u.id_usuario = p.id_persona  
                        WHERE p.dni = @Dni AND p.estado = 1";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.Execute(sql, new { dni = pDni });
        }

        public int EnableUser(string pDni)
        {
            const string sql = @"UPDATE p                        
                        SET p.estado = 1
                        FROM persona p
                        JOIN usuario u ON u.id_usuario = p.id_persona  
                        WHERE p.dni = @Dni AND p.estado = 0;";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.Execute(sql, new { dni = pDni });
        }

        public bool ExistsUsername(string username, int excludeId)
        {
            const string sql = "SELECT COUNT(1) FROM usuario WHERE username = @Username AND id_usuario <> @ExcludeId";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.QuerySingle<int>(sql, new { Username = username, ExcludeId = excludeId }) > 0;
        }

    }
}

