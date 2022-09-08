using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19aug_handson
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n != 0)
            {

                case true:
                    if (n > 100)
                    {
                        Console.WriteLine("Greater than 100");
                    }
                    if (n % 10 == 0)
                    {
                        Console.WriteLine("The given number is multiple of 10");
                    }
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("The given number is even");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("The Given number is odd ");
                        break;

                    }
                case false:
                    {
                        Console.WriteLine("The given number is zero");
                    }
                    break;



            }
        }
    }
}
