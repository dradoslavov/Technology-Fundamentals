using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bombN = bomb[0];
            int range = bomb[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber==bombN)
                {
                    int startNumber = i - range;
                    int finishNumber = i + range;
                    if (startNumber<0)
                    {
                        startNumber = 0;
                    }
                    if (finishNumber>numbers.Count-1)
                    {
                        finishNumber = numbers.Count-1;
                    }
                    numbers.RemoveRange(startNumber, finishNumber-startNumber+1);
                    i = 0;
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);


        }
    }
}
