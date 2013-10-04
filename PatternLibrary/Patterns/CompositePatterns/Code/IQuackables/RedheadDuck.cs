using Common.Code;
using PatternLibrary.Patterns.CompositePatterns.Abstract;

namespace PatternLibrary.Patterns.CompositePatterns.Code.IQuackables
{
    public class RedheadDuck : AbstractDuck
    {
        public override void Quack()
        {
            "Quack".P();
            NotifyObservers();
        }
    }
}