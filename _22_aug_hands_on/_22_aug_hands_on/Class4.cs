using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_aug_hands_on
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            // Creating an ArrayList
            ArrayList myList = new ArrayList(10);

            // Adding elements to ArrayList
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            myList.Add("E");
            myList.Add("F");
            foreach (var i in myList)
                Console.WriteLine(i);
            // Displaying the elements in ArrayList
            Console.WriteLine("Number of elements in ArrayList initially : " + myList.Count);
            Console.WriteLine("-------Removing 2 element only------");
            myList.Remove("A");
            myList.Remove("B");
            foreach (var i in myList)
                Console.WriteLine(i);
            // Removing all elements from ArrayList
            myList.Clear();

            // Displaying the elements in ArrayList
            // after Removing all the elements
            Console.WriteLine("-----After Removing all----------");
            Console.WriteLine("Number of elements in ArrayList : " + myList.Count);



        }
    }
}
