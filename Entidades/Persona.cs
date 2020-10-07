using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string _apellido;
        protected DateTime _fechaNac;
        protected string _nombre;
        public string Apellido {
            get {
                return _apellido;
            }
            set {
                _apellido = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNac;
            }
            set
            {
                _fechaNac = value;
            }
        }
        public int Edad
        {
            get
            {
                var hoy = DateTime.Today;
                var edadCalculada = hoy.Year - _fechaNac.Year;
                return edadCalculada; 
            }
        }
        public abstract string GetCredencial();
        public virtual string GetNombreCompleto()
        {
            return string.Format("{0}, {1}", this._apellido, this._nombre);
        }

    }
}
