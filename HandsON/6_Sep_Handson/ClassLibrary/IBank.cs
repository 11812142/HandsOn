using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public interface IBank
    {
        void print_balance();
        void calc_interest();
    }
    public class Bank : IBank
    {

        public double amount;

        public Bank()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("ENTER THE AMOUNT");
            amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Balance is" + amount);
        }
        public void calc_interest()
        {
            int r;
            Console.WriteLine("enter the interest to calculate");
            r = Convert.ToInt32(Console.ReadLine());
            double result = amount * r;
            Console.WriteLine("calc_interest " + result);
        }
    }
}

