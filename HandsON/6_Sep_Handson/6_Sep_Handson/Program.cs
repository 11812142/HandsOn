using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace _6_Sep_Handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p = new Employee();
            p.work();
            p = new Manager();
            p.work();
            p = new Clerk();
            p.work();    //1
            Console.WriteLine("-----------------------------------------");

            Bank b1 = new Bank();
            b1.print_balance();
            b1.calc_interest();     //2
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("savings account");
            Saving b = new Saving();
            b.print_balance();
            b.calc_interest();
            Console.WriteLine("current account");
            IBank b2 = new Current();
            b2.print_balance();
            b2.calc_interest();   //3   //4

            Console.WriteLine("-----------------------------------------");
            Extension g = new Extension();



            g.current();
            g.savings();
            g.deposits();
            g.withdraw();
            g.total_balc();
            g.deposits1();
            g.withdraw1();
            g.total_balc1();            //5  //6  
<<<<<<< HEAD
            
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Total Count: ");    //7
            
=======


>>>>>>> new handson
        }
    }
}
