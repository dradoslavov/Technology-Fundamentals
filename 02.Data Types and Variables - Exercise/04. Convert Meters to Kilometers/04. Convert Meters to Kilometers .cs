using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double km = meters / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
