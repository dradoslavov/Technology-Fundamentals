using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                ["motes"]=0,
                ["shards"] = 0,
                ["fragments"] = 0
            };
            SortedDictionary<string, int> junksItem = new SortedDictionary<string, int>();

            var input = Console.ReadLine().Split();

            while (true)
            {
                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string currentMaterial = input[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(currentMaterial))
                    {
                        keyMaterials[currentMaterial] += quantity;

                        if (keyMaterials["motes"]>=250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials["motes"] -= 250;
                            PrintLeftMaterials(keyMaterials,junksItem);
                            return;
                            
                        }
                        else if(keyMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials["shards"] -= 250;
                            PrintLeftMaterials(keyMaterials, junksItem);
                            return;

                        }
                        else if (keyMaterials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials["fragments"] -= 250;
                            PrintLeftMaterials(keyMaterials, junksItem);
                            return;
                        }
                    }
                    else
                    {
                        if (!junksItem.ContainsKey(currentMaterial))
                        {
                            junksItem.Add(currentMaterial, 0);
                        }
                      
                            junksItem[currentMaterial] += quantity;
                        
                    }
                }
                
                    input = Console.ReadLine().Split();
            }

            
        }

        private static void PrintLeftMaterials(Dictionary<string, int> keyMaterials, SortedDictionary<string, int> junks)
        {

            foreach (var kvp in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var junk in junks)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}