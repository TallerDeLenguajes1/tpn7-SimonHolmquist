using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public char Operador { get; set; }

        public Calculadora()
        {
            Numero1 = -1D;
            Numero2 = -1D;
            Operador = ' ';
        }
        public double Suma()
        {
            return Numero1 + Numero2;
        }
        public double Resta()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicacion()
        {
            return Numero1 * Numero2;
        }
        public double Division()
        {
            return Numero1 / Numero2;
        }
    }
}
