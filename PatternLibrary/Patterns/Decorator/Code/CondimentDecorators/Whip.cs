using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Code.CondimentDecorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description
        {
            get { return Beverage.Description + ", Whip"; }
        }

        public override double Cost()
        {
            return Beverage.Cost() + .10;
        }
    }
}