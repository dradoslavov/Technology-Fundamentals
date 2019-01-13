using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> nameAndPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageAndCount = new Dictionary<string, int>();
            int points = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }
                string[] examInfo = input.Split('-');
                string name = examInfo[0];
                string language = examInfo[1];
                if (examInfo.Length==2)
                {
                    nameAndPoints.Remove(name);
                    continue;
                }
                else
                {
                    points = int.Parse(examInfo[2]);

                }


                if (nameAndPoints.ContainsKey(name)==false)
                {

                    nameAndPoints[name] = points;
                }
                else
                {

                    if (points>nameAndPoints[name])
                    {
                        nameAndPoints[name] = points;
                    }
                }
                if (languageAndCount.ContainsKey(language)==false)
                {
                    languageAndCount[language] = 1;
                }
                else
                {
                    languageAndCount[language] ++;
                }
                

            }
            foreach (var kvp in nameAndPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine("Results:");
                Console.WriteLine($"{kvp.Value} | {kvp.Key}");
            }
            foreach (var kvp in languageAndCount.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine("Submissions:");
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
