using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseStudents = new Dictionary<string, List<string>>();
            Dictionary<string, int> courseCount = new Dictionary<string, int>();
            string course = null;
            string students = null;
            
            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0]=="end")
                {
                    break;
                }
                course = input[0];
                students = input[1];
                if (courseStudents.ContainsKey(course) == false)
                {
                    courseStudents[course] = new List<string>();
                    courseStudents[course].Add(students);
                    courseCount[course] = 1;
                }
                else
                {
                    courseStudents[course].Add(students);
                    courseCount[course]++;

                }
                
            }
            foreach (var item in courseCount.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
                courseStudents[item.Key].Sort();
                var counts = courseStudents[item.Key];
                for (int i = 0; i < courseStudents[item.Key].Count; i++)
                {
                    Console.Write($"{counts[i]}" + " ");
                }
            }

        }
    }
}
