using Common.Code;
using PatternLibrary.Patterns.CompositePatterns.Interface;

namespace PatternLibrary.Patterns.CompositePatterns.Code.Observers
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            "Quackologist: {0} just quacked".P(duck.ToString());
        }
    }
}