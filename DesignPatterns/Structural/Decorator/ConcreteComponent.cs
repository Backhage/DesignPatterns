using System;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent Operation");
        }
    }
}
