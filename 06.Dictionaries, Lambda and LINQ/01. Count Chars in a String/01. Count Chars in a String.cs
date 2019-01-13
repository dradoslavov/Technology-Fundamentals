using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split();
            Dictionary<char, int> count = new Dictionary<char, int>();

            for (int i = 0; i < letters.Length; i++)
            {
                foreach (char letter in letters[i])
                {
                    if (count.ContainsKey(letter))
                    {
                        count[letter]++;
                    }
                    else
                    {
                        count.Add(letter, 1);
                    }
                }
            }
            foreach (var letter in count)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
