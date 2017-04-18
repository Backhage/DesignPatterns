using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Subject : IObservable<int>
    {
        private List<IObserver<int>> observerCollection;
        private List<int> itemsUnderObservation;
      
        public Subject()
        {
            observerCollection = new List<IObserver<int>>();
            itemsUnderObservation = new List<int>();
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (!observerCollection.Contains(observer))
            {
                observerCollection.Add(observer);
                foreach (var i in itemsUnderObservation)
                {
                    observer.OnNext(i);
                }
            }
            return new Unsubscriber(observerCollection, observer);
        }

        public void AddItem(int item)
        {
            if (!itemsUnderObservation.Contains(item))
            {
                itemsUnderObservation.Add(item);
                foreach (var observer in observerCollection)
                {
                    observer.OnNext(item);
                }
            }
        }

        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<int>> observerCollection;
            private readonly IObserver<int> observer;

            public Unsubscriber(List<IObserver<int>> observerCollection, IObserver<int> observer)
            {
                this.observerCollection = observerCollection;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observerCollection.Contains(observer))
                {
                    observerCollection.Remove(observer);
                }
            }
        }
    }
}
