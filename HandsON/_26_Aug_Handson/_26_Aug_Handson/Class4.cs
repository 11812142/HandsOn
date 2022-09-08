using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _26_Aug_Handson
{
    class Class4
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("hi");
            mylist.AddLast("Bye");
            mylist.AddAfter(mylist.First, "How are you");
            mylist.AddBefore(mylist.Last, "Nice to Meet");
            mylist.AddBefore(mylist.Last.Previous, "Great");
            mylist.AddAfter(mylist.First.Next, "Welcome");


            LinkedListNode<string> foundnode = mylist.Find("Nice to Meet");
            foundnode.Value = "Plearsure! meeting with you";
            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
