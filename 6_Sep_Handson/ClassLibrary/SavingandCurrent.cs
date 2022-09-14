using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    
    public class Saving : IBank
    {

        public double amount;

        public Saving()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("ENTER THE AMOUNT");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            float r = 0.04f;

            double result = amount * r;
            
            Console.WriteLine("calc_interest " + result);
        }
    }
    public class Current : IBank
    {

        public double amount;

        public Current()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("ENTER THE AMOUNT");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            float r = 0.02f;

            double result = amount*r ;
            // *= (1 + (r / 100 / 12));
            Console.WriteLine("calc_interest " + result);
        }
    }
}
