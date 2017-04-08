using DesignPatterns.Creational.Abstract_Factory;
using DesignPatterns.Creational.Prototype;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creational Patterns
            DemonstrateAbstractFactory();
            DemonstratePrototype();
        }

        private static void DemonstrateAbstractFactory()
        {
            var client = new Client
            {
                // The version can be a setting in the settings system, or depending on the environment.
                VersionToCreate = Client.Version.One 
            };
            var productA = client.CreateProductA(); // Creates an instance of type ProductA1
            productA.PrintProductName();

            client.VersionToCreate = Client.Version.Two;
            var productB = client.CreateProductB(); // Creates an instance of type ProductB2
            productB.PrintProductName();
        }

        private static void DemonstratePrototype()
        {
            // First create the prototypes
            var p1 = new ConcretePrototype1("One");
            var p2 = new ConcretePrototype2("Two");

            // Then these can be cloned whenever you need a new object with the same data
            var c1 = p1.Clone();
            var c2 = p2.Clone();

            Console.WriteLine($"Clone of type: {c1.Id}"); // This will have Id "One"
            Console.WriteLine($"Clone of type: {c2.Id}"); // and this "Two"
        }
    }
}
