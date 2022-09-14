using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace _26aug
{
    internal class Class3
    {
        public static void Main()
        {
            //List<int> productIDlist = new List<int>();
            //List<string> producnamelist = new List<string>();
            //productIDlist.Add(1);
            //productIDlist.Add(2);
            //productIDlist.Add(3);
            ////productIDlist.Add(3);
            //producnamelist.Add("caffine");
            //producnamelist.Add("wow");
            //producnamelist.Add("dherma");
            //foreach (var i in productIDlist)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (var j in producnamelist)
            //{
            //    Console.WriteLine(j);
            //}
            //int indexToRemove = 1;
            //productIDlist.Remove(indexToRemove);
            //foreach (var i in productIDlist)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            List<string> products = new List<string>();
            products.Add("pen");
            products.Add("pencil");
            products.Add("box");
            products.Add("chocolates");

            Console.WriteLine("products");

            foreach (string p in products)
            {

                Console.WriteLine(p);

            }
            Console.WriteLine("count is " + products.Count);
            Console.WriteLine("---------------------------------------");

            products.Add("chips");

            foreach (string l in products)
            {

                Console.WriteLine(l);



            }
            Console.WriteLine("count after adding is " + products.Count);
            Console.WriteLine("---------------------------------------");

            products.Remove("box");
            products.Remove("pencil");
            Console.WriteLine("count after deleting is " + products.Count);

            Console.WriteLine("products :");

            foreach (string l in products)
            {

                Console.WriteLine(l);



            }
            Console.Read();
        }
    }
    
}


