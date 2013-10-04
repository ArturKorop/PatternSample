using Common.Code;
using PatternLibrary.Patterns.CompositePatterns.Abstract;

namespace PatternLibrary.Patterns.CompositePatterns.Code.IQuackables
{
    public class DuckCall : AbstractDuck
    {
        public override void Quack()
        {
            "Kwak".P();
            NotifyObservers();
        }
    }
}