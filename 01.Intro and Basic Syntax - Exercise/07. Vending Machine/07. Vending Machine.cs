using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            decimal money = 0;
            while (true)
            {
                command = Console.ReadLine();

                if (command == "Start")
                {
                    break;
                }
                decimal coin = decimal.Parse(command);
                if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m)
                {
                    money += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }


            }
            while (true)
            {


                string drink = Console.ReadLine().ToLower();
                if (drink == "end")
                {
                    Console.WriteLine($"Change: {money:F2}");

                    break;
                }    

                if (drink == "nuts")
                {
                    if (money < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                    else
                    {
                        money -= 2;

                        Console.WriteLine("Purchased nuts");
                        

                    }
                }
                else if (drink == "water")
                {
                    if (money < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        

                    }
                    else
                    {
                        money -= 0.7m;

                        Console.WriteLine("Purchased water");
                        
                    }


                }
                else if (drink == "crisps")
                {
                    if (money < 1.5m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        

                    }
                    else
                    {
                        money -= 1.5m;

                        Console.WriteLine("Purchased crisps");
                        
                    }

                }
                else if (drink == "soda")
                {
                    if (money < 0.8m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        

                    }
                    else
                    {
                        money -= 0.8m;

                        Console.WriteLine("Purchased soda");
                        

                    }

                }
                else if (drink == "coke")
                {
                    if (money < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                       

                    }
                    else
                    {
                        money -= 1.0m;

                        Console.WriteLine("Purchased coke");
                        
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");

                }


            }

        }

    }
}
