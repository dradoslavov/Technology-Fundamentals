using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            long inputNum = long.Parse(Console.ReadLine());
            long factorialSum = 0;
            long checkNum = inputNum;

            while (checkNum != 0)
            {

                long result = checkNum % 10;
                checkNum /= 10;

                long factorial = 1;
                for (int i = 1; i <= result; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }

            if (factorialSum == inputNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}