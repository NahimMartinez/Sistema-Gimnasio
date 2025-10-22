using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Class
    {
        public int IdClase { get; set; }
        public int ActividadId { get; set; }
        public int UsuarioId { get; set; }     // ID del Coach/Profesor
        public TimeSpan HoraDesde { get; set; } // TimeSpan es el tipo para TIME de SQL
        public TimeSpan HoraHasta { get; set; }
        public decimal Precio { get; set; }
        public int Cupo { get; set; }
        public bool Estado { get; set; }

        public List<Day> Dias { get; set; } // Lista para guardar los días en que se da la clase

        public Class()
        {
            Dias = new List<Day>();
        }

        public Activity Actividad { get; set; }
    }
}
