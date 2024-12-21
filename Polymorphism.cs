using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // Base class for run-time polymorphism
    public class Animals
    {
        // Virtual method to be overridden in derived classes
        public virtual void MakeSound() => Console.WriteLine("Animal sound");
    }

    public class Dogs : Animals
    {
        // Override the MakeSound method to provide specific implementation for Dog
        public override void MakeSound() => Console.WriteLine("Barking");
    }

    public class Cats : Animals
    {
        // Override the MakeSound method to provide specific implementation for Cat
        public override void MakeSound() => Console.WriteLine("Meowing");
    }

    // Class for compile-time polymorphism
    public class MathOperations
    {
        // Method overloading: Add method with integer parameters
        public int Add(int a, int b) => a + b;

        // Method overloading: Add method with double parameters
        public double Add(double a, double b) => a + b;
    }

    class Polymorphism
    {
        public static void Run()
        {
            // Run-Time Polymorphism (Method Overriding)
            Animals myDog = new Dogs();
            Animals myCat = new Cats();

            // Call the overridden MakeSound method
            myDog.MakeSound(); // Output: Barking
            myCat.MakeSound(); // Output: Meowing

            // Compile-Time Polymorphism (Method Overloading)
            MathOperations math = new MathOperations();
            Console.WriteLine(math.Add(5, 3));       // Output: 8
            Console.WriteLine(math.Add(5.5, 3.3));   // Output: 8.8
        }
    }
}
