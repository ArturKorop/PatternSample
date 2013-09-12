using Common.Code;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace PatternLibrary.Patterns.Strategy.Code.IFlyBehaviorImpl
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            "I can't fly".P();
        }
    }
}