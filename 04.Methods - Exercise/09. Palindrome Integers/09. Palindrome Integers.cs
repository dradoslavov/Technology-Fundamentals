using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "END")
                {
                    break;
                }
                string reverse = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse += word[i];
                }
                bool isPalindron = Palindron(word, reverse);
                Console.WriteLine(isPalindron==true ? "true":"false");
            }
        }

        private static bool Palindron(string word, string reverse)
        {
            
            return word == reverse;
        }
    }
}
