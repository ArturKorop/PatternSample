using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Code.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            CurrentDescription = "Dark Roast";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}