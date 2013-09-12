using Common.Code;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace PatternLibrary.Patterns.Strategy.Code.IQuackBehaviorImpl
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            "Squeal".P();
        }
    }
}