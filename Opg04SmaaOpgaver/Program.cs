using System;

namespace Opg04SmaaOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskriv("Dette er en test");

            int[] løn = { 10000, 5000, 30000 };

            double gns = Gennemsnit(løn);

            Console.WriteLine(gns);

            Console.WriteLine("-------");

            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1, 2,3));
            Console.WriteLine(Beregn(1, 2,3,4));

            Console.WriteLine("***********");

            Rekursion(0);

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static int LægSammen(int a, int b)
        {
            return a+b;
        }

        static double BeregnAreal(int radius)
        {
            return radius*radius*System.Math.PI;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        static double Gennemsnit(int[] månedsløn)
        {
            int sum = 0;

            foreach (int løn in månedsløn)
            {
                sum += løn;
            }

            return sum/månedsløn.Length;
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            return Beregn(a,b) + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a,b,c) + d;
        }


        static void Rekursion(int a)
        {
            if (a < 10)
            {
                Console.WriteLine(a);
                Rekursion(++a);
            }
        }
    }
}
