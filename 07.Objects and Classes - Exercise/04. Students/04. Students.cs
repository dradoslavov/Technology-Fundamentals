using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
                List<Students> studentsInfoGrade = new List<Students>();

            for (int i = 0; i < number; i++)
            {
                List<string> studentsInfo = Console.ReadLine().Split().ToList();
                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                string grade = studentsInfo[2];

                Students student = new Students(firstName, lastName, grade);
                studentsInfoGrade.Add(student);
            }
            foreach (var item in studentsInfoGrade.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine(item);
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
        public Students(string firstName, string lastName , string grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }

    }
}
