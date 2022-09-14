using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_aug_hands_on
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.getdata();
            obj.ShowData();
        }
    }
    public struct Employee
    {
        public int EmpNo;
        public string empName;
        public int sal;
        public int depno;

        public Employee(int empno, string name, int salary, int dep)
        {
            EmpNo = empno;
            empName = name;
            sal = salary;
            depno = dep;
        }
        public void getdata()
        {
            Console.WriteLine("enter the empno");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the empname");
            empName = Console.ReadLine();
            Console.WriteLine("enter the sal");
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the depno");
            depno = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("Employee No.=" + EmpNo);
            Console.WriteLine("Employee Name=" + empName);
            Console.WriteLine("Employee sal=" + sal);
            Console.WriteLine("Employee dep.no.=" + depno);

        }
    }
}

