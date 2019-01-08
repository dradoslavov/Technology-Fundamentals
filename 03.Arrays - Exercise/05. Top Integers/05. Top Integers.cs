using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];
                    if (firstNum<=secondNum)
                    {
                        break;
                    }
                    else if (j==numbers.Length-1)
                    {
                        Console.Write(firstNum + " ");
                    }

                }
            }
            Console.Write(numbers[numbers.Length - 1]);

        }
    }
}
