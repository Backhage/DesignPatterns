using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Observer : IObserver<int>
    {
        protected readonly List<int> items;
        private IDisposable cancellation;

        public Observer()
        {
            items = new List<int>();
        }

        public void Subscribe(Subject subject)
        {
            cancellation = subject.Subscribe(this);
        }

        public void Unsubscribe()
        {
            cancellation.Dispose();
            items.Clear();
        }

        public void OnCompleted()
        {
            items.Clear();
        }

        public void OnError(Exception error)
        {
        }

        public abstract void OnNext(int value);
    }
}
