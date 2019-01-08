using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Characters_in_Range
{
    class Program
    {
        static void Main()
        {
            string @string;
            
            @string = Console.ReadLine();
            CalculateVowels( @string);
        }
        static void CalculateVowels (string @string)
        {
            int vowel;
            vowel = 0;

            for (int i = 0; i < @string.Length; i++)
            {
                if (@string[i] == 'a' || @string[i] == 'e' || @string[i] == 'i' || @string[i] == 'o' || @string[i] == 'u' || @string[i] == 'A' || @string[i] == 'E' || @string[i] == 'I' || @string[i] == 'O' || @string[i] == 'U')
                {
                    vowel++;
                }
            }
            Console.Write(vowel);
        }
    }
}