using System;
namespace _04.Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool IsBetween6And10Symbols = CheckSymbols(password);
            if (IsBetween6And10Symbols==false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            bool ContainsOnlyDigitAndLetters = CheckSymbolsAndLetters(password);
            if (ContainsOnlyDigitAndLetters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            bool Contains2Digits = Check2Digits(password);
            if (Contains2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsBetween6And10Symbols&& ContainsOnlyDigitAndLetters&& Contains2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool Check2Digits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2 ? true : false;
        }
        static bool CheckSymbolsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsDigit(symbol)&&!char.IsLetter(symbol))
                {
                    return false;
                }                
            }
            return true;
        }

        static bool CheckSymbols(string password)
        {          
            return password.Length >= 6 && password.Length <= 10 ? true : false;
        }
    }
}
