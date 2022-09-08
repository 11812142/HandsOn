using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_aug_hands_on
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Queue q = new Queue(10, 2);//FIFO--First in first out
            q.Enqueue(45);
            q.Enqueue(4567.45f);
            q.Enqueue(33);
            object a2 = q.Dequeue();//45
            Console.WriteLine(a2);
            object a3 = q.Peek();
            Console.WriteLine(a3);
        }
    }
}
