using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableLibrary1
{
    public class Class4
    {
        public static void splits()
        {
            string text = "Hi Beatiful,How.are/you";
            Console.WriteLine("splitting " + text);

            string[] result = text.Split(' ', ',', '.', '/');

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
