using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_aug_hands_on
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GFG ex = new GFG();

            ex.sum(50, 20);

        }
        class GFG
        {
            public void sum(int a, int b)
            {
                Console.WriteLine("SUM = " + (a + b));
            }
        }
    }
}
