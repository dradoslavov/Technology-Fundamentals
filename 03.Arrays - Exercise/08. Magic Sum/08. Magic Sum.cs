using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int SumNum = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                firstNum = array[i];
                for (int j = i; j < array.Length-1; j++)
                {
                    secondNum = array[j + 1];
                    int pairs = firstNum + secondNum;
                    if (pairs==SumNum)
                    {
                        Console.WriteLine($"{firstNum} {secondNum}");
                        break;
                    }

                }
            }
        }
    }
}
