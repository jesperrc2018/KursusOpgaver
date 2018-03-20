using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15PolymorfiDyr
{
    class Program
    {
        static void Main(string[] args)
        {


            Dyr[] dyr = new Dyr[20];

            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();

            }

            Console.ReadKey();
        }
    }


    abstract class Dyr
    {

        static Random rnd = new Random();
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
             
            Dyr d;
            
            if (rnd.Next(0,2) == 1)
            {
                d = new Hund();
            }
            else
            {
                d = new Kat();
            }
                        
            d.Navn = navne[rnd.Next(1, navne.Count())];
            
            return d;
        }

        public Dyr()
        {
  
        }
    }


    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + Navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn);
        }
    }
}
