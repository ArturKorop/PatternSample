using Common.Code;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace PatternLibrary.Patterns.Strategy.Code.IFlyBehaviorImpl
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            "I'm flyling with a rocket".P();
        }
    }
}