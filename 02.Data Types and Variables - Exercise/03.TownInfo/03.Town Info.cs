using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int sqKm = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {city} has population of {population} and area {sqKm} square km.");
        }
    }
}
