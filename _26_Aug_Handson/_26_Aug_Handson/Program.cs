using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Aug_Handson
{
        public struct Student
        {
            public int Id;
            public string Name;
            public int Fees;

            public void SetStudent(int id, string name, int fees)
            {
                Id = id;
                Name = name;
                Fees = fees;
            }

            public void PrintStudent()
            {
                Console.WriteLine("Student details:");
                Console.WriteLine("\tID     : " + Id);
                Console.WriteLine("\tName   : " + Name);
                Console.WriteLine("\tFees   : " + Fees);
                Console.WriteLine("\n");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student[] S = { new Student(), new Student() };

                S[0].SetStudent(101, "Aaditi", 10000);
                S[1].SetStudent(102, "Jiya", 8000);

                S[0].PrintStudent();
                S[1].PrintStudent();
            }
        }
}
