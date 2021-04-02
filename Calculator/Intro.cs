using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Intro
    {
        static void MainIntro(string[] args)
        {
            Console.WriteLine("Hello World");
            // This is a comment
            // Hey this is wierd using Visual Studio and not Visual Studio Code
            /*
             * This is to
             * write a
             * multi-line
               comment
               stars are not
             * needed but 
             * look nicer
             */
            // we have different type of variables than python
            // whole number without decimals
            int integer = 12;
            // floating point numbers with decimals
            double doubles = 12.4;
            // single characters such as 'a' or 'A' with single quotes
            char character = 'A';
            // stores text surrounded by double quotes
            string strings = "Adrian";
            // stores a boolean of two state: true or false
            bool boolean = true;

            // a varible can be declared without assigning a value
            string noValue;
            noValue = "Value added";

            // const varaibles need to be given a value
            const int NoChangeNumber = 32;
            // NoChangeNumber = 43
            // above will give an error

            //conbining variables
            Console.WriteLine("Hello " + strings);

            // give varables unique names
            string minutesPerHour = "60";
            // Names are case sensitive ("myVar" and "myvar" are different variables)
            // Reserved words (like C# keywords, such as int or double) cannot be used as names

            // more variables types

            // 8 bytes number (end with L)
            long longNumber = 334L;
            // fractional number(end with F) 
            float floatNumber = 4.5453F;

            // int(for whole numbers) and double (for floating point numbers) are most used

            // implicit (smaller to larger type)
            // char -> int -> long -> float -> double
            int myInt = 9;
            double myDouble = myInt;

            // explicit (larger to smaller)
            // double -> float -> long -> int -> char 
            double newMyDouble = 4.54;
            int newInt = (int)newMyDouble;

            // built-in methods to convert explicitly
            int anInt = 42;

            Console.WriteLine(Convert.ToString(anInt));

            // Get User Input

            // readLine returns a string
            /*
             * 
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}");

            */
            // Arithmetic Operators
            /*
                +	Addition	    Adds together two values	x + y	
                -	Subtraction	    Subtracts one value from another	x - y	
                *	Multiplication	Multiplies two values	x * y	
                /	Division	    Divides one value by another	x / y	
                %	Modulus	        Returns the division remainder	x % y	
                ++	Increment	    Increases the value of a variable by 1	x++	
                --	Decrement       Decreases the value of a variable by 1	x--
            */

            // Assignment Operators
            /*
                 =	x = 5	x = 5	
                +=	x += 3	x = x + 3	
                -=	x -= 3	x = x - 3	
                *=	x *= 3	x = x * 3	
                /=	x /= 3	x = x / 3	
                %=	x %= 3	x = x % 3	
                &=	x &= 3	x = x & 3	
                |=	x |= 3	x = x | 3	
                ^=	x ^= 3	x = x ^ 3	
                >>=	x >>= 3	x = x >> 3	
                <<=	x <<= 3	x = x << 3

            */

            // Comparison Operators
            /*
                ==	Equal to	x == y	
                !=	Not equal	x != y	
                >	Greater than	x > y	
                <	Less than	x < y	
                >=	Greater than or equal to	x >= y	
                <=	Less than or equal to	x <= y
    
            */

            // Logical Operators

            /*
                && 	Logical and	    Returns true if both statements are true	x < 5 &&  x < 10	
                || 	Logical or	    Returns true if one of the statements is true	x < 5 || x < 4	
                !	Logical not	    Reverse the result, returns false if the result is true	!(x < 5 && x < 10)
             
            */

            // Math
            //Math has many methods to perform mathematical tasks on numbers

            // find the highest value between 2 values
            Console.WriteLine(Math.Max(4, 7));

            //Strings

            string myString = "Hello";

            // Access string value
            Console.WriteLine(myString[2]);
            // l

            // If ... Else

            //Ternary Operators
            // variable = (condition) ? expressionTrue : expressionFalse;

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            // Arrays
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] numbers = { 2, 3, 4, 5, 6 };

            string firstCar = cars[0];

            cars[0] = "Chevy";

            //Sort array
            Array.Sort(cars);
            //Create Arrays
            /*
                // Create an array of four elements, and add values later
                string[] cars = new string[4];

                // Create an array of four elements and add values right away 
                string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

                // Create an array of four elements without specifying the size 
                string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

                // Create an array of four elements, omitting the new keyword, and without specifying the size
                string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
             */


            // Loops

            // foreach loop through elements in an array
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }


            WriteName("Adrian", 28);

            Console.WriteLine(MyAge(1993));

            // arguemnts it key: value pairs, order does not matter

            Students(student1: "Adrian", student2: "Rolando");

            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);


            /// Classes ///

            Car corvette = new Car("Corvete", "Manual");
            Car Colorado = new Car("Colorado", "Automatic");
            // assign field if left blank
            corvette.model = "corvette";
            corvette.SalesPrices = 42000;

            Console.WriteLine(corvette.SalesPrices);

            Console.WriteLine(corvette.color);
            Console.WriteLine(corvette.maxSpeed);

            // Methods
            corvette.fullThrottle();



        }

        // Methods
        // Are block of codes , pass data (parameters) , known as functions
        //static means that the method belongs to the Program class and not an object of the Program class. 
        //void means that this method does not have a return value. 
        static void WriteName(string fname, int age)
        {
            // Code to be executed
            Console.WriteLine(fname + " Refsnes");
            Console.WriteLine("Age: " + age);


        }

        static void DefaultParameter(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        // Returning Methods
        // Instead of void use a primitive data type  ex : ( int, double, string, ...)

        static int MyAge(int year)
        {
            return DateTime.Now.Year - year;
        }

        static void Students(string student1, string student2)
        {
            Console.WriteLine("");
        }

        // Overloading MEthods 
        // nameing methods same name but return differnt types

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }




    }

    // Classes 
    /*
    class Car
    {
        public string color = "red";

    //  Constructor //
    // for the car class
        public Car()
        {
           model = "Mustang"; // Set the initial value for model
        }
        
    }
    */
}

