using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class PersonService
    {
        public readonly PersonRepository p = new PersonRepository();
        public bool ExistsDni(string pDni)
        {
            return p.ExistsDni(pDni);            
        }

        public bool ExistsEmail(string pEmail)
        {
            return p.ExistsEmail(pEmail);
        }

        public bool ExistsPhone(string pPhone)
        {
            return p.ExistsPhone(pPhone);
        }
    }


}
