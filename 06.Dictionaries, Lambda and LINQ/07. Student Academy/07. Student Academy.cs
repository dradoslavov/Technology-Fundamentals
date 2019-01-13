using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string name = Console.ReadLine();
                double evaluation = double.Parse(Console.ReadLine());
                if (studentGrades.ContainsKey(name)==false)
                {
                    studentGrades[name] = new List<double>();
                }
                studentGrades[name].Add(evaluation);
                studentGrades.OrderByDescending(x => x.Value);
            }
           
            foreach (var kvp in studentGrades.OrderByDescending(x =>x.Value.Average()))
            {

                if (kvp.Value.Average()>=4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
                }               
            }
        }
    }
}
