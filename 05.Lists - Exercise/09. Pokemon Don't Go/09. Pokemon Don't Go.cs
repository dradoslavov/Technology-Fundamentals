using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonDistance = Console.ReadLine()
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToList();
            int index = int.Parse(Console.ReadLine());
            int removeElementsSum = 0;

            while (true)
            {
                if (index >= 0 && index < pokemonDistance.Count)
                {
                    removeElementsSum += pokemonDistance[index];
                    RemoveElements(pokemonDistance, index);
                }

                else if (index < 0)
                {
                    removeElementsSum += pokemonDistance[0];
                    RemoveElements(pokemonDistance, 0);
                    pokemonDistance.Insert(0, pokemonDistance[pokemonDistance.Count - 1]);
                }
                else if (index >= pokemonDistance.Count)
                {
                    removeElementsSum += pokemonDistance[pokemonDistance.Count - 1];
                    RemoveElements(pokemonDistance, pokemonDistance.Count - 1);
                    pokemonDistance.Add(pokemonDistance[0]);
                }

                if (pokemonDistance.Count != 0)
                {
                    index = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(removeElementsSum);
        }

        private static void RemoveElements(List<int> pokemonDistance, int index)
        {
            int currentPokemon = pokemonDistance[index];
            for (int i = 0; i < pokemonDistance.Count; i++)
            {
                if (pokemonDistance[i] > currentPokemon)
                {
                    pokemonDistance[i] -= currentPokemon;
                }
                else
                {
                    pokemonDistance[i] += currentPokemon;
                }
            }

            pokemonDistance.RemoveAt(index);
        }
    }
}