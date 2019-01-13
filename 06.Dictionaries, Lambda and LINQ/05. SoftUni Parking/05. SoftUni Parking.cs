using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> carsAndOwners = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string [] command = Console.ReadLine().Split();
                if (command[0]=="register")
                {
                    if (carsAndOwners.ContainsKey(command[1])==false)
                    {
                        carsAndOwners[command[1]] = command[2];
                        Console.WriteLine($"{command[1]} registered {carsAndOwners[command[1]]=command[2]} successfully");
                    }
                    else if (carsAndOwners.ContainsKey(command[1])==true && carsAndOwners.ContainsValue(command[2])==true)
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carsAndOwners[command[1]]}");
                    }
                }
                else
                {
                    if (carsAndOwners.ContainsKey(command[1])==true)
                    {
                        carsAndOwners.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
            foreach (var item in carsAndOwners)
            {
                Console.Write($"{item.Key} => ");
                Console.WriteLine(item.Value);
            }
        }
    }
}
