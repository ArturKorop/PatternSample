using System.Collections.Generic;
using PatternLibrary.Patterns.CompositePatterns.Interface;

namespace PatternLibrary.Patterns.CompositePatterns.Code.Observers
{
    public class Observable : IQuackObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly IQuackObservable _duck;
 
        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}