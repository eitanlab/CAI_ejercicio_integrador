using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Facultad
    {
        List<Alumno> _alumnos;
        int _cantidadSedes;
        List<Empleado> _empleados;
        string _nombre;

        public Facultad(string nombreFacultad)
        {
            Nombre = nombreFacultad;
            Alumnos = new List<Alumno>();
            Empleados = new List<Empleado>();
        }
        public int CantidadSedes
        {
            get
            {
                return _cantidadSedes;
            }
            set
            {
                _cantidadSedes = value;
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
        public List<Alumno> Alumnos
        {
            get
            {
                return _alumnos;
            }
            set
            {
                _alumnos = value;
            }
        }
        public List<Empleado> Empleados
        {
            get
            {
                return _empleados;
            }
            set
            {
                _empleados = value;
            }
        }
        public Alumno BuscarAlumno(int codigo)
        {
            Alumno alumnoEncontrado = Alumnos.Find(alumno => alumno.Codigo == codigo);
            if (alumnoEncontrado != null)
            {
                return alumnoEncontrado;
            }
            else
            {
                throw new AlumnoExistenteException();
            }
        }
        public void AgregarAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }
        public void AgregarAlumno(int codigoAlumno, string nombreAlumno, string apellidoAlumno, DateTime fechaNacAlumno)
        {
            Alumno alumnoAAgregar = new Alumno(codigoAlumno, nombreAlumno, apellidoAlumno, fechaNacAlumno);
            Alumnos.Add(alumnoAAgregar);
        }
        public void ModificarAlumno(int codigo, string nombre, string apellido)
        {
            Alumno alumno = this.BuscarAlumno(codigo);
            if (nombre != "")
            {
                alumno.Nombre = nombre;
            }
            if (apellido != "")
            {
                alumno.Apellido = apellido;
            }
            //if (fechaNac.Date != null)
            //{
            //    alumno.FechaNacimiento = fechaNac;
            //}
        }

        public void EliminarAlumno(int codigoAlumno)
        {
            Alumno alumnoEncontrado = BuscarAlumno(codigoAlumno);
            if (alumnoEncontrado != null)
            {
                Alumnos.Remove(alumnoEncontrado);
            }
            else
            {
                throw new AlumnoExistenteException();
            }
        }
        public List<Alumno> TraerAlumnos()
        {
            return Alumnos;
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        public void EliminarEmpleado(int legajoEmpleado)
        {
            foreach (Empleado empleado in Empleados)
            {
                if (empleado.Legajo == legajoEmpleado)
                {
                    Empleados.Remove(empleado);
                }
            }
        }
        public void ModificarEmpleado(Empleado empleado)
        {
            //Modifica empleado
        }
        public List<Empleado> TraerEmpleados()
        {
            return Empleados;
        }
        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            //Retorna un empleado en base a su numero de legajo
            Empleado empleadoEncontrado = Empleados.Find(empleado => empleado.Legajo == legajo);
            if (empleadoEncontrado == null)
            {
                throw new EmpleadoExistenteException();
            }
            return empleadoEncontrado;
        }
    }
    //public List<Empleado> TraerEmpleadosPorNombre(string nombre)
    //{
    //    //Retorna un listado de Empleados filtrado por el nombre recibido
    //}

}
