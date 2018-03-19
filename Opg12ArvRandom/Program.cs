using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg12ArvRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom u = new UdvidetRandom();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(u.NextBool());
            }

            Console.ReadKey();
        }
    }

    class UdvidetRandom : System.Random
    {
        //private Random r;

        //public bool NextBool()
        //{
        //    if (r.Next(1,1002)< 500)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool NextBool()
        {
            return this.Next(1, 1002) < 500;
        }

        //public UdvidetRandom()
        //{
        //    r = new Random();
        //}
    }
}
