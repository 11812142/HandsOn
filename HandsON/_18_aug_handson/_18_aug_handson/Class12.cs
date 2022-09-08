using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_aug_handson
{
    internal class Class12
    {
        public static void Main()
        {
            string str = "";
            string str1 = string.Empty;
            string str2;

            Console.Write("Enter first number - ");
            string i1 = Console.ReadLine();

            Console.Write("Enter second number - ");
            string i2 = Console.ReadLine();

            bool b1 = string.IsNullOrEmpty(i1);
            Console.WriteLine(b1);

            bool b2 = string.IsNullOrEmpty(i2);
            Console.WriteLine(b2);
        }
    }
}
