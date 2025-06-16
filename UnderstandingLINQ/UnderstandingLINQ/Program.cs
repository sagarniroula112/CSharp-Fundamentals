using System;
using System.Collections.Generic;
using System.Linq;
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

            foreach(var car in hondas)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            */


            // LINQ method
            var hondas = cars.Where(p => p.Make == "Honda" && p.Year == 2023);

            foreach (var car in hondas)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
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
