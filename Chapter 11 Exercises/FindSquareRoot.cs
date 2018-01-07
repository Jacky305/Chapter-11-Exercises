using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Exercises
{
    class FindSquareRoot
    {
        public static void Run(string[] args)
        {
            double number, sqrt;

            Console.WriteLine("Enter a number:");
            try
            {
                number = Convert.ToDouble(Console.ReadLine());
                if (number < 0)
                    throw new ApplicationException();

                sqrt = Math.Sqrt(number);
                Console.WriteLine("The square root of {0} = {1}", number, sqrt);
            }
            catch (FormatException e)
            {
                Console.WriteLine("The input should be a number.");
            }
            catch (ApplicationException e)
            {
                Console.WriteLine("Number cannot be negative.");
            }
        }
    }
}
