﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg16Try
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Run();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Der er sket en fejl" + e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Der er sket en fejl" + e.Message);
            }
            Console.ReadKey();
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int res = tal1 + tal2;

            Console.WriteLine("Restultat er :" + res);

            
        }

    }
}
