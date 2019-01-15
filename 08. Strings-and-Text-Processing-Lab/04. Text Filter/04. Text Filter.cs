using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannWord = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannWord.Length; i++)
            {
                string currentWord = new string('*', bannWord[i].Length);

                text = text.Replace(bannWord[i], currentWord);
            }

            Console.WriteLine(text);
        }
    }
}