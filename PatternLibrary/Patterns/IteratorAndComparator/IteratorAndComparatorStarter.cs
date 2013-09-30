using Common.Code;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator
{
    [Runnable(true)]
    public class IteratorAndComparatorStarter
    {
        public static void Start()
        {
            var waitress = new Waitress();
            waitress.PrintMenu();
        }
    }
}