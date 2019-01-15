using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Strings_and_Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userNames = Console.ReadLine().Split(", ").ToList();
            List<string> validUser = new List<string>();
            bool isValid = false;
            for (int i = 0; i < userNames.Count; i++)
            {
                string names = userNames[i];
                if (names.Length >= 3 && names.Length <= 16)
                {
                    isValid = validateUsers(names);
                    if (isValid)
                    {
                        validUser.Add(names);
                    }
                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, validUser));
        }

        private static bool validateUsers(string names)
        {
            foreach (char symbol in names)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
