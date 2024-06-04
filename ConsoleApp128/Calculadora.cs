using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp128
{
    internal class Calculadora
    {
        public double ra;
        public double Circunferencia;
        public double Volume;
        public double Pi = 3.14;

        public double circunf()
        {
            return 2* Pi * ra;
        }

        public double Vol()
        {
            return 4.0 / 3.0 * Pi * Math.Pow(ra, 3);
        }

        public double P()
        {
            return 3.14;
        }
    }
}
