using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                PrintTriangle(i);
            }
            for (int i = number - 1; i >= 0; i--)
            {
                PrintTriangle(i);
            }
        }

        private static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}