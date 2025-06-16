using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
    internal class Program {

        static void greet()
        {
            Console.WriteLine("Good Morning!");
        }

        static void Main(string[] args) {

            //int harry = 34; // Integer variable

            /* DATA TYPES IN C#
            
            Integer - int harry; ---> 4 Bytes
                Long - long harry; ---> 8 Bytes

            Floating point number - float num; ---> 4 Bytes
                Double - double num; ---> 8 Bytes

            Character - char c = 'A'; ---> 2 Bytes

            Boolean - bool isGreat = true; ---> 1 Bit

            String - string inp = "Harry"; ---> 2 Bytes/Character

            */

            //string inp = Console.ReadLine(); // ReadLine() returns a string.
            //Console.WriteLine(inp);

            //Console.Write("C Sharp! ");
            //Console.WriteLine("Hello, World!");
            //Console.Write(" Learning C# ");
            //Console.WriteLine("Hello Harry " + harry);
            //Console.ReadLine();
            // Comments in C#
            // This waits for the program to exit on user input.

            // DATA TYPES EXAMPLE
            /*
            
            int a = 34;
            float b = 34.4f; // "double" is default, so i have to put 'f' or 'F' for float.
            double c = 33.3;
            char myCh = 'a';
            string myName = "Sagar";

            Console.Write(a + " " + b + " " + c + " " + myCh + " " + myName);

            */

            /*
             TYPE CASTING
             Two types:
             1.Implicit Casting
             char to int to long to float to double

            int a = 3;
            double y = a;
            // int z = y; // I can't change double to int, but I can do it opposite.
            int z = 'y';
            double x = 'z';
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(y);

            // 2. Explicit Casting

            //int a = (int)3.5;
            int x1 = (int)3.55;

            Console.ReadLine();

            */

            /*
            TYPECASTING USING INBUILT "CONVERT" CLASS

            float varr = Convert.ToInt32(3.554);
            // Convert.ToDouble
            // Convert.ToString
            Console.WriteLine(varr);

            */

            /*
            TAKING USER INPUT

            Console.Write("Enter your name:: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            */

            /*
            OPERATORS IN C#
            1. Arithmetic Operators
            2. Assignment Operators
            3. Logical Operators
            4. Comparison Operators
            

            int a = 4;
            int b = a;

            Console.WriteLine("The value of a + b is: " + (a + b));
            Console.WriteLine("The value of a - b is: " + (a - b));
            Console.WriteLine("The value of a * b is: " + (a * b));
            Console.WriteLine("The value of a / b is: " + (a / b));

            b += 4;
            b -= 1;
            b *= 4;
            b /= 4;
            Console.WriteLine(b);

            Console.WriteLine(true && false);
            Console.WriteLine(true || false);
            Console.WriteLine(!false);

            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            */

            /*
            MATH CLASS
            // Under System.Math

            //int a = Math.Min(34, 33);
            double a = Math.Sqrt(36);
            double b = Math.Abs(-39);
            Console.WriteLine(b);

            */

            /*
            STRINGS
            
            string hello = "Hello world this is Harry";
            Console.WriteLine(hello.Length);  // Length
            Console.WriteLine(hello.ToUpper());  // ToUpper()
            Console.WriteLine(hello.ToLower());  // ToLower()
            Console.WriteLine(string.Concat(hello.ToLower() + " You are nice"));  // Concatenation process

            string name = Console.ReadLine();
            string candies = Console.ReadLine();
            // STRING INTERPOLATION TECHNIQUE
            Console.WriteLine($"Your name is {name}. You will get {candies} candies.");

            string hello = "Hello wor \tld this is \" Har\nry"; // Escape sequence characters
            Console.WriteLine(hello[0]);
            Console.WriteLine(hello.IndexOf("world"));
            Console.WriteLine(hello.Substring(1, 7)); // includes 7 here don't forget this.
            Console.WriteLine(hello);
            // STRING IS IMMUTABLE.

            */

            /*
            DECISION MAKING TECHNIQUES

            int age = 18;
            if (age > 18) {
                Console.WriteLine("You can drive...");
            } else if (age >= 12) {
                Console.WriteLine("You are a teenager bro...");
            } else {
                Console.WriteLine("Do whatever you want...");
            }


            int age = 18;

            switch(age)
            {
                case 18:
                    Console.WriteLine("You are 18 years old");
                    break;

                default:
                    Console.WriteLine("You are not 18 years old bro!");
                    break;
            }

            */

            /*
            LOOPS

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }



            for (int i=0;i<5;i++)
            {
                Console.WriteLine(i);
            }


            int i = 0;
            do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i < 5);

            */

            /*
             BREAK and CONTINUE
             break --> exit out of the loop please
             continue --> exit the current iteration please and start another iteration

            for(int i=0;i<5;i++)
            {
                if(i==0)
                {
                    continue;
                }

                Console.WriteLine(i + 1);
            }

            */

            /*
            METHODS IN C#

            */
            greet();
            greet();
        }
    }
}
