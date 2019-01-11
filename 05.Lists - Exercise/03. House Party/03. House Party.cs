using System;
using System.Linq;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main()
        {

            int numberOfLines = int.Parse(Console.ReadLine());

            List<string> guest = new List<string>();

            int counter = 0;

            while (counter < numberOfLines)
            {
                List<string> listWithGuest = Console.ReadLine().Split().ToList();
                counter++;

                var name = listWithGuest[0];


                if (listWithGuest[2] == "going!")
                {
                    if (guest.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guest.Add(name);
                    }
                }

                if (listWithGuest[2] == "not")
                {
                    if (guest.Contains(name))
                    {
                        guest.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

            }

            foreach (var item in guest)
            {
                Console.WriteLine(item);
            }
        }
    }
}