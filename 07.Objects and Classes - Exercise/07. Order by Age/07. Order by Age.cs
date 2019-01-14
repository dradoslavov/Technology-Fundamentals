using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PeopleIDAge> infoList = new List<PeopleIDAge>();
            while (true)
            {
                List<string> people = Console.ReadLine().Split().ToList();
                var name = people[0];
                if (name == "End")
                {
                    break;
                }
                var id = people[1];
                int age = int.Parse(people[2]);
                PeopleIDAge peopleInfo = new PeopleIDAge(name, id, age);
                infoList.Add(peopleInfo);
            }
            foreach (var item in infoList.OrderBy(x => x.Age))
            {
                Console.WriteLine(item);
            }
        }
    }
    class PeopleIDAge
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public PeopleIDAge(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}