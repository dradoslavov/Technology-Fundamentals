using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
