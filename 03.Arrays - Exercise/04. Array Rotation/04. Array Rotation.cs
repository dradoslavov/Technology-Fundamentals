using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] reverseNum = new int[input.Length];
            int rotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                reverseNum[i] = int.Parse(input[i]);
            }
            for (int i = 0; i < rotation; i++)
            {
                int firstNum = reverseNum[0];
                for (int j = 0; j < reverseNum.Length-1; j++)
                {
                    reverseNum[j] = reverseNum[j + 1];
                }
                reverseNum[reverseNum.Length - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ",reverseNum));
        }
    }
}
