using Common.Code;
using Common.Code.Configuration;
using Microsoft.Practices.Unity;
using PatternLibrary.Patterns.Decorator.Abstract;
using PatternLibrary.Patterns.Decorator.Code.Beverages;
using PatternLibrary.Patterns.Decorator.Code.Common;
using PatternLibrary.Patterns.Decorator.Code.CondimentDecorators;
using PatternLibrary.Patterns.Decorator.Code.Support;
using PatternLibrary.Patterns.Decorator.Interface;

namespace PatternLibrary.Patterns.Decorator
{
    [Runnable]
    public class DecoratorStarter
    {
        public static void Start()
        {
            DIServiceLocator.Current.RegisterInstance<IPriceProvider>(new ComponentCosts());

            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            "{0} ${1}".P(beverage.Description, beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = beverage2.AddComponent<Mocha>();
            beverage2 = beverage2.AddComponent<Mocha>();
            beverage2 = beverage2.AddComponent<Whip>();
            "{0} ${1}".P(beverage2.Description, beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            SupportExtensions.AddComponent<Soy>(ref beverage3);
            SupportExtensions.AddComponent<Mocha>(ref beverage3);
            SupportExtensions.AddComponent<Whip>(ref beverage3);
            "{0} ${1}".P(beverage3.Description, beverage3.Cost());
        }
    }
}