using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'a' || letter == 'b' || letter == 'c' || letter == 'd' || letter == 'e'
                || letter == 'f' || letter == 'g' || letter == 'h' || letter == 'i' || letter == 'j'
                || letter == 'k' || letter == 'l' || letter == 'm' || letter == 'n' || letter == 'o'
                || letter == 'o' || letter == 'p' || letter == 'q' || letter == 'r' || letter == 's'
                || letter == 't' || letter == 'u' || letter == 'v' || letter == 'w' || letter == 'x'
                || letter == 'y' || letter == 'z')
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }

        }
    }
}
