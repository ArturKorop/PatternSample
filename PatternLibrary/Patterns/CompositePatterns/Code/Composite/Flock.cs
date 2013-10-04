using System.Collections.Generic;
using PatternLibrary.Patterns.CompositePatterns.Abstract;
using PatternLibrary.Patterns.CompositePatterns.Interface;

namespace PatternLibrary.Patterns.CompositePatterns.Code.Composite
{
    public class Flock : AbstractDuck
    {
        private readonly List<IQuackable> _quackers = new List<IQuackable>();
        
        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public override void Quack()
        {
            foreach (var quackable in _quackers)
            {
                quackable.Quack();
            }
        }

        public override void RegisterObserver(IObserver observer)
        {
            foreach (var quackable in _quackers)
            {
                quackable.RegisterObserver(observer);
            }
        }

        public override void NotifyObservers()
        {
            foreach (var quackable in _quackers)
            {
                quackable.NotifyObservers();
            }
        }
    }
}