using System;

namespace Opg01Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            a++;
            a--;
            a += 20;
            Console.WriteLine(a);

            double b = 12.5;
            b++;
            b--;
            b *= 2;
            Console.WriteLine(b);

            FilType ft = FilType.csv;
            Console.WriteLine(ft);
            //Udskriver værdien i stedet for strengen
            Console.WriteLine(Convert.ToInt32(ft));

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    enum FilType
    {
        csv,
        pdf,
        txt
    }

    struct Person
    {
        public int Id;
        public string Navn;
    }

}
