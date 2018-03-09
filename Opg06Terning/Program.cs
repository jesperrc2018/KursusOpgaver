using System;

namespace Opg06Terning
{
    class Program
    {
        static void Main(string[] args)
        {


            Terning t1 = new Terning();
            t1.Skriv();
            t1.snyd = true;
            t1.Ryst();
            t1.Skriv();


            Terning t2 = new Terning();
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

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
