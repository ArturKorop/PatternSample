using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Code.CondimentDecorators
{
    public class Soy :CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description
        {
            get { return Beverage.Description + ", Soy"; }
        }

        public override double Cost()
        {
            return Beverage.Cost() + .15;
        }
    }
}