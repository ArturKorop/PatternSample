using PatternLibrary.Patterns.CompositePatterns.Abstract;
using PatternLibrary.Patterns.CompositePatterns.Interface;

namespace PatternLibrary.Patterns.CompositePatterns.Code.Decorators
{
    public class QuackCounter : AbstractDuck
    {
        private readonly IQuackable _duck;
        private static int _numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            Name = duck.Name;
        }

        public override void Quack()
        {
            _duck.Quack();
            _numberOfQuacks++;
            NotifyObservers();
        }

        public static int GetQuacks()
        {
            return _numberOfQuacks;
        }
    }
}