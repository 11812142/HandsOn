﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryCalculator
{
    public class Class1
    {
        public double i { get; set; }
        public double j { get; set; }
        public double num1
        {
            get { return i; }
            set { i = value; }
        }
        public double num2
        {
            get { return j; }
            set { j = value; }
        }

        public int Cube(int i,int j)
        {
            int p= i*i*i;
            int q = j * j * j;
            Console.WriteLine("Cube of 1st number: " + p + "\n"  + "Cube of 2nd number: " +q);
            return 0;
        }
        public void SquareRoot(double i,double j)
        {
            
            double k = Math.Sqrt(i);
            double v = Math.Sqrt(j);
            Console.WriteLine("Square Root of 1st Number {0} = {1}: ", i,k );
            Console.WriteLine("Square Root of 2nd Number {0} = {1}: ", j, v);

        }


    }
}
