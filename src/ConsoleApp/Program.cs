using System;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadWrite();
            //Variables();
            //Operators();
            //Maths();
            //Strings();
            //Booleans();
            //Conditions();
            //Switch();
            //Loops();
            //Arrays();
            //Functions();
            //Classes();
            //Polymorphism();
            //Abstraction();
            //Enums();
            //Files();
            //Exceptions();
        }


        static void ReadWrite()
        {
            Console.WriteLine("Hello World!");
            Console.Write("Welcome to Maharishi International University.");

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Username is: " + username);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }

        static void Variables()
        {
            // Variables
            int i = 2147483647;
            long l = -9223372036854775808L;
            float f = 1.123456F;
            double d = 19.1234567890123D;
            char c = 'A';
            string s = "Hello James";
            bool b = true;

            // Constants
            const int ci = 15;

            // Scientific Numbers 
            // "e" to indicate(илтгэх) power of 10
            float f1 = 35e3F; // 35 * 1000
            double d1 = 12E4D; // 12 * 10000

            // Implicit casting
            int myInt = 9;
            double myDouble = myInt;

            // Explicit casting
            myDouble = 9.78;
            myInt = (int)myDouble;

            // Conversion methods
            Convert.ToString(i);
            Convert.ToDouble(i);
            Convert.ToInt32(d); // int
            Convert.ToInt64(d); // long
            Convert.ToString(b);
        }

        static void Operators()
        {
            int x = 11;
            int y = 3;

            // Modulus
            Console.WriteLine(x % y); // Returns the division remainder

            // Multiply
            Console.WriteLine(x * y);
        }

        static void Maths()
        {
            Console.WriteLine(Math.Max(1, 3));
            Console.WriteLine(Math.Sqrt(64)); // 8
            Console.WriteLine(Math.Abs(-3));
            Console.WriteLine(Math.Round(9.49)); // 9
            Console.WriteLine(Math.Round(9.5)); // 10
        }

        static void Strings()
        {
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            // Concatenation (Нийлүүлэх)
            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            // Interpolation (Хэлхэх)
            name = $"My full name is {firstName} {lastName}";
            Console.WriteLine(name);

            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"

            Console.WriteLine(myString.IndexOf("o"));

            name = "John Doe";
            int charPos = name.IndexOf("D");
            lastName = name.Substring(charPos); // charPos-оос хойших

            txt = "We are the so-called \"Vikings\" from the north.";
            txt = "It\'s alright.";
            txt = "The character \\ is called backslash.";
        }

        static void Booleans()
        {
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y); // true
        }

        static void Conditions()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

        }

        static void Switch()
        {
            int day = 4;
            switch (day)
            {
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }

        static void Loops()
        {
            // While
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            // For
            for (i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            string[] cars = { "Volvo", "BMW", "Ford" };
            foreach (string el in cars)
            {
                Console.WriteLine(el);
            }

            for (i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                    continue;
                }
            }

            i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }

        static void Arrays()
        {
            string[] cars = { "Volvo", "BMW" };
            int[] ages = { 10, 20 };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);


            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Array.Sort(ages);
            foreach (int i in ages)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(ages.Max());
            Console.WriteLine(ages.Sum());

            string[] arr = new string[4] { "A", "B", "C", "D" };
            string[] ar = new string[] { "a" };
            string[] a = { "a" };
        }

        static void Functions()
        {
            MyMethod("A");
            int myNum1 = PlusMethodInt(8, 5);
            Console.WriteLine("Int: " + myNum1);
        }

        static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        {
            Console.WriteLine(child1);
            Console.WriteLine(child2);
            Console.WriteLine(child3);
        }

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static void Classes()
        {
            Car car = new Car();
            car.Model = "Mustang";
            car.Year = 2005;
            car.Color = "red";
            car.MaxSpeed = 200;
            //car.owner = "Jagaa";

            car.FullThrottle();
            car.Honk();
        }

        static void Polymorphism() // Олон хэлбэрт байдал
        {
            // virtual, override
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.AnimalSound();
            myPig.AnimalSound();
            myDog.AnimalSound();
        }

        static void Abstraction()
        {
            P myPig = new P(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }

        enum Level
        {
            Low,
            Medium,
            High
        }

        enum Months
        {
            January,    // 0
            February,   // 1
            March = 6,    // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

        static void Enums()
        {
            Level myVar = Level.Medium;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }

            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }

        static void Files()
        {
            string writeText = "Hello Maharishi";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
        }

        static void Exceptions()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]); // error!
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }

    public sealed class Plane
    {
        public string Brand { get; set; }
    }

    public class Vehicle //: Plane
    {
        public string Brand { get; set; } = "Ford";
        public void Honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    public class Car : Vehicle
    {
        public string Model { get; set; } // Automatic Properties (Short Hand)
        public int Year { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }
        private string owner { get; set; }
        public string Owner // Properties
        {
            get { return owner; }
            set { owner = value; }
        }

        public Car()
        {
            Model = "Mustang";
        }

        public Car(string modelName)
        {
            Model = modelName;
        }

        public void FullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    public class Animal  // Base class (parent) 
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Pig : Animal  // Derived class (child) 
    {
        new public void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public class Dog : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    abstract class A
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class P : A
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    //An interface is a completely "abstract class", which can only contain abstract methods and properties(with empty bodies) :
    interface IAn
    {
        void animalSound(); // interface method (does not have a body)
        void run(); // interface method (does not have a body)
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    class Pi : IAn, ISecondInterface
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }

        public void myOtherMethod()
        {
            throw new NotImplementedException();
        }

        public void run()
        {
            throw new NotImplementedException();
        }
    }
}
