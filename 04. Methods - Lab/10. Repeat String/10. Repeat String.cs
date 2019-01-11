using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            string numberText = number.ToString();


            int result = GetMultipleOfEvenAndOdds(numberText);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(string numberText)
        {
            int evenDigitsSum = GetSumOfEvenAndOddDigits(numberText, 0);
            int oddDigitSSum = GetSumOfEvenAndOddDigits(numberText, 1);

            return evenDigitsSum * oddDigitSSum;
        }

        private static int GetSumOfEvenAndOddDigits(string numberText, int factor)
        {
            int sum = 0;
            for (int i = 0; i < numberText.Length; i++)
            {
                int digit = numberText[i] - 48;

                if (digit % 2 == factor)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}