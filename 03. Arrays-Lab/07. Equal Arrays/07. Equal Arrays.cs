﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array1.Length; i++)
            {

                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    int sum = 0;
                    sum += array1[i];
                    if (i == array1.Length - 1)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    }
                }
            }
        }
    }
}

