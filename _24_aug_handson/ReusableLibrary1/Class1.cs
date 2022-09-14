using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableLibrary1
{
    public class Class1
    {
        public static void print()
        {

            string s1 = "Pratibha Sheoran";
            Console.WriteLine(s1);
            string s2 = "Pratibha Sheoran";
            Console.WriteLine(s2);

            Console.WriteLine(s1.Equals(s2));
        }
    }
    }