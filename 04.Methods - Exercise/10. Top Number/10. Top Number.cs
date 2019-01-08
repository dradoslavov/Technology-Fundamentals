using System;


namespace _10.Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 8; i < range; i++)
            {
                bool divisibleBy8 = divisible(i);
                bool containOdd = OddNumber(i);
                if (containOdd&&divisibleBy8)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool OddNumber(int i)
        {
            while (i!=0)
            {
                int digit = i % 10;
                i /= 10;
                if (digit % 2==1)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool divisible(int i)
        {
            int sum = 0;

            while (i!=0)
            {
                int digit = i % 10;
                i /= 10;
                sum += digit;
             
            }
            if (sum % 8 ==0)
            {
                return true;
            }
            return false;
        }
    }
}
