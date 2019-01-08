using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            long firstFactorial = FindFactorial(num1);
            long secondFactorial = FindFactorial(num2);
            Console.WriteLine($"{(double)firstFactorial / secondFactorial:F2}");

        }

        static long FindFactorial(int num1)
        {
            long factorial = num1;
            for (int i = 1; i < num1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
