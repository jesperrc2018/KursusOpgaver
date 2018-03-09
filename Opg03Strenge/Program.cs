using System;

namespace Opg03Strenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string del = samletNavn.Substring(samletNavn.IndexOf(' ')+1, 4);
            Console.WriteLine(del);

            string[] a = samletNavn.Split(' ');

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
             

            //Console.WriteLine("\tt\r\naa");

            //System.IO.File.WriteAllText(@"c:\temp\navn.txt", samletNavn);

            // Your code here.....

            int p = 0;

            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    p = i * x;

                    if ( p > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(p + "\t");
                }
                Console.Write("\n\r");
            }
             

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
