using System;
using System.Numerics;

namespace _08._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBallNumber = int.Parse(Console.ReadLine());
            int snowBallSnow = 0;
            int snowBallTime = 0;
            int snowBallQuality = 0;
            int snowBallSnowMax = 0;
            int snowBallTimeMax = 0;
            int snowBallQualityMax = 0;
            BigInteger snowBallValue = 0;
            BigInteger snowBallValueMax = 0;
            for (int i = 0; i < snowBallNumber; i++)
            {
                snowBallSnow = int.Parse(Console.ReadLine());
                snowBallTime = int.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());
                snowBallValue = snowBallSnow / snowBallTime;
                snowBallValue = BigInteger.Pow(snowBallValue, snowBallQuality);

                if (snowBallValue > snowBallValueMax)
                {
                    snowBallSnowMax = snowBallSnow;
                    snowBallTimeMax = snowBallTime;
                    snowBallQualityMax = snowBallQuality;
                    snowBallValueMax = snowBallValue;
                }
            }
            Console.WriteLine($"{snowBallSnowMax} : {snowBallTimeMax} = {snowBallValueMax} ({snowBallQualityMax})");

        }
    }
}