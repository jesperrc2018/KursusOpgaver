using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg17StockItemsException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockItem s = new StockItem(-1);
            }
            catch (StockItemException)
            {

                Console.WriteLine("StockItem Error");
            }catch (Exception)
            {
                Console.WriteLine("General Error");
            }

            Console.ReadKey();
        }
    }

    class StockItem
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set {
                if (value <0)
                {
                    throw new StockItemException("Wrong id");
                }
                _id = value; }
        }

        public StockItem(int id)
        {
            this.ID = id;
        }

    }

    class StockItemException : Exception
    {
        public StockItemException(string s) : base(s)
        {
            
        }
    }
}
