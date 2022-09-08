using ReusableLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_aug_handson
{
    public class Program
    {

        static void Main(string[] args)
        {
                /*   DateTime dt1 = new DateTime();
                    dt1 = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("enter your bday date");
                    DateTime now = DateTime.Today;
                    int age = now.Year - dt1.Year;
                    if (dt1 > now.AddYears(-age))
                        age--;

                    Console.WriteLine("age= "+age);
                    Console.WriteLine("day = " + dt1.Day);
                    Console.WriteLine("month = " +dt1.Month);
                    Console.WriteLine("year = " + dt1.Year);
                    Console.WriteLine("week = " + dt1.DayOfWeek);


                    bool isLeapYear = DateTime.IsLeapYear(dt1.Year);
                    Console.WriteLine("leap year or not "+isLeapYear);



                    Console.ReadLine();   */
                Console.WriteLine("enter the string");
                //MyApp.printstring();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("compare two string ");
                Class1.print();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("string copy from s1 to s2 ");
                Class2.copys();
                Console.WriteLine("-----------------------------------");
                Class3.index();
                Console.WriteLine("-----------------------------------");
                Class4.splits();
                Console.WriteLine("-----------------------------------");
                Class5.upper();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("new firstFile is created");
                Class6.MakeFile();//Problem no.=6
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("date properities");
                Class7.dateprop();
                Console.WriteLine("-----------------------------------");
            
        }
    }
}

