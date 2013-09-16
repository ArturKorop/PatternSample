using Common.Code.Configuration;
using Microsoft.Practices.Unity;
using PatternLibrary.Patterns.Decorator.Abstract;
using PatternLibrary.Patterns.Decorator.Interface;

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
            return Beverage.Cost() + DIServiceLocator.Current.Resolve<IPriceProvider>().GetPrice<Soy>();
        }
    }
}