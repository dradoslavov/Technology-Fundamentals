using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string firstCommand = null;
            while (firstCommand!="end")
            {
                List<string> command = Console.ReadLine().Split().ToList();
                firstCommand = command[0];
                if (firstCommand=="Delete")
                {
                    int element = int.Parse(command[1]);

                    list.Remove(element);
                }
                else if (firstCommand=="Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    list.Insert(position, element);
                }
            }
            PrintList(list);
        }

        private static void PrintList(List<int> list)
        {
            Console.WriteLine($"{string.Join(" ", list)}");
        }
    }
}
