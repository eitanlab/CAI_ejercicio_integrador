using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        int _codigo;
        public Alumno(int codigoAlumno, string nombreAlumno, string apellidoAlumno, DateTime fechaNacAlumno)
        {
            _codigo = codigoAlumno;
            _nombre = nombreAlumno;
            _apellido = apellidoAlumno;
            _fechaNac = fechaNacAlumno;
        }
        public override string GetCredencial()
        {
            return "Código (" + _codigo + ") " + GetNombreCompleto();
        }
        public override string ToString()
        {
            return GetCredencial();
        }
        public int Codigo { 
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }
    }
}
