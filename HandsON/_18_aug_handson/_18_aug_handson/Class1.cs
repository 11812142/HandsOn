using System;
namespace _18_aug_handson
{
    public class Problem1
    {
        public static void Main(string[] args)
        {
            //giving values
            Console.WriteLine("-------------------");
            int a = 10, b = 15;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)
            Console.WriteLine("-------------------");
            Console.Write("After swap a= " + a + " b= " + b);

        }

    }

}
