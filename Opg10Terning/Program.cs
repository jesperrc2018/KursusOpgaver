using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            YatzyBæger b = new YatzyBæger();
            for (int i = 0; i < 10000; i++)
            {
                b.Ryst();
                b.Skriv();
            }
            
            Console.ReadKey();
        }
    }

    class Terning
    {
        private int vaerdi;
        private static Random rnd;

        public int Vaerdi
        {
            get { return vaerdi; }
            //Tester at vaerdien ikke er over 6 eller under 1
            set {
                if (value<1 || value > 6)
                {
                    this.Vaerdi = 1;
                }
                else
                {
                    vaerdi = value;
                }
            }
        }

        public void Ryst()
        {
            this.Vaerdi = rnd.Next(1,7);
        }

        public int Skriv()
        {
            return this.Vaerdi;
        }

        static Terning()
        {
            rnd = new Random();
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int _vaerdi)
        {
            this.Vaerdi = _vaerdi;
        }
    }

    class YatzyBæger 
    {
        private Terning[] terninger = new Terning[5];

        public YatzyBæger()
        {
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i] = new Terning();
            }
        }

        public void Ryst()
        {
            foreach (var terning in this.terninger)
            {
                terning.Ryst();
            }
        }

        public void Skriv()
        {
            int[] t = new int[6];
            foreach (var ternign in terninger)
            {
                t[ternign.Vaerdi-1] += 1;
                Console.WriteLine(ternign.Skriv());
            }
            Console.WriteLine("-----------");
            Console.WriteLine($"Der var {t.Max()} ens");
            
            if (t.Max() == t.Length-1)
            {
                Console.WriteLine("------**** YATZYYYYYY ****-----");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("-----------");
            }
        } 
    }
}
