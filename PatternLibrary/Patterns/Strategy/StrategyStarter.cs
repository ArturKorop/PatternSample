using Common.Code;
using PatternLibrary.Patterns.Strategy.Code.DuckImpl;
using PatternLibrary.Patterns.Strategy.Code.IFlyBehaviorImpl;

namespace PatternLibrary.Patterns.Strategy
{
    [Runnable]
    public class StrategyStarter
    {
        public static void Start()
        {
            var mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            var model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}