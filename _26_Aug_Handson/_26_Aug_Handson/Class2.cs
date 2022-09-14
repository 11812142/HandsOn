using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace _26_Aug_Handson
{
    class Class2
    {
        static void Main(string[] args)
        {
            student[] s = new student[2];

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new student();
                //s[i] = new Class_stud();

                Console.WriteLine("Enter id:");
                s[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                s[i].SName = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                s[i].age = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in s)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.SName);
                Console.WriteLine(item.age);




            }
        }
    }
}
