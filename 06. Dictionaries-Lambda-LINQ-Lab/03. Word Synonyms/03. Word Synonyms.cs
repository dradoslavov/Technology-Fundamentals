using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonymsWords = Console.ReadLine();
                if (!synonymsWords.ContainsKey(word))
                {
                    synonymsWords.Add(word, new List<string>());
                    synonymsWords[word].Add(synonymsWords);
                }
                else
                {
                    synonymsWords[word].Add(synonymsWords);
                }
            }

            foreach (var word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}