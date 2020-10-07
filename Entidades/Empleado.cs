using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empleado : Persona
    {
         DateTime _fechaIngreso;
         int _legajo;
         List<Salario> _salarios;
        public int antiguedad
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int antiguedadcalculada = hoy.Year - FechaIngreso.Year;
                return antiguedadcalculada;
            }
        }
        public DateTime FechaIngreso
        {
            get
            {
                return _fechaIngreso;
            }
            set
            {
                _fechaIngreso = value;
            }
        }
        public int Legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                _legajo = value;
            }
        }
        public List<Salario> Salarios
        {
            get
            {
                return _salarios;
            }
            set
            {
                _salarios = value;
            }
        }
        public Salario UltimoSalario
        {
            get
            {
                return _salarios[_salarios.Count - 1];
            }
        }
        public void AgregarSalario(Salario salario)
        {
            Salarios.Add(salario);
        }
        //public override bool Equals(object objeto)
        //{
        //    return false;
        //}
        public override string GetCredencial()
        {
            return Legajo + " - " + GetNombreCompleto() + " salario $" + UltimoSalario;
        }
        public override string GetNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }
        public override string ToString()
        {
            return null;
        }
    }
}
