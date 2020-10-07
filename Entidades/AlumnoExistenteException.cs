using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoExistenteException : Exception
    {
        public AlumnoExistenteException() : base("El Alumno no existe") {}
    }
}
