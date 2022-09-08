using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_aug_hands_on
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "tea");
            h.Add(2, "Coffee");
            h.Add(3, "Coke");
            h.Add(4, "Milk");
            h.Add(5, "thumsup");
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine("After Removing");
            h.Remove(1);
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
        }
    }
}
