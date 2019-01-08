using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayFirst = Console.ReadLine().Split(' ');
            string[] arraySecond = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < arraySecond.Length; i++)
            {
                for (int j = 0; j < arrayFirst.Length; j++)
                {
                    if (arraySecond[i] == arrayFirst[j])
                    {
                        Console.Write($"{arraySecond[i]} ");
                    }
                }

            }
        }
    }
}
