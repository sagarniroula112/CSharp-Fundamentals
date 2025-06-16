using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car { VIN="A1", Make = "Toyota", Model = "Corolla" };
            Car car2 = new Car { VIN="B2", Make = "Honda", Model = "Civic" };

            Book b1 = new Book { Title = "The Alchemist", Author = "Paulo Coelho", ISBN = "978-0061122415" };

            //Console.WriteLine($"Car1: {car1.Make} {car1.Model}");
            //Console.WriteLine($"Car2: {car2.Make} {car2.Model}");
            //Console.WriteLine($"Book: \"{b1.Title}\" by {b1.Author} (ISBN: {b1.ISBN})");
            */

            /*
            // ArrayLists are dynamically-sized.
            // Cool features like sorting, remove
            ArrayList myList = new ArrayList();
            myList.Add(car1);
            myList.Add(car2);
            myList.Add(b1);
            myList.Remove(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            
            foreach(Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDict = new Dictionary<string, Car>();
            myDict.Add(car1.VIN, car1);
            myDict.Add(car2.VIN, car2);

            Console.WriteLine(myDict["B2"].Make);
            */

            string[] names = {"Bob", "Steve", "Brian"};
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
