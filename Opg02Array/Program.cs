using System;

namespace Opg02Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] m�nedsl�n = { 10000, 20000, 15000, 20000, 30000, 15000 };

            double sum = 0;

            Console.WriteLine("Usorteret!");
            foreach (var l�n in m�nedsl�n)
            {
                sum += l�n;
                Console.WriteLine(l�n);
            }

            Console.WriteLine("Gennemsnit!");
            Console.WriteLine(sum/m�nedsl�n.Length);

            Console.WriteLine("Sorteret!");

            System.Array.Sort(m�nedsl�n);

            foreach (var l�n in m�nedsl�n)
            {
                sum += l�n;
                Console.WriteLine(l�n);
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
