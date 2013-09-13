using Common.Code;
using PatternLibrary.Patterns.Strategy.Abstract;
using PatternLibrary.Patterns.Strategy.Code.IFlyBehaviorImpl;
using PatternLibrary.Patterns.Strategy.Code.IQuackBehaviorImpl;

namespace PatternLibrary.Patterns.Strategy.Code.DuckImpl
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new DefaultQuack();
        }

        public override void Display()
        {
            "I'm a real Mallard duck".P();
        }
    }
}