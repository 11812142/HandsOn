using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19aug_handson
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int i, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the number and sum of all integer between 100 and 200\n");
            Console.Write("-----------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Sum of Numbers between 100 and 200 : \n");
            for (i = 101; i < 200; i++)
            {
                Console.Write("{0}  ", i);
                sum += i;

            }
            Console.Write("\n\nThe sum : {0} \n", sum);
        }
    }
}
