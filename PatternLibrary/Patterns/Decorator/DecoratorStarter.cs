using Common.Code;
using PatternLibrary.Patterns.Decorator.Abstract;
using PatternLibrary.Patterns.Decorator.Code.Beverages;
using PatternLibrary.Patterns.Decorator.Code.CondimentDecorators;
using PatternLibrary.Patterns.Decorator.Code.Support;

namespace PatternLibrary.Patterns.Decorator
{
    [Runnable(true)]
    public class DecoratorStarter
    {
        public static void Start()
        {
            Beverage beverage = new Espresso();
            "{0} ${1}".P(beverage.Description, beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = beverage2.AddComponent<Mocha>();
            beverage2 = beverage2.AddComponent<Mocha>();
            beverage2 = beverage2.AddComponent<Whip>();
            "{0} ${1}".P(beverage2.Description, beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            "{0} ${1}".P(beverage3.Description, beverage3.Cost());
        }
    }
}