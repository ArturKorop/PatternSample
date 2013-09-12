using Common.Code;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace PatternLibrary.Patterns.Strategy.Code.IQuackBehaviorImpl
{
    public class DefaultQuack : IQuackBehavior
    {
        public void Quack()
        {
            "quack quack quack".P();
        }
    }
}