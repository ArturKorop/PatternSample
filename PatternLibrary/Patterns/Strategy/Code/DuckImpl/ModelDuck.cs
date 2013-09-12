using Common.Code;
using PatternLibrary.Patterns.Strategy.Abstract;
using PatternLibrary.Patterns.Strategy.Code.IFlyBehaviorImpl;
using PatternLibrary.Patterns.Strategy.Code.IQuackBehaviorImpl;

namespace PatternLibrary.Patterns.Strategy.Code.DuckImpl
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new DefaultQuack();
        }

        public override void Display()
        {
            "I'a a model duck".P();
        }
    }
}