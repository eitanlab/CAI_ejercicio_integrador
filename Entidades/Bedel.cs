using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Bedel : Empleado
    {
        string _apodo;

        public Bedel(string apodo)
        {
            Apodo = apodo;
        }
        public string Apodo { 
            get
            {
                return _apodo;
            } 
            set
            {
                _apodo = value;
            }
        }
        public override string GetNombreCompleto()
        {
            return "Bedel " + Apodo;
        }
    }
}
