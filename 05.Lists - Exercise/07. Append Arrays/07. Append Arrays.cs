using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            list.Reverse();
            foreach  ( var number in list)
            {
                string[] reverse = number.Split(' ');
                foreach (var item in reverse)
                {
                    if (item != ""  )
                    {
                        result.Add(item);

                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
