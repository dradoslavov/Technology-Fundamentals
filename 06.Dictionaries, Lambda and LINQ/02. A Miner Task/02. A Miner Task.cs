using System;
using System.Collections.Generic;

namespace _02.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = null;
            Dictionary<string, int> metal = new Dictionary<string, int>();

            while ( true)
            {
                 type = Console.ReadLine();
                if (type == "stop")
                {
                    break;
                }
                int number = int.Parse(Console.ReadLine());
                if (metal.ContainsKey(type))
                {
                    metal[type]+=number;
                }
                else
                {
                    metal.Add(type, number);
                }
            }
            foreach (var item in metal)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
