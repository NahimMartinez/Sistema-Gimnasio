using Dapper;
using Entities;
using System.Collections.Generic;
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

        public int Insert(Person p)
        {
            const string sql = @"
                INSERT INTO persona (nombre, apellido, dni, telefono, email, estado)
                VALUES (@Nombre, @Apellido, @Dni, @Telefono, @Email, 1);
                SELECT CAST(SCOPE_IDENTITY() AS int);";
            using (var cn = new SqlConnection(Connection.chain))
                return cn.Query<int>(sql, p).Single();
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
    }
}