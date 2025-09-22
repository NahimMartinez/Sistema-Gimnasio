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
        public string ConstraintName { get; }

        public DuplicateKeyException(Data.DuplicateField field, string constraintName, string message)
            : base(message)
        {
            Field = field;
            ConstraintName = constraintName;
        }
    }
}

