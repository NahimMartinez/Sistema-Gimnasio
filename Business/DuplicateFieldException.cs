using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions
{
    public class DuplicateFieldException : Exception
    {
        public string FieldName { get; }

        public DuplicateFieldException(string fieldName, string message) : base(message)
        {
            FieldName = fieldName;
        }
    }
}

