using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09EgenskaberTrekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(_grundlinje: 1, _højde: 1);
            Console.WriteLine(t.Areal);

            Trekant t2 = new Trekant(_grundlinje: 12, _højde: 19);
            Console.WriteLine(t2.Areal);

        }
    }

    class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public Trekant(int _grundlinje, int _højde)
        {
            this.Grundlinje = _grundlinje;
            this.Højde = _højde;
        }

        public double Areal {
            get {
                return (this.Grundlinje * this.Højde * 0.5);
            }
        }

    }
}
