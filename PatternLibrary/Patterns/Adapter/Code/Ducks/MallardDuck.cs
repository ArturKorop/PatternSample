using Common.Code;
using PatternLibrary.Patterns.Adapter.Interface;

namespace PatternLibrary.Patterns.Adapter.Code.Ducks
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            "Quack".P();
        }

        public void Fly()
        {
            "I'm flying".P();
        }
    }
}