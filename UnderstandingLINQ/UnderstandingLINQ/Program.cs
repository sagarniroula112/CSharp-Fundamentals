using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car { VIN = "A1", Make = "Toyota", Model = "Corolla", Year = 2020, StickerPrice = 20000 },
                new Car { VIN = "B2", Make = "Honda", Model = "Civic", Year = 2021, StickerPrice = 22000 },
                new Car { VIN = "C3", Make = "Ford", Model = "Mustang", Year = 2022, StickerPrice = 35000 },
                new Car { VIN = "D4", Make = "Chevrolet", Model = "Malibu", Year = 2019, StickerPrice = 18000 },
                new Car { VIN = "E5", Make = "Honda", Model = "Model 3", Year = 2023, StickerPrice = 40000 }
            };

            // LINQ query
            /*
            var hondas = from car in cars
                         where car.Make == "Honda"
                         && car.Year == 2023
                         select car;

            var orderedCars = from car in cars
                              orderby car.Year descending
                              select car;

            */

            var newCars = from car in cars
                          where car.Make == "Honda"
                          && car.Year == 2023
                          select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            // LINQ method

            // var hondas = cars.Where(p => p.Make == "Honda" && p.Year == 2023);
            // var orderedCars = cars.OrderByDescending(p => p.Year);
            // var firstHonda = cars.First(p => p.Make == "Honda");
            // Console.WriteLine(cars.TrueForAll(p => p.Year > 2020));

            // cars.ForEach(p => p.StickerPrice -= 3000);
            // cars.ForEach(c => Console.WriteLine("{0} {1:C}", c.VIN, c.StickerPrice));

            // Console.WriteLine(cars.Exists(p => p.Model == "BMW"));
            // Console.WriteLine(cars.Sum(p => p.StickerPrice));

            //Console.WriteLine(cars.GetType());

            // foreach (var car in orderedCars)
            // {
            //    Console.WriteLine("{0} {1}", car.Model, car.Year);
            // }
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
