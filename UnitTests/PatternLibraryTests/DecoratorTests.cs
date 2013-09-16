using Common.Code.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternLibrary.Patterns.Decorator.Abstract;
using PatternLibrary.Patterns.Decorator.Code.Beverages;
using PatternLibrary.Patterns.Decorator.Code.Common;
using PatternLibrary.Patterns.Decorator.Code.CondimentDecorators;
using PatternLibrary.Patterns.Decorator.Code.Support;
using PatternLibrary.Patterns.Decorator.Interface;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        public void DecoratorTest()
        {
            DIServiceLocator.Current.RegisterInstance<IPriceProvider>(new ComponentCosts());

            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            Assert.AreEqual(beverage.Description, "Espresso, Mocha");
            Assert.AreEqual(beverage.Cost(), 2.19);

            Beverage beverage2 = new DarkRoast();
            beverage2 = beverage2.AddComponent<Mocha>();
            beverage2 = beverage2.AddComponent<Mocha>();
            beverage2 = beverage2.AddComponent<Whip>();
            Assert.AreEqual(beverage2.Description, "Dark Roast, Mocha, Mocha, Whip");
            Assert.AreEqual(beverage2.Cost(), 1.49);

            Beverage beverage3 = new HouseBlend();
            SupportExtensions.AddComponent<Soy>(ref beverage3);
            SupportExtensions.AddComponent<Mocha>(ref beverage3);
            SupportExtensions.AddComponent<Whip>(ref beverage3);
            Assert.AreEqual(beverage3.Description, "House Blend Coffee, Soy, Mocha, Whip");
            Assert.AreEqual(beverage3.Cost(), 1.34);
        }
    }
}