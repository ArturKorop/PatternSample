using Common.Code;
using PatternLibrary.Patterns.Adapter.Code.Adapters;
using PatternLibrary.Patterns.Adapter.Code.Ducks;
using PatternLibrary.Patterns.Adapter.Code.Turkeys;

namespace PatternLibrary.Patterns.Adapter
{
    [Runnable]
    public class AdapterStarter
    {
        public static void Start()
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();
            var turkeyLikeDuck = new TurkeyAdapter(turkey);

            duck.Quack();
            duck.Fly();

            turkey.Gobble();
            turkey.Fly();

            turkeyLikeDuck.Quack();
            turkeyLikeDuck.Fly();
        }
    }
}