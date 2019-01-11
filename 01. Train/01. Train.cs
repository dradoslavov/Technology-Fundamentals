using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> passengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassengers = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                string operation = command[0];
                if (operation == "Add")
                {
                    int adedPassenger = int.Parse(command[1]);
                    passengers.Add(adedPassenger);
                }
                else if (operation == "end")
                {
                    break;
                }
                else
                {
                    int adedPassengers = int.Parse(command[0]);
                    for (int i = 0; i < passengers.Count; i++)
                    {

                        if (maxPassengers >= adedPassengers + passengers[i])
                        {
                            passengers[i] += adedPassengers;
                            break;
                        }

                    }
                }

            }
            PrintPassenger(passengers);

        }

        private static void PrintPassenger(List<int> passengers)
        {
            for (int i = 0; i < passengers.Count; i++)
            {
                Console.Write(passengers[i] + " ");
            }
        }
    }
}