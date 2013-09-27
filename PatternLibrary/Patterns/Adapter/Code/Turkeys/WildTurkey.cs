using Common.Code;
using PatternLibrary.Patterns.Adapter.Interface;

namespace PatternLibrary.Patterns.Adapter.Code.Turkeys
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            "Gobble gobble".P();
        }

        public void Fly()
        {
            "I'm flying a short distance".P();
        }
    }
}