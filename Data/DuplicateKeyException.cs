using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Exceptions
{
    public class DuplicateKeyException : Exception
    {
        public Data.DuplicateField Field { get; }
        // Nombre de la constraint que se violó
        public string ConstraintName { get; }

        // Constructor que recibe el campo duplicado, el nombre de la constraint y el mensaje
        public DuplicateKeyException(Data.DuplicateField field, string constraintName, string message)
            : base(message)
        {
            Field = field;
            ConstraintName = constraintName;
        }
    }
}

