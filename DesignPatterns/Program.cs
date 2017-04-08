using DesignPatterns.Behavioral.Abstract_Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
