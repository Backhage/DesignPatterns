using System;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB extended Operation");
        }

        public void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB added behavior");
        }
    }
}