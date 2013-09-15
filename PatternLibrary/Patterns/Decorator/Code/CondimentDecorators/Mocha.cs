using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Code.CondimentDecorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description
        {
            get { return Beverage.Description + ", Mocha"; }
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }
    }
}