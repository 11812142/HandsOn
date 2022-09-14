using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_aug_handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            //UserStack s = new UserStack();
            //Console.WriteLine("IEmpty= " + s.isStackEmpty());
            //Console.WriteLine("------------");
            //s.Push(10);
            //s.Push(100);
            //s.Push(20);
            //s.Push(40);

            //Console.WriteLine("Pop ");
            //s.Pop();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Peek");
            //s.Peek();
            //Console.WriteLine("---------------------");
            //s.PrintStackElements();
            //Console.WriteLine("IEmpty= " + s.isStackEmpty());


            //  UserDataStore<string> stringdata = new UserDataStore<string>();
            //  stringdata.AddOrEdit(0, "Hello");
            //string printdata  =stringdata.ReturnData(0);
            //  Console.WriteLine(printdata);
            //  Console.WriteLine("-------------------");
            //  stringdata.AddOrEdit(0, "Welcome");



            //  stringdata.ShowData(0);
            //Linear  search doesn't require sorted collection
            //Binary serach requires sorted collection

            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Find element to search..");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == e)
                {
                    Console.WriteLine("Found it at index = " + i);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }


            Console.ReadLine();
        }
    }
}