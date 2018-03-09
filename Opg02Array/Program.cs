using System;

namespace Opg02Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            double sum = 0;

            Console.WriteLine("Usorteret!");
            foreach (var løn in månedsløn)
            {
                sum += løn;
                Console.WriteLine(løn);
            }

            Console.WriteLine("Gennemsnit!");
            Console.WriteLine(sum/månedsløn.Length);

            Console.WriteLine("Sorteret!");

            System.Array.Sort(månedsløn);

            foreach (var løn in månedsløn)
            {
                sum += løn;
                Console.WriteLine(løn);
            }



            // Your code here.....




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
