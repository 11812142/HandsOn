using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace _7SepHandson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Length n = new Length();

            //StringLengthDelegate s1 = new StringLengthDelegate(n.StringLength);
            //s1.Invoke();
            //s1();  //1
            Console.WriteLine("-------------------------");


            //GreetDelegate g = new GreetDelegate(n.User);
            //g.Invoke(" World ");//2
            //Console.WriteLine("-----------------------");
            

            StringConcatenateDelegate c = new StringConcatenateDelegate(n.Concatenate);
            c.Invoke("Pratibha" , "Sheoran");
            Console.WriteLine("-------------------------"); //6

            Console.ForegroundColor = ConsoleColor.Yellow;
            Math1 m = new Math1();
            MathDelegate del1 = new MathDelegate(m.Add);
            MathDelegate del2 = new MathDelegate(m.Sub);
            MathDelegate del3 = m.Mul;

            MathDelegate del4 = del1 + del2 + del3;
            del4.Invoke(20, 5);
            //Console.WriteLine("--------");
            //del4 -= del2;
            //del4(22, 7);          //3
            Console.WriteLine("------------------------");

            Console.ForegroundColor = ConsoleColor.White;
            Product mo = new Product();
            Console.WriteLine("Enter productId ");
            mo.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter productName ");
            mo.ProductName = Console.ReadLine();
            q4 pid = new q4(mo.Display);
            pid(mo);
            Console.WriteLine("--------------------------"); //4


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the year,Month,date");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int date = Convert.ToInt32(Console.ReadLine());
            
            Employe emp = new Employe();
            DateTime t = new DateTime(year, month, date);
            emp.Joining = t;
            q5 se = new q5(emp.Expyrs);
            int poiu = se(emp.Joining);
            Console.WriteLine($"Years of exp {poiu}");
            Console.WriteLine("--------------------------------");  //5

            Console.ForegroundColor = ConsoleColor.White;
            FirstCapitalDelegate u = new FirstCapitalDelegate(n.FirstCapital);
            u.Invoke("mphasis");//7

            Console.ReadKey();
        }
    }
}
