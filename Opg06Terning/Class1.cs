using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg06Terning
{
    class Terning
    {
        public int værdi;
        public bool snyd;
        Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine(værdi);
        }

        public void Ryst()
        {
            if (snyd)
            {
                this.værdi = 6;
            }
            else
            {
                this.værdi = rnd.Next(1, 7);
            } 
        }

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

    }
}
