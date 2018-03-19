using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg11Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10,10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
            Console.ReadKey();
        }
    }

    static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double bredde)
        {
            return højde * bredde;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return  radius * System.Math.Pow(radius,2) * System.Math.PI;

        }
    }
}
