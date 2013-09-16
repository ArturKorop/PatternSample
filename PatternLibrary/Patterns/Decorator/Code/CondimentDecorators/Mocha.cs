using Common.Code.Configuration;
using Microsoft.Practices.Unity;
using PatternLibrary.Patterns.Decorator.Abstract;
using PatternLibrary.Patterns.Decorator.Interface;

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
            return DIServiceLocator.Current.Resolve<IPriceProvider>().GetPrice<Mocha>() + Beverage.Cost();
        }
    }
}