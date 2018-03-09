using System;

namespace Opg05Klasser
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            //Person p = new Person( "jesper", "christophersen", 1985);
            Person p = new Person("", "", 1985);

            Person p1 = new Person();

            Console.WriteLine(p.Fornavn);
            Console.WriteLine(p.Efternavn);
            Console.WriteLine(p.Alder());

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }

        public int Alder()
        {
            int a = DateTime.Now.Year - Fødselsår;
            return a;
        }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
            this.Fødselsår = 0;
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            if (fornavn.Length > 1)
            {
                this.Fornavn = fornavn.Substring(0, 1).ToUpper() + fornavn.Substring(1, fornavn.Length - 1);
            }else
            {
                this.Fornavn = fornavn.ToUpper();
            }

            if (efternavn.Length > 1)
            {
                this.Efternavn = efternavn.Substring(0, 1).ToUpper() + efternavn.Substring(1, efternavn.Length - 1);
            }else
            {
                this.Efternavn = efternavn.ToUpper();
            }
            
            this.Fødselsår = fødselsår; 
        }

    }
}
