using Common.Code.Configuration;
using Microsoft.Practices.Unity;
using PatternLibrary.Patterns.Decorator.Abstract;
using PatternLibrary.Patterns.Decorator.Interface;

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
            return Beverage.Cost() + DIServiceLocator.Current.Resolve<IPriceProvider>().GetPrice<Whip>();
        }
    }
}