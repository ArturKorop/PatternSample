using PatternLibrary.Patterns.CompositePatterns.Abstract;
using PatternLibrary.Patterns.CompositePatterns.Code.AdditionalAnimals;

namespace PatternLibrary.Patterns.CompositePatterns.Code.Adapters
{
    public class GooseAdapter : AbstractDuck
    {
        private readonly Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public override void Quack()
        {
            _goose.Honk();
            NotifyObservers();
        }
    }
}