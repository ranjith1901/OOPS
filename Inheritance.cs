using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{

    // Single Inheritance
    public class Animal
    {
        // Method to simulate eating
        public void Eat() => Console.WriteLine("Eating");
    }

    public class Dog : Animal
    {
        // Method to simulate barking
        public void Bark() => Console.WriteLine("Barking");
    }

    // Multilevel Inheritance
    public class Mammal : Animal
    {
        // Method to simulate walking
        public void Walk() => Console.WriteLine("Walking");
    }

    public class DogMultilevel : Mammal
    {
        // Method to simulate barking
        public void Bark() => Console.WriteLine("Barking");
    }

    // Hierarchical Inheritance
    public class Cat : Animal
    {
        // Method to simulate meowing
        public void Meow() => Console.WriteLine("Meowing");
    }

    // Hybrid Inheritance using Interfaces
    public interface IAnimal
    {
        // Method to simulate eating
        void Eat();
    }

    public class MammalHybrid : IAnimal
    {
        // Implement the Eat method from IAnimal
        public void Eat() => Console.WriteLine("Eating");

        // Method to simulate walking
        public void Walk() => Console.WriteLine("Walking");
    }

    public class Bird : IAnimal
    {
        // Implement the Eat method from IAnimal
        public void Eat() => Console.WriteLine("Eating");

        // Method to simulate flying
        public void Fly() => Console.WriteLine("Flying");
    }

    public class Bat : MammalHybrid, IAnimal
    {
        // Method to simulate flying
        public void Fly() => Console.WriteLine("Flying");
    }

    class Inheritance
    {
        public static void Run()
        {
            // Single Inheritance
            Dog dog = new Dog();
            dog.Eat();  // Inherited from Animal
            dog.Bark(); // Defined in Dog

            // Multilevel Inheritance
            DogMultilevel dogMultilevel = new DogMultilevel();
            dogMultilevel.Eat();  // Inherited from Animal
            dogMultilevel.Walk(); // Inherited from Mammal
            dogMultilevel.Bark(); // Defined in DogMultilevel

            // Hierarchical Inheritance
            Cat cat = new Cat();
            cat.Eat();  // Inherited from Animal
            cat.Meow(); // Defined in Cat

            // Hybrid Inheritance
            Bat bat = new Bat();
            bat.Eat();  // Implemented in MammalHybrid
            bat.Walk(); // Defined in MammalHybrid
            bat.Fly();  // Defined in Bat
        }
    }
}