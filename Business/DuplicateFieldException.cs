using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Aqui se define una excepción personalizada para manejar errores de campos duplicados
namespace Business.Exceptions
{
    public class DuplicateFieldException : Exception
    {
        public string FieldName { get; }

        // Constructor que recibe el nombre del campo duplicado y un mensaje de error
        public DuplicateFieldException(string fieldName, string message) : base(message)
        {
            FieldName = fieldName;
        }
    }
}

