using PatternLibrary.Patterns.CompositePatterns.Abstract;
using PatternLibrary.Patterns.CompositePatterns.Code.Decorators;
using PatternLibrary.Patterns.CompositePatterns.Code.IQuackables;
using PatternLibrary.Patterns.CompositePatterns.Interface;

namespace PatternLibrary.Patterns.CompositePatterns.Code.Factories
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}