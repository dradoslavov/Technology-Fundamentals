using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (count.ContainsKey(numbers[i]) == false)
                {
                    count[numbers[i]] = 1;
                }
                else
                {
                    count[numbers[i]]++;
                }

            }
            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
            
        }
    }
}
