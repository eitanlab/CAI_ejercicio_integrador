using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CAI_ejercicio_integrador
{
    class Program
    {
        static void Main(string[] args)
        {

            string menuAMostrar =
            "[MENU DE OPCIONES]\n" +
            "\n1-Alta de Alumno" +
            "\n2-Modificación de Alumno" +
            "\n3-Baja de Alumno" +
            "\n4-Listar Alumnos" +
            "\n5-Alta de Empleado" +
            "\n6-Modificación de Empleado" +
            "\n7-Baja de Empleado" +
            "\n8-Listar Empleados\n";

            // Instancio el objeto base de la aplicacion
            Facultad fce = new Facultad("FCE");

            bool mostrarMenu = true;
            while (mostrarMenu)
            {
                Console.WriteLine(menuAMostrar);
                mostrarMenu = menu(fce);
            }
        }

        static bool menu(Facultad facultad)
        {
            string opcionElegida = ConsoleHelpers.PedirString("Ingrese una opción: ");
            switch (opcionElegida)
            {
                case "1":
                    Console.Clear();
                    altaAlumno(facultad);
                    return true;
                case "2":
                    Console.Clear();
                    ModificacionAlumno(facultad);
                    return true;
                case "3":
                    Console.Clear();
                    BajaAlumno(facultad);
                    return true;
                case "4":
                    Console.Clear();
                    ListarAlumnos(facultad);
                    return true;
                case "5":
                    Console.Clear();
                    return true;
                case "6":
                    Console.Clear();
                    return true;
                case "7":
                    Console.Clear();
                    return true;
                case "8":
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("El código ingresado no corresponde a una opción válida, intente nuevamente");
                    return true;
            }
        }
        static void altaAlumno(Facultad facultad)
        {
            Console.Clear();
            int codigoAlumno = ConsoleHelpers.PedirInt("código del alumno");
            if (codigoAlumno > 0)
            {
                string nombreAlumno = ConsoleHelpers.PedirString("nombre del alumno");
                if (nombreAlumno != "")
                {
                    string apellidoAlumno = ConsoleHelpers.PedirString("apellido del alumno");
                    if (apellidoAlumno != "")
                    {
                        DateTime fechaNacAlumno = ConsoleHelpers.PedirFecha("fecha de nacimiento del alumno");
                        if (fechaNacAlumno != null && fechaNacAlumno < DateTime.Today)
                        {
                            facultad.AgregarAlumno(codigoAlumno, nombreAlumno, apellidoAlumno, fechaNacAlumno);
                            Console.Clear();
                            Console.WriteLine("Alumno agregado con éxito\n");
                        } else
                        {
                            Console.WriteLine("La fecha de nacimiento ingresada es inválida");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El apellido ingresado es inválido");
                    }
                }
                else
                {
                    Console.WriteLine("El nombre ingresado es inválido");
                }
            } else
            {
                Console.WriteLine("El código de Alumno ingresado es inválido");
            }
            
        }
        static void BajaAlumno(Facultad facultad)
        {
            try
            {
                int codigo = ConsoleHelpers.PedirInt("código de alumno");
                facultad.EliminarAlumno(codigo);
                Console.WriteLine("El alumno fue eliminado");
            }
            catch (AlumnoExistenteException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        static void ModificacionAlumno(Facultad facultad)
        {
            try
            {
                int codigo = ConsoleHelpers.PedirInt("código de alumno");
                Alumno alumnoEncontrado = facultad.BuscarAlumno(codigo);
                string nombreAlumno = ConsoleHelpers.PedirString("nombre del alumno");
                string apellidoAlumno = ConsoleHelpers.PedirString("apellido del alumno");
                //DateTime fechaNacAlumno = ConsoleHelpers.PedirFecha("fecha de nacimiento del alumno");
                facultad.ModificarAlumno(codigo, nombreAlumno, apellidoAlumno);
                Console.WriteLine("El alumno " + codigo + " fue modificado");
            }
            catch (AlumnoExistenteException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("No se ha podido modificar el alumno: " + err.Message);
            }
        }
        static void ListarAlumnos(Facultad facultad)
        {
            if(facultad.Alumnos.Count > 0)
            {
                foreach (Alumno alumno in facultad.Alumnos)
                {
                    Console.WriteLine(alumno.ToString());
                }
            } else
            {
                Console.WriteLine(facultad.Nombre + " no tiene alumnos");
            }
        }
    }
}
