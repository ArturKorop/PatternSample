using Common.Code;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace PatternLibrary.Patterns.Strategy.Code.IFlyBehaviorImpl
{
    public class FlyWithWIngs : IFlyBehavior
    {
        public void Fly()
        {
            "I can fly in the sky".P();
        }
    }
}