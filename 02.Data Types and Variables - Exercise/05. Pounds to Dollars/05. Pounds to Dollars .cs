﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal GBP = decimal.Parse(Console.ReadLine());
            decimal USD = GBP * 1.31m;
            Console.WriteLine($"{USD:f3}");
        }
    }
}
