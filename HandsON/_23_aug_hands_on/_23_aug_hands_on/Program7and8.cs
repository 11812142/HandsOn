using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_aug_hands_on
{
    internal class Program7and8
    {
        public static void Main()
        {
            int number1 = 3000;
            int number2 = 0;

            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException e)

            {
                Console.WriteLine("An exception ({0}) occurred.", e.GetType().Name);
                Console.WriteLine("Message:\n   {0}\n", e.Message);
                Console.WriteLine("Division of {0} by zero.", number1);
                Console.WriteLine("Stack Trace:\n   {0}\n", e.StackTrace);
            }
        }
    }
}
