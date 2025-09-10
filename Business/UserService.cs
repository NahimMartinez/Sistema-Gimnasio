using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;


namespace Business
{
    public class UserService
    {

        private readonly PersonRepository persons = new PersonRepository();
        private readonly UserRepository users = new UserRepository();

        public int PersonCreate(Person p)
        {
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        var idPersona = persons.Insert(p);
                        tr.Commit();
                        return idPersona;
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("No se pudo crear la persona", ex);
                    }
                }
            }
        }

        public int UserCreate(Person pPerson, User pUser) {
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        // insertar persona
                        var idPersona = PersonCreate(pPerson);
                        // insertar usuario
                        users.InsertUser(idPersona, pUser);
                        tr.Commit();
                        return idPersona;
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("No se pudo crear el usuario", ex);
                    }
                }
            }
        }
    }
}
