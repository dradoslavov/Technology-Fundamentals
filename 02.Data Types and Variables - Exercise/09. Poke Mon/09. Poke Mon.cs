using System;
using System.Numerics;

namespace _09._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int pokedTarget = 0;
            BigInteger tempN = N;

            while (N >= M)
            {
                N = N - M;
                pokedTarget++;
                if (tempN - N == N)
                {
                    if (Y != 0)
                    {
                        N = N / Y;
                    }

                }
            }

            Console.WriteLine($"{N}");
            Console.WriteLine($"{pokedTarget}");
        }
    }
}