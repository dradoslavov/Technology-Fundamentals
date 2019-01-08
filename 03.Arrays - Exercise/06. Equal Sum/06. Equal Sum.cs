using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isEqual = false;
            for (int i = 0; i < array.Length; i++)
            {
                leftSum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                leftSum -= array[i];
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                    return;
                }
                rightSum += array[i];
            }
            if (isEqual==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
