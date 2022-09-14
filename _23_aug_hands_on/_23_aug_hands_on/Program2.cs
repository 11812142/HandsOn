using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_aug_hands_on
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            pratibha ex = new pratibha();

            int result = ex.sums(50, 20);
            Console.WriteLine("sum" + " " + result);
        }
    }

    class pratibha
    {
        public int sums(int a, int b)
        {
            int c = a + b;
            return c;
        }

    }
}

