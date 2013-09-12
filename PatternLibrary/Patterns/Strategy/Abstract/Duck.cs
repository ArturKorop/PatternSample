using Common.Code;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace PatternLibrary.Patterns.Strategy.Abstract
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { protected get; set; }

        public IQuackBehavior QuackBehavior { protected get; set; }

        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void Swim()
        {
            "All ducks float, even decoys".P();
        }
        
    }
}