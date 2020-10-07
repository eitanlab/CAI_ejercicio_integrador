using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ListadoAlumnosException : Exception
    {
        public ListadoAlumnosException() : base("No se encontraron alumnos") { }
    }
}
