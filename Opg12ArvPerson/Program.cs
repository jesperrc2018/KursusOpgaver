using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg12ArvPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "p1";
            p1.Efternavn = "Efternavn";
            Console.WriteLine(p1.FuldtNavn());

            Elev e1 = new Elev();
            e1.Fornavn = "e1";
            e1.Efternavn = "Efternavn";
            e1.Klasselokale = "8.2.1";
            Console.WriteLine(e1.FuldtNavn());

            Instruktør i1 = new Instruktør();
            i1.Fornavn = "i1";
            i1.Efternavn = "Efternavn";
            i1.NøgleId = 23;
            Console.WriteLine(i1.FuldtNavn());

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    class Elev:Person
    {
        public string Klasselokale { get; set; }

    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

    }
}
