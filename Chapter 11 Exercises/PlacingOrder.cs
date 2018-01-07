using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Exercises
{
    class PlacingOrder
    {
        public static void Run(string[] args)
        {
            int stockNumber = -1;
            int qtyOrdered = -1;

            try
            {
                Console.WriteLine("Enter stock number: ");
                stockNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter qty number: ");
                qtyOrdered = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                stockNumber = 0;
                qtyOrdered = 0;
            }

            Console.WriteLine("StockNumber: {0}",stockNumber);
            Console.WriteLine("Qty ordered: {0}",qtyOrdered);
        }
    }
}
