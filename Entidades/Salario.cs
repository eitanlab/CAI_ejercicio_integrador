using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salario
    {
        double _bruto;
        string _codigoTransferencia;
        double _descuentos;
        DateTime _fecha;
        public Salario(double salarioBruto)
        {
            Bruto = salarioBruto;
        }
        public double Bruto
        {
            get
            {
                return _bruto;
            }
            set
            {
                _bruto = value;
            }
        }
        public string CodigoTransferencia
        {
            get
            {
                return _codigoTransferencia;
            }
            set
            {
                _codigoTransferencia = value;
            }
        }
        public double Descuentos
        {
            get
            {
                return _descuentos;
            }
            set
            {
                _descuentos = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
        public double GetSalarioNeto()
        {
            return 0;
        }
    }
}
