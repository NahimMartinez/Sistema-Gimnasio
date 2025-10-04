using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AuthService
    {
        private readonly UserRepository user = new UserRepository();

        // Retorna el usuario si las credenciales son correctas, sino null
        public User Login(string username, string password)
        {
            var u = user.GetByUsernameActivo(username);
            if (u == null) return null;

            var userService = new UserService();
            string hashedInput = userService.GetHashedPassword(password);

            // Caso 1: hash contra hash (usuario nuevo)
            if (u.Password == hashedInput)
                return u;

            // Caso 2: texto plano (usuario antiguo)
            if (u.Password == password)
            {
                // Actualizar a hash
                u.Password = hashedInput;
                var userService2 = new UserService();
                userService2.UpdateUser(u, true);
                return u;
            }

            // Caso 3: no coincide
            return null;
        }
    }
}
