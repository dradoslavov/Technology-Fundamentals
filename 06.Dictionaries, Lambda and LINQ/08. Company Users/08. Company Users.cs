using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> companyEmployee = new Dictionary<string, List<string>>();
            while (true)
            {
                string inputString = Console.ReadLine();

                if (inputString == "End")
                {
                    break;
                }
                string [] input = inputString.Split("->");
                    string employee = input[1];
                string company = input[0];

                if (companyEmployee.ContainsKey(input[0])==false)
                {
                    companyEmployee[company] = new List<string>();
                    companyEmployee[company].Add(employee);                    
                }
                else
                {
                    if (!companyEmployee[company].Contains(employee))
                    {
                        companyEmployee[company].Add(employee);
                    }
                }
            }
            foreach (var words in companyEmployee.OrderBy(x => x.Key))
            {

                Console.WriteLine(words.Key);

                foreach (var definitions in words.Value.OrderByDescending(x => x.Length))
                {
                    Console.WriteLine($"--{definitions}");
                }

            }
        }
    }
}
