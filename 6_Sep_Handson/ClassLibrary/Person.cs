using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    
    public abstract class Person
    {
         
        //abstract method
        public abstract void work();
    }
    public class Employee : Person
    {


        public override void work()
        {
            Console.WriteLine("calling emplpoyee");
        }
    }
    public class Manager : Person
    {


        public override void work()
        {
            Console.WriteLine("calling manager");
        }
    }
    public class Clerk : Person
    {


        public override void work()
        {
            Console.WriteLine("calling clerk");
        }
    }






}
