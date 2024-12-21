

namespace OOPSConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a design pattern to run:");
            Console.WriteLine("1. Encapsulation");
            Console.WriteLine("2. Inheritance");
            Console.WriteLine("3. Polymorphism");
            Console.WriteLine("4. Abstraction");

            // Add more opt
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Encapsulation.Run();
                    break;
                case "2":
                    Inheritance.Run();
                    break;
                case "3":
                    Polymorphism.Run();
                    break;
                case "4":
                    Abstraction.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

