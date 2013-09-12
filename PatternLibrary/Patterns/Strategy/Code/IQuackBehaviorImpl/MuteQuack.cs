using Common.Code;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace PatternLibrary.Patterns.Strategy.Code.IQuackBehaviorImpl
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            "<< Silence >>".P();
        }
    }
}