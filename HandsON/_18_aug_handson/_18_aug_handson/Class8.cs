using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_aug_handson
{
    internal class Class8
    {
            public static void Main()
            {
                int x;

                Console.Write("Enter a number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}{0}{0}", x);
                Console.WriteLine("{0} {0}", x);
                Console.WriteLine("{0} {0}", x);
                Console.WriteLine("{0} {0}", x);
                Console.WriteLine("{0}{0}{0}", x);
            }
        
    }
}
