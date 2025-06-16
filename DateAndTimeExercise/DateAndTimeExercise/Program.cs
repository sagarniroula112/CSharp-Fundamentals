using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Basics

            Console.WriteLine(myValue);
            Console.WriteLine(myValue.ToShortDateString()); // MM/DD/YYYY
            Console.WriteLine(myValue.ToShortTimeString()); // Only hours and minutes
            Console.WriteLine(myValue.ToLongDateString()); // Day, Month name, Date, Year
            Console.WriteLine(myValue.ToLongTimeString()); // seconds as well


            //Say we want to add some time

            Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // adding days
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); // adding hours
            Console.WriteLine(myValue.AddDays(-4).ToLongDateString()); // subtracting days

            Console.WriteLine(myValue.Month);

            DateTime myBirthDay = new DateTime(2001, 10, 26);
            DateTime myBirthDay2 = DateTime.Parse("10/26/2001");
            Console.WriteLine(myBirthDay.ToShortDateString());

            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
            Console.WriteLine(myAge.TotalDays); // Counting how many days you have lived. You can do more.

        }
    }
}
