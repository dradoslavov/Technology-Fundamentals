using System;
using System.Collections.Generic;
using System.Reflection;

public class Program
{

    public static void Main()
    {
        {

            int count = 0;
            string Str, reversestring = "";
            int Length;
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + Str[Length];
                Length--;
            }
            while (count<3)
            {
                string password = Console.ReadLine();
                count++;

                if (reversestring == password)
                {
                    Console.WriteLine($"User {Str} logged in.");
                    break;
                }
                else
                {

                    Console.WriteLine("Incorrect password. Try again.");
                    if (count == 3)
                    {
                        Console.WriteLine($"User {Str} blocked!");
                    }

                }
                
            }
        }
    }
}