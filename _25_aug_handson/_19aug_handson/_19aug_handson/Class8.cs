﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19aug_handson
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
