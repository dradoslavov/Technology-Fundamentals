using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];
            int sum = 0;
            int smallLength = 0;
            int bigLength = 0;
            if (firstWord.Length>secondWord.Length)
            {
                smallLength = secondWord.Length;
                bigLength = firstWord.Length;                               
                sum = MultyPlyingNumbers(smallLength,firstWord,secondWord);
                sum += ColectSymbols(smallLength, bigLength, firstWord);
                Console.WriteLine(sum);
            }
            else if (secondWord.Length>firstWord.Length)
            {
                smallLength = firstWord.Length;
                bigLength = secondWord.Length;
                sum = MultyPlyingNumbers(smallLength, firstWord, secondWord);
                sum += ColectSymbols(smallLength, bigLength, secondWord);
                Console.WriteLine(sum);
            }
            else if (secondWord.Length==firstWord.Length)
            {
                int Length = firstWord.Length;
                
                sum = MultyPlyingNumbers(Length, firstWord, secondWord);
                Console.WriteLine(sum);
            }
        }

        private static int ColectSymbols(int smallLength, int bigLength, string firstWord)
        {
            int result = 0;
            for (int i = smallLength; i < bigLength; i++)
            {
                int firstW = (int)firstWord[i];
                 result += firstW;
            }
            return result;
        }

        private static int MultyPlyingNumbers(int smallLength,string firstWord,string secondWord)
        {
            int result = 0;
            for (int i = 0; i < smallLength; i++)
            {
                char firstWordSymbol = firstWord[i];
                char secondWordSymbol = secondWord[i];
                int firstW = (int)firstWordSymbol;
                int secondW = (int)secondWordSymbol;
                result += firstW * secondW;

            }
            return result;

        }
    }
}
