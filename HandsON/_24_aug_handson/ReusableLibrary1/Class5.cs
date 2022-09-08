using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableLibrary1
{
    public class Class5
    {
        public static void upper()
        {
            String str = "Hello World";

            String result = str.ToUpper();
            Console.WriteLine($"Original String : {str}");
            Console.WriteLine($"Uppercase String : {result}");

        }
    }
}
