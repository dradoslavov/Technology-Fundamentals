using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char fistLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            
            
                Console.Write($"{fistLetter}");
                Console.Write($"{secondLetter}");
                Console.Write($"{thirdLetter}");
                Console.WriteLine();

            
        }
    }
}
