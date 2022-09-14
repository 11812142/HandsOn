using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19aug_handson
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 90;
            int maxNum;
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                maxNum = a;
            }
            else
            {
                maxNum = b;
            }
            Console.WriteLine("Biggest number is: " + maxNum);
            Console.ReadKey();
        }
    }
}
