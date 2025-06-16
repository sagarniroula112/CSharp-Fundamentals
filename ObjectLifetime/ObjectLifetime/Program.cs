using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2013;
            myCar.Color = "Black";

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Year, myOtherCar.Model, myOtherCar.Color);

            myOtherCar.Model = "Random";
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Year, myCar.Model, myCar.Color);
            // We have two references to the same object in memory.

            myOtherCar = null;
            myCar = null;
            // Object will be removed by .NET Framework Runtime.

            Car c = new Car();
            Console.WriteLine("{0} {1} {2} {3}", c.Make, c.Year, c.Model, c.Color);

            Car.MyMethod(c);
            c.MyNonMethod();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public static int Count { get; set; }

        public Car()
        {
            this.Make = "Nissan";
            this.Model = "Ford";
            this.Color = "Red";
            Count += 1;
        }

        public void MyNonMethod()
        {
            Console.WriteLine(Count);
        }

        public static void MyMethod(Car c)
        {
            Console.WriteLine("Static Method");
            Console.WriteLine(c.Make); // Static Method can have non-static properties but needs that object.
        }
    }
}
