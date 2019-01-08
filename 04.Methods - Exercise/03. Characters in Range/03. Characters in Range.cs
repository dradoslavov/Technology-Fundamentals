using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char lastSymbol = char.Parse(Console.ReadLine());
            AsciiSymbols(firstSymbol, lastSymbol);

        }
        static void AsciiSymbols(char firstSymbol, char lastSymbol)
        {
            for (char i = lastSymbol; i < firstSymbol; i++)
            {
                if (i==lastSymbol)
                {
                    continue;
                }                
                else
                {
                    Console.Write(i+" ");

                }
            }
            for (char i = firstSymbol; i < lastSymbol; i++)
            {
                if (i == firstSymbol)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
