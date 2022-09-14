using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_aug_hands_on
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Print Array------------");
            ArrayList al = new ArrayList();
            al.Add(34.0f);
            al.Add(445.11f);
            al.Add(11.14f);
            al.Add(34535.9f);
            al.Add(444.55f);
            al.Add(8.4f);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------Ascending Order------------");
            //al.Remove(34.0f);//first occurence of 34 in the arraylist
            //al.RemoveAt(0);
            //al.RemoveRange(0, 2);
            al.Sort();
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------Descending Order------------");
            al.Reverse();
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
