using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserverB : Observer
    {
        public override void OnNext(int value)
        {
            Console.WriteLine($"ConcreteObserverB observed value: {value}");
            items.Add(value);
        }
    }
}
