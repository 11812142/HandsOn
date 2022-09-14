using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableLibrary1
{
    public class Class7
    {
        public static void dateprop()
        {
            //System.DateTime moment = new System.DateTime(2016, 8, 16, 3, 57, 32, 11);//for given date
            //for today's date
            DateTime moment = new DateTime();
            moment = DateTime.Now;
            Console.WriteLine(moment);
            Console.WriteLine("year = " + moment.Year);

            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);

            Console.WriteLine("year = " + moment.Year);
            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);
        }
    }
}
