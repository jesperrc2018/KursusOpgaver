using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13ArvTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Normal terning");
            Terning t = new Terning(0);

            Console.WriteLine("Ludoterning");
            LudoTerning l = new LudoTerning(6);
            Console.WriteLine("Er globus: " + l.ErGlobus());
            Console.WriteLine("Er stjerne:" + l.ErStjerne());

            Console.ReadKey();
        }
    }

    class Terning
    {
        private int vaerdi;
        private static Random rnd;

        public int Vaerdi
        {
            get {
                Console.WriteLine("Der hentes værdi: " + vaerdi);
                return vaerdi;
            }
            //Tester at vaerdien ikke er over 6 eller under 1
            set
            {
                if (value < 1 || value > 6)
                {
                    this.vaerdi = 1;
                }
                else
                {
                    vaerdi = value;
                }

                Console.WriteLine("Der indsættes værdi: " + vaerdi);
            }
        }

        public void Ryst()
        {
            this.Vaerdi = rnd.Next(1, 7);
            //Console.WriteLine("Der tildeles værdi: " + this.vaerdi);
        }

        public void Skriv()
        {
            //Console.WriteLine("Der aflæses værdi: " + this.Vaerdi);
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

    class LudoTerning : Terning
    {
        public LudoTerning(int _vaerdi) : base (_vaerdi)
        {

        }

        public LudoTerning() : base()
        {

        }

        public bool ErGlobus()
        {
            if (this.Vaerdi == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ErStjerne()
        {
            if (this.Vaerdi == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
