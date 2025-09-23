using Dapper;
using Data.Exceptions;
using Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data
{
    public class PersonRepository
    {
        public List<Person> GetAll()
        {
            const string sql = @"SELECT id_persona AS IdPersona, nombre, apellido, dni, telefono, email, estado
                                 FROM persona;";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.Query<Person>(sql).ToList();
        }

        public Person GetById(int id)
        {
            const string sql = @"SELECT id_persona AS IdPersona, nombre, apellido, dni, telefono, email, estado
                                 FROM persona WHERE id_persona = @Id;";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.QuerySingleOrDefault<Person>(sql, new { Id = id });
        }

        // Inserta una nueva persona y devuelve el Id generado
        // Para inserciones simples
        public int Insert(Person p)
        {
            const string sql = @"
            INSERT INTO persona (nombre, apellido, dni, telefono, email, estado)
            VALUES (@Nombre, @Apellido, @Dni, @Telefono, @Email, 1);
            SELECT CAST(SCOPE_IDENTITY() AS int);";

            using (var cn = new SqlConnection(Connection.chain))
            {
                try
                {
                    return cn.Query<int>(sql, p).Single();
                }
                catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
                {
                    var constraint = SqlExceptionUtils.GetConstraintName(ex);
                    var field = SqlExceptionUtils.MapConstraintToField(constraint);
                    switch (field)
                    {
                        case DuplicateField.Dni:
                            throw new DuplicateKeyException(field, constraint, "El DNI ya existe en el sistema.");
                        case DuplicateField.Email:
                            throw new DuplicateKeyException(field, constraint, "El email ya existe en el sistema.");
                        case DuplicateField.Telefono:
                            throw new DuplicateKeyException(field, constraint, "El teléfono ya existe en el sistema.");
                        default:
                            throw new DuplicateKeyException(field, constraint, "Ya existe un registro con un valor único duplicado.");
                    }
                }
            }
        }

        // Sobrecarga de Insert que acepta conexión y transacción externas
        // Para inserciones dentro de transacciones más grandes
        public int Insert(Person p, IDbConnection cn, IDbTransaction tr)
        {
            const string sql = @"
            INSERT INTO persona (nombre, apellido, dni, telefono, email, estado)
            VALUES (@Nombre, @Apellido, @Dni, @Telefono, @Email, 1);
            SELECT CAST(SCOPE_IDENTITY() AS int);";

            try
            {
                return cn.Query<int>(sql, p, tr).Single();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                var constraint = SqlExceptionUtils.GetConstraintName(ex);
                var field = SqlExceptionUtils.MapConstraintToField(constraint);
                switch (field)
                {
                    case DuplicateField.Dni:
                        throw new DuplicateKeyException(field, constraint, "El DNI ya existe en el sistema.");
                    case DuplicateField.Email:
                        throw new DuplicateKeyException(field, constraint, "El email ya existe en el sistema.");
                    case DuplicateField.Telefono:
                        throw new DuplicateKeyException(field, constraint, "El teléfono ya existe en el sistema.");
                    default:
                        throw new DuplicateKeyException(field, constraint, "Ya existe un registro con un valor único duplicado.");
                }
            }
        }

        public void Update(Person p)
        {
            const string sql = @"
            UPDATE persona
            SET nombre=@Nombre, apellido=@Apellido, dni=@Dni, telefono=@Telefono, email=@Email
            WHERE id_persona=@IdPersona;";
            using (var cn = new SqlConnection(Connection.chain))
                cn.Execute(sql, p);
        }

        public void BajaLogica(int idPersona)
        {
            const string sql = @"UPDATE persona SET estado = 0 WHERE id_persona = @Id;";
            using (var cn = new SqlConnection(Connection.chain))
                cn.Execute(sql, new { Id = idPersona });
        }

        public void Reactivar(int idPersona)
        {
            const string sql = @"UPDATE persona SET estado = 1 WHERE id_persona = @Id;";
            using (var cn = new SqlConnection(Connection.chain))
                cn.Execute(sql, new { Id = idPersona });
        }

        public bool ExistsDni(string dni, int excludeId)
        {
            const string sql = "SELECT COUNT(1) FROM persona WHERE dni = @Dni AND id_persona <> @ExcludeId";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.QuerySingle<int>(sql, new { Dni = dni, ExcludeId = excludeId }) > 0;
        }
        public bool ExistsEmail(string email, int excludeId)
        {
            const string sql = "SELECT COUNT(1) FROM persona WHERE email = @Email AND id_persona <> @ExcludeId";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.QuerySingle<int>(sql, new { Email = email, ExcludeId = excludeId }) > 0;
        }
        public bool ExistsTelefono(string telefono, int excludeId)
        {
            const string sql = "SELECT COUNT(1) FROM persona WHERE telefono = @Telefono AND id_persona <> @ExcludeId";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.QuerySingle<int>(sql, new { Telefono = telefono, ExcludeId = excludeId }) > 0;
        }
    }
}