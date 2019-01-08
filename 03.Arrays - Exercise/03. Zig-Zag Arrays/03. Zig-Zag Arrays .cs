using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());



            int[] firstZigzag = new int[numberOfElements];
            int[] secondZigzag = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();



                if (i%2==0)
                {

                    firstZigzag[i] = input[0];
                    secondZigzag[i] = input[1];
                    
                }
                else
                {
                    firstZigzag[i] = input[1];
                    secondZigzag[i] = input[0];
                    
                }
            }
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write(firstZigzag[i]+ " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write(secondZigzag[i]+ " ");
            }

            
        }
    }
}
