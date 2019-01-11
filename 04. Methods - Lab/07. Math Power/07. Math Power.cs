using System;

namespace _07._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = MathPower(a, power);
            Console.WriteLine(result);
        }

        private static double MathPower(double a, double power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}