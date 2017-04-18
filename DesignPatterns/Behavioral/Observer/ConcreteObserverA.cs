using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserverA : Observer
    {
        public override void OnNext(int value)
        {
            Console.WriteLine($"ConcreteObserverA observed value: {value}");
            items.Add(value);
        }
    }
}
