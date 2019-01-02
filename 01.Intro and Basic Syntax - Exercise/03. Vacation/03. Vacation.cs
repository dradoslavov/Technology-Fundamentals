using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double discount = 0;
            double price = 0;
            if (day == "Friday")
            {
                if (group == "Students")
                {
                    if (person >= 30)
                    {
                        discount = (person * 8.45) * 0.15;
                        price = person * 8.45;
                        price = price - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        price = person * 8.45;
                        Console.WriteLine($"Total price: {price:F2}");

                    }

                }
                else if (group == "Business")
                {
                    if (person >= 100)
                    {
                        discount = (person * 10.90) - 100.90;
                        Console.WriteLine($"Total price: {discount:F2}");
                    }
                    else
                    {
                        price = person * 10.90;
                        Console.WriteLine($"Total price: {price:F2}");

                    }
                }
                else if (group == "Regular")
                {
                    if (person >= 10 && person <= 20)
                    {
                        discount = (person * 15) * 0.05;
                        price = person * 15;
                        price = price - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        price = person * 15;
                        Console.WriteLine($"Total price: {price:F2}");

                    }

                }

            }
            else if (day == "Saturday")
            {
                if (group == "Students")
                {
                    if (person >= 30)
                    {
                        discount = (person * 9.8) * 0.15;
                        price = person * 9.8;
                        price = price - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        price = person * 9.8;
                        Console.WriteLine($"Total price: {price:F2}");

                    }

                }
                else if (group == "Business")
                {
                    if (person >= 100)
                    {
                        discount = (person * 15.60) - 156;
                        Console.WriteLine($"Total price: {discount:F2}");
                    }
                    else
                    {
                        price = person * 15.6;
                        Console.WriteLine($"Total price: {price:F2}");

                    }
                }
                else if (group == "Regular")
                {
                    if (person >= 10 && person <= 20)
                    {
                        discount = (person * 20) * 0.05;
                        price = person * 20;
                        price = price - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        price = person * 20;
                        Console.WriteLine($"Total price: {price:F2}");

                    }

                }
            }
            else if (day == "Sunday")
            {
                if (group == "Students")
                {
                    if (person >= 30)
                    {
                        discount = (person * 10.46) * 0.15;
                        price = person * 10.46;
                        price = price - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        price = person * 10.46;
                        Console.WriteLine($"Total price: {price:F2}");

                    }

                }
                else if (group == "Business")
                {
                    if (person >= 100)
                    {
                        discount = (person * 16) - 160;
                        Console.WriteLine($"Total price: {discount:F2}");
                    }
                    else
                    {
                        price = person * 16;
                        Console.WriteLine($"Total price: {price:F2}");

                    }
                }
                else if (group == "Regular")
                {
                    if (person >= 10 && person <= 20)
                    {
                        discount = (person * 22.5) * 0.05;
                        price = person * 22.5;
                        price = price - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        price = person * 22.5;
                        Console.WriteLine($"Total price: {price:F2}");

                    }

                }

            }
        }
    }
}

