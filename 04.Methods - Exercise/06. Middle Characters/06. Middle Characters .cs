using System;

namespace _06.Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            
                Console.WriteLine(GetMiddleString(word));
        }

        static string GetMiddleString(string word)
        {
             string trimmed = string.Empty;
            int midCharIndex = (word.Length / 2);
            if (word.Length % 2 != 0)
            {
                trimmed = word.Substring(midCharIndex ,1);
            }
            else
            {
                trimmed = word.Substring(midCharIndex -1, 2);
            }
            return trimmed;
        }
    }
}
