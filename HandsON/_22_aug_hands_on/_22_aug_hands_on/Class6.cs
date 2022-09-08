using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_aug_hands_on
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(2);
            //Dynamically grow themselves
            s.Push(34);
            s.Push(34.34f);
            s.Push(34.56777d);
            s.Push(new DateTime(2011, 11, 10));
            s.Push("Hello");
            s.Push('Y');
            s.Push(true);
            Console.WriteLine("------------Before Pop---------------");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------After Pop---------------");
            object a1 = s.Pop();//true
            Console.WriteLine(a1);
            a1 = s.Pop();//Y
            Console.WriteLine(a1);
            a1 = s.Pop();//Hello
            Console.WriteLine(a1);

            int cnt = s.Count;
            object p = s.Peek();//returns datetime
            Console.WriteLine("Topmost Element = " + p);


        }
    }
}
