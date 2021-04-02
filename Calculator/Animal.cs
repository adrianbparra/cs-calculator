using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    //Abtract class - restricted that cannot be used to create objects(to access it, must be inherited from another class).
    abstract class Animal
    {
        /*
        // virtual - allows the method to be overwritten by inherited class
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
        */
        // Abstract method - only to use in abstract class, does not have a body, and is created in derived class (inherited from).
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        // overides the base class method
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        // overides the base class method
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    /// Interface
    /// it is a completly "abstract class", can only contain abstract methods and properties (with empty bodies)
    /// cannot be used to create objects
    /// need to override all of its methods
    /// cannot contain fields/ variables
    /// default abstract and public
    /// no constructor (as it cannot create objects)
    interface IAnimal
    {
        void animalSound();
    }
    interface IMammal
    {
        void coldBlooded();
    }
    /*
     * enums can be out side classes
    enum Level
    {
        Low,
        Medium,
        High
    }
    */
    // Implement multiple interfaces
    class Cat : IAnimal, IMammal
    {

        // Enum
        // special "class" represents a group of constants (unchangeable/read-only variables)
        enum Level
        {
            Low,
            Medium,
            High
        }
        // enumerations
        enum Months
        {
            January = 1,
            Februrary, // 2
            March,      // 3
            April,      // 4 values update according to January that was assign to 1
            May,
            June,
            July,
            August,
            September
        }

        public void monthBorn()
        {

            // Can be used in switch statments
            Months month = Months.January;

            switch (month)
            {
                case Months.January:
                    break;
                case Months.Februrary:
                    break;
                case Months.March:
                    break;
            }
        }
        
        

        Level myLevel = Level.Medium;
        int levelInt = (int)Level.Low; // will have value of 0

        // When implemented from interface override is not needed
        public void animalSound()
        {
            Console.WriteLine("The cat says: Meow Meow");
        }
        public void coldBlooded()
        {
            
        }

    }





    
}
