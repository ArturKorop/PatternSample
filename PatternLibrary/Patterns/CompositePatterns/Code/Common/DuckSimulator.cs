using Common.Code;
using PatternLibrary.Patterns.CompositePatterns.Abstract;
using PatternLibrary.Patterns.CompositePatterns.Code.Adapters;
using PatternLibrary.Patterns.CompositePatterns.Code.AdditionalAnimals;
using PatternLibrary.Patterns.CompositePatterns.Code.Composite;
using PatternLibrary.Patterns.CompositePatterns.Code.Decorators;
using PatternLibrary.Patterns.CompositePatterns.Code.Observers;

namespace PatternLibrary.Patterns.CompositePatterns.Code.Common
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory factory)
        {
            var flockOfDucks = new Flock();
            flockOfDucks.Add(factory.CreateMallardDuck());
            flockOfDucks.Add(factory.CreateRedheadDuck());
            flockOfDucks.Add(factory.CreateDuckCall());
            flockOfDucks.Add(factory.CreateRubberDuck());
            flockOfDucks.Add(new QuackCounter(new GooseAdapter(new Goose())));

            var flockOfMallards = new Flock();
            for (int i = 0; i < 4; i++)
            {
                flockOfMallards.Add(factory.CreateMallardDuck());
            }

            flockOfDucks.Add(flockOfMallards);

            "Duck Simulator with Observer\n--------------------------------".P();
            var quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);
            flockOfDucks.Quack();
            "Mallard Simulator\n--------------------------------".P();
            flockOfMallards.Quack();
            "--------------------------------\nThe ducks quacked {0} times".P(QuackCounter.GetQuacks());
        }
    }
}