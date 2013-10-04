using PatternLibrary.Patterns.CompositePatterns.Code.Observers;
using PatternLibrary.Patterns.CompositePatterns.Interface;

namespace PatternLibrary.Patterns.CompositePatterns.Abstract
{
    public abstract class AbstractDuck : IQuackable
    {
        protected Observable Observable;

        protected AbstractDuck()
        {
            Observable = new Observable(this);
            Name = GetType().Name;
        }

        public string Name { get; protected set; }

        public virtual void RegisterObserver(IObserver observer)
        {
            Observable.RegisterObserver(observer);
        }

        public virtual void NotifyObservers()
        {
            Observable.NotifyObservers();
        }

        public override string ToString()
        {
            return Name;
        }

        public abstract void Quack();

    }
}