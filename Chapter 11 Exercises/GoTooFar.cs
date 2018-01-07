using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Exercises
{
    class GoTooFar
    {
        public static void Run(string[] args)
        {
            int[] array = new int[5];
            for (int x=0; x<array.Length; x++)
            {
                array[x] = x;
            }

            try
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine(array[x].ToString());
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("You've gone too far!");
            }
        }
    }
}
