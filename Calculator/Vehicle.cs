using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Vehicle
    {
        public int wheels = 4;
        public void honk()
        {
            Console.WriteLine("Tuut,tuut!");
        }
    }
    
              // Car inherits from Vehicle
    class Car : Vehicle
    {
        /// <summary>
        /// Access Modifiers
        /// access modifier set access level/visibility for classes, fields, methods and properties
        /// public	    The code is accessible for all classes
        /// private     The code is only accessible within the same class
        /// protected   The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
        /// internal    The code is only accessible within its own assembly, but not from another assembly.You will learn more about this in a later chapter
        /// </summary>
    
        public string color = "red";
        public int maxSpeed = 200;
        public string model;
        public string transmission;
        private int salesPrice;
        
        /// <summary>
        /// Constructor
        /// has to be called same as class
        /// Can not have a return type
        /// Can take parameters to initialize fields
        /// </summary>

        public Car( string modelName, string transmissionType)
        {
            model = modelName;
            transmission = "automatic";
        }

        /// <summary>
        /// Properties
        /// combination of variable and a method
        /// has get and set method
        /// same name as field
        /// encapsulation
        /// </summary>

        public int SalesPrices
        {
            //get { return salesPrice; }
            //set { salesPrice = value; }
            get; set;
        }

        // public allows to be accessed by objects
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    // sealed does not allow class to be inherited
    sealed class Motorcycle
    {
        //....
        
    }



}
