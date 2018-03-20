using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Opg18Logging
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("Enter Main");

            for (int i = 0; i < 1000; i++)
            {

                test1(5, 5);
                test2();
            }


            //Console.ReadKey();
            logger.Trace("Exit Main");
        }

        static void test1(int i, int x)
        {
            logger.Trace("Enter test1");
            Console.WriteLine("test1");
            //System.Threading.Thread.Sleep(1000);
            logger.Trace("Exit test1");
        }

        static void test2()
        {
            logger.Trace("Enter test2");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception)
            {
                logger.Error("Error test2");
            }
            finally
            {
                logger.Trace("Exit test2");
            }
            
        } 
    }
}
