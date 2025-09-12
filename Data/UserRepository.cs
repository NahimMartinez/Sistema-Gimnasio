using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Entities;


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
            cn.Execute(sql, new { IdPersona = idPersona, u.Username, u.Password, u.RolId });
        }

        // update solo de tabla usuario
        public void UpdateUser(User u)
        {
            const string sql = @"
            UPDATE usuario
            SET username=@Username, [password]=@Password, rol_id=@RolId
            WHERE id_usuario=@IdUsuario;";

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
                splitOn: "Username,IdRol"
            ).SingleOrDefault();
        }
    }
}

