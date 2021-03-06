﻿using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = (char)GetMax(firstChar, secondChar);
                Console.WriteLine(result);

            }
            else if (type == "string")
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();
                int result = GetMax(firstText, secondText);

                if (result > 0)
                {
                    Console.WriteLine(firstText);
                }
                else
                {
                    Console.WriteLine(secondText);
                }
            }
        }

        private static int GetMax(string firstText, string secondText)
        {
            int comparison = firstText.CompareTo(secondText);
            return comparison;
        }

        private static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}