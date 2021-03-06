﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            var command = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                command = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}