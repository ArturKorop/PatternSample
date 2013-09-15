using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Code.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            CurrentDescription = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}