using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ListadoEmpleadosException : Exception
    {
        public ListadoEmpleadosException() : base("No se encontraron empleados") { }
    }
}
