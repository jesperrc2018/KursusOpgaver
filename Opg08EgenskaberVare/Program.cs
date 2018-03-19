using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg08EgenskaberVare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare(_navn: "MinVare", _pris:1.25);

        }
    }

    class Vare
    {
        public Vare(string _navn, double _pris)
        {
            this.Navn = _navn;
            this.Pris = _pris;
        }

        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine($"Aflæsning {this.navn}");
                return navn; }
            set {
                Console.WriteLine($"Tildeling {value}");
                navn = value; }
        }
        
        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine($"Aflæsning {this.pris}");
                return pris; }
            set {
                Console.WriteLine($"Tildeling {value}");
                pris = value; }
        }

        public double PrisMedMoms
        {
            get { return (this.Pris * 1.25); }
            
        }


    }
}
