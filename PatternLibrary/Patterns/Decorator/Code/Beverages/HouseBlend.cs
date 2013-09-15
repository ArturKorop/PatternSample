using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Code.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            CurrentDescription = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}