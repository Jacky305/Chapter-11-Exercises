using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Exercises
{
    class CarInsurance
    {
        public static void Run(string[] args)
        {
            int age;
            string state;

            try
            {
                Console.WriteLine("Enter age and state");
                age = int.Parse(Console.ReadLine());
                state = Console.ReadLine();
                Console.WriteLine("Premium is ${0}", CalculatePremium(age, state));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static int CalculatePremium(int age, string state)
        {
            int temp = -1;
            try
            {
                if (age < 16 || age > 80)
                    throw new ArgumentException();
                if (state == "IL")
                    temp = 100;
                else if (state == "WI")
                    temp = 50;
                else
                    throw new ArgumentException();

                temp += 100 - (3 * age);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                temp = 0;
            }

            return temp;
        }
    }
}
