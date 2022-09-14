using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_aug_hands_on
{
    internal class Program6
    {
        enum deptnames
        {
            Purchase = 1,
            Sales = 2,
            Training = 3,
            Accounts = 4
        };
        public static void Main()
        {

            foreach (string item in Enum.GetNames(typeof(deptnames)))
            {
                Console.WriteLine(item);
            }
            foreach (int item in Enum.GetValues(typeof(deptnames)))
            //{
            //    Console.WriteLine(item);

            //}
            {
                Console.WriteLine(item + " : " + (deptnames)item);
            }
        }
    }
}
