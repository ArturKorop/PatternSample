using Common.Code;
using PatternLibrary.Patterns.CompositePatterns.Code.Common;
using PatternLibrary.Patterns.CompositePatterns.Code.Factories;

namespace PatternLibrary.Patterns.CompositePatterns
{
    [Runnable]
    public class CompositeStarter
    {
        public static void Start()
        {
            var simulator = new DuckSimulator();
            simulator.Simulate(new CountingDuckFactory());
        } 
    }
}