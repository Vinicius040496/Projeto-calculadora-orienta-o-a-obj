using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp128
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora Rai = new Calculadora();

            Console.WriteLine("Qual valor do raio: ");
            Rai.ra = double.Parse(Console.ReadLine());
            Rai.circunf();
            Console.WriteLine("Circunfêrencia do raio é {0:f2}",Rai.circunf());
            Rai.Vol();
            Console.WriteLine("Volume do raio é {0:f2}", Rai.Vol());
            Rai.P();
            Console.WriteLine("Valor de Pi é {0:f2}",Rai.P());
            Console.ReadLine();
        }
    }
}
