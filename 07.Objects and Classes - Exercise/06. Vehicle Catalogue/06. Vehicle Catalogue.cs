using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.Vehicle_Catalogue
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }
    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var trucks = new List<Truck>();


            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End") break;

                string[] line = input.Split(' ').ToArray();
                var type = line[0];
                var model = line[1];
                var color = line[2];
                var horsePower = double.Parse(line[3]);
                if (type == "Car" || type == "car")
                {
                    var car = new Car() { Model = model, Color = color, Horsepower = horsePower };
                    cars.Add(car);
                }
                else if (type == "Truck" || type == "truck")
                {
                    var truck = new Truck() { Model = model, Color = color, Horsepower = horsePower };
                    trucks.Add(truck);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Close the Catalogue") break;
                var model = input;

                foreach (var item in cars)
                {
                    if (item.Model == model)
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.Horsepower}");
                    }
                }
                foreach (var item in trucks)
                {
                    if (item.Model == model)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.Horsepower}");
                    }
                }
            }

            var sumCars = 0.0;
            foreach (var item in cars)
            {
                sumCars += item.Horsepower;
            }
            var averageCars = 0.0;
            if (cars.Count > 0)
            {
                averageCars = sumCars / cars.Count;
            }
            else
            {
                averageCars = 0.0;
            }


            var sumTrucks = 0.0;
            foreach (var item in trucks)
            {
                sumTrucks += item.Horsepower;
            }
            var averageTrucks = 0.0;
            if (trucks.Count > 0)
            {
                averageTrucks = sumTrucks / trucks.Count;
            }
            else
            {
                averageTrucks = 0.0;
            }


            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");

        }
    }
}