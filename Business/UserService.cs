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
        private UserRepository userRepo;

        public UserService() {
            userRepo = new UserRepository();
        }

        // Crea solo la persona
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

        // Crea persona y usuario en una transacción
        public int UserCreate(Person pPerson, User pUser)
        {
            using (var cn = new SqlConnection(Connection.chain))
            {
                // Abrir conexión
                cn.Open();
                // Iniciar una transacción
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        // Usar la sobrecarga con conexión+transacción
                        var idPersona = persons.Insert(pPerson, cn, tr);
                        users.InsertUser(idPersona, pUser, cn, tr);

                        tr.Commit();
                        return idPersona;
                    }
                    // Si hay un error de clave duplicada, hacer rollback y lanzar excepción específica
                    catch (Data.Exceptions.DuplicateKeyException dex)
                    {
                        tr.Rollback();
                        throw new Business.Exceptions.DuplicateFieldException(dex.Field.ToString(), dex.Message);
                    }
                    // Si hay cualquier otro error, hacer rollback y lanzar excepción genérica
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("No se pudo crear el usuario", ex);
                    }
                }
            }
        }

        public List<UserView> GetAllUsersForView()
        {
            return userRepo.GetAllUsersView();
        }
    }
}
