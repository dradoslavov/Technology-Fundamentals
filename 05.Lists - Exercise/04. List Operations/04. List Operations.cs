using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split().ToList();

            while (commands[0] != "End")
            {
                if (commands[0] == "Add")
                {
                    list.Add(int.Parse(commands[1]));
                }

                else if (commands[0] == "Insert")
                {
                    if (int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < list.Count)
                    {
                        list.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }

                else if (commands[0] == "Remove")
                {
                    if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < list.Count)
                    {
                        list.RemoveAt(int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (commands[0] == "Shift")
                {
                    if (commands[1] == "left")
                    {
                        list = ShiftLeft(list, int.Parse(commands[2]));
                    }
                    else if (commands[1] == "right")
                    {
                        list = ShiftRight(list, int.Parse(commands[2]));
                    }
                }

                commands = Console.ReadLine().Split().ToList();
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        private static List<int> ShiftRight(List<int> listOfInt, int steps)
        {
            var shiftedList = new List<int>();

            for (int i = listOfInt.Count - (steps % listOfInt.Count); i < listOfInt.Count; i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            for (int i = 0; i < listOfInt.Count - (steps % listOfInt.Count); i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            return shiftedList;
        }

        private static List<int> ShiftLeft(List<int> listOfInt, int steps)
        {
            var shiftedList = new List<int>();

            for (int i = steps % listOfInt.Count; i < listOfInt.Count; i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            for (int i = 0; i < steps % listOfInt.Count; i++)
            {
                shiftedList.Add(listOfInt[i]);
            }

            return shiftedList;
        }
    }
}