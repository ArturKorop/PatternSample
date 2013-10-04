using Common.Code;
using PatternLibrary.Patterns.CompositePatterns.Abstract;

namespace PatternLibrary.Patterns.CompositePatterns.Code.IQuackables
{
    public class RubberDuck : AbstractDuck
    {
        public override void Quack()
        {
            "Squeak".P();
            NotifyObservers();
        }
    }
}