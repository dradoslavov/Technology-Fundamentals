using System;
using System.Collections.Generic;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            List<char> newSymbol = new List<char>();
            for (int i = 0; i < words.Length; i++)
            {
                char symbol = words[i];
                int plus3Symbol = (int)symbol + 3;
                newSymbol.Add((char)plus3Symbol);
                

            }
            Console.WriteLine(string.Join("",newSymbol));
        }
    }
}
