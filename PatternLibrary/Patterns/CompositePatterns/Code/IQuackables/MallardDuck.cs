using Common.Code;
using PatternLibrary.Patterns.CompositePatterns.Abstract;

namespace PatternLibrary.Patterns.CompositePatterns.Code.IQuackables
{
    public class MallardDuck : AbstractDuck
    {
        public override void Quack()
        {
            "Quack".P();
            NotifyObservers();
        }
    }
}