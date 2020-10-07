using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException() : base("El Empleado no existe") { }
    }
}
