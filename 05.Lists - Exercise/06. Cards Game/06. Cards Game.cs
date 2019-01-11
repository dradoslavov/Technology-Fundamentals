using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstPlayerCard.Count!=0&&secondPlayerCard.Count!=0)
            {
                int firstPlayerCards = firstPlayerCard[0];
                int secondPlayerCards = secondPlayerCard[0];
                if (firstPlayerCards>secondPlayerCards)
                {
                    RemoveCards(firstPlayerCard, secondPlayerCard);

                    firstPlayerCard.Add(firstPlayerCards);
                    firstPlayerCard.Add(secondPlayerCards);
                }
                else if (firstPlayerCards<secondPlayerCards)
                {
                    RemoveCards(firstPlayerCard, secondPlayerCard);
                    secondPlayerCard.Add(secondPlayerCards);
                    secondPlayerCard.Add(firstPlayerCards);

                }
                else
                {
                    RemoveCards(firstPlayerCard, secondPlayerCard);
                }

            }
            if (firstPlayerCard.Count>0)
            {
                int sum = firstPlayerCard.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondPlayerCard.Count>0)
            {
                 int sum = secondPlayerCard.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
        
        private static void RemoveCards(List<int> firstPlayerCard, List<int> secondPlayerCard)
        {
            firstPlayerCard.RemoveAt(0);
            secondPlayerCard.RemoveAt(0);
            
        }
    }
}
