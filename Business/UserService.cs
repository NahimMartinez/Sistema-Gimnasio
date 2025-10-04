using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Data;
using Entities;

namespace Business
{
    public class UserService
    {
        private readonly PersonRepository persons = new PersonRepository();
        private readonly UserRepository users = new UserRepository();
        private UserRepository userRepo;

        public UserService()
        {
            userRepo = new UserRepository();
        }

        // Hash simple (SHA256)
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Verificar contraseña
        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }

        // Crea persona y usuario con contraseña hasheada
        public int UserCreate(Person pPerson, User pUser)
        {
            using (var cn = new SqlConnection(Connection.chain))
            {
                cn.Open();
                using (var tr = cn.BeginTransaction())
                {
                    try
                    {
                        // HASHEAR LA CONTRASEÑA
                        string hashedPassword = HashPassword(pUser.Password);
                        pUser.Password = hashedPassword;

                        var idPersona = persons.Insert(pPerson, cn, tr);
                        users.InsertUser(idPersona, pUser, cn, tr);

                        tr.Commit();
                        return idPersona;
                    }
                    catch (Data.Exceptions.DuplicateKeyException dex)
                    {
                        tr.Rollback();
                        throw new Business.Exceptions.DuplicateFieldException(dex.Field.ToString(), dex.Message);
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("No se pudo crear el usuario", ex);
                    }
                }
            }
        }

        // Método para actualizar usuario completo (incluyendo contraseña si es necesario)
        public void UpdateUser(User user, bool passwordChanged = false)
        {
            try
            {
                // Si la contraseña cambió, hashearla
                if (passwordChanged)
                {
                    user.Password = HashPassword(user.Password);
                }

                userRepo.UpdateUser(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario", ex);
            }
        }

        // Método para verificar credenciales
        public bool VerifyCredentials(string username, string password)
        {
            try
            {
                var user = userRepo.GetByUsernameActivo(username);
                if (user == null)
                    return false;

                return VerifyPassword(password, user.Password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar credenciales", ex);
            }
        }

        public List<UserView> GetAllUsersForView()
        {
            return userRepo.GetAllUsersView();
        }

        public string GetHashedPassword(string password)
        {
            return HashPassword(password);
        }
    }
}