using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_ejercicio_integrador
{
    public static class ConsoleHelpers
    {
        public static string PedirString(string datoAPedir)
        {
            Console.WriteLine("Ingrese " + datoAPedir);
            return Console.ReadLine();
        }
        public static int PedirInt(string datoAPedir)
        {
            Console.WriteLine("Ingrese " + datoAPedir);
            int intRecibido = Convert.ToInt32(Console.ReadLine());
            return intRecibido;
        }
        public static double PedirDouble(string datoAPedir)
        {
            Console.WriteLine("Ingrese " + datoAPedir);
            double doubleRecibido = Convert.ToDouble(Console.ReadLine());
            return doubleRecibido;
        }
        public static DateTime PedirFecha(string datoAPedir)
        {
            Console.WriteLine("Ingrese fecha " + datoAPedir + " en formato DD-MM-YYYY");

            DateTime fecha = DateTime.Parse(Console.ReadLine());
            //DateTime fecha = Convert.ToDateTime(Console.ReadLine());
            return fecha;
        }
    }
}
