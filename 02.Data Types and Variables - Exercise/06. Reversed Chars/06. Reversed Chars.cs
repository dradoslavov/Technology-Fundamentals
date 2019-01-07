using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            Console.Write($"{thirdLetter} {secondLetter} {firstLetter}");
            Console.WriteLine();

        }
    }
}
