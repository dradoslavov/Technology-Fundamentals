using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine($"Sum:{result}");
        }
    }
}
