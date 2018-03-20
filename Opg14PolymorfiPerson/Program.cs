using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14PolymorfiPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("a", "b");
            Elev e = new Elev("c", "d", "A256");
            Instruktør i = new Instruktør("e", "f", 5);

            Person[] lst = new Person[3];
            lst[0] = p;
            lst[1] = e;
            lst[2] = i;

            foreach (var item in lst)
            {
                item.Skriv();
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn);
        }

        public Person()
        {

        }

        public Person(string _fornavn, string _efternavn)
        {
            this.Fornavn = _fornavn;
            this.Efternavn = _efternavn;
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + " Klasseloake:" + Klasselokale);
        }

        public Elev()
        {

        }

        public Elev(string _fornavn, string _efternavn, string _klasselokale)
        {
            this.Fornavn = _fornavn;
            this.Efternavn = _efternavn;
            this.Klasselokale = _klasselokale;
        }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + " NøgleID:" + NøgleId);
        }

        public Instruktør()
        {

        }

        public Instruktør(string _fornavn, string _efternavn, int _nøgleId)
        {
            this.Fornavn = _fornavn;
            this.Efternavn = _efternavn;
            this.NøgleId = _nøgleId;
        }
    }
}

