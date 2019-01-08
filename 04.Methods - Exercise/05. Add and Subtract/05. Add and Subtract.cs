using System;

namespace _05.Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = SumNums(num1, num2);
            
            Console.WriteLine(sumNumbers(sum, num3));

        }

        static int sumNumbers(int sum, int num3)
        {
            return sum - num3;
        }

        static int SumNums(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
