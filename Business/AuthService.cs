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

        public User Login(string username, string password)
        {
            var u = user.GetByUsernameActivo(username);
            if (u == null) return null;

            
            if (u.Password != password) return null;

            return u;
        }
    }
}
