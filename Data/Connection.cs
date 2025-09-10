using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Data
{
    public class Connection
    {
        public static string chain = ConfigurationManager.ConnectionStrings["chain_conecction"].ConnectionString;
    }
}
