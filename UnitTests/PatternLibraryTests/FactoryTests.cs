using System;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternLibrary.Patterns.Factory.Abstract;
using PatternLibrary.Patterns.Factory.Code.PizzaStores;
using PatternLibrary.Patterns.Factory.Code.Pizzas;
using PatternLibrary.Patterns.Factory.Enum;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class FactoryTests
    {
        private static string _verifyResult;

        [ClassInitialize]
        public static void InitTestClass(TestContext context)
        {
            var mockITextProvider = new Mock<ITextProvider>();
            mockITextProvider.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()))
                             .Callback<string, object[]>((format, args) =>
                             {
                                 _verifyResult += String.Format(format, args);
                             });
            mockITextProvider.Setup(x => x.Wait());

            DIServiceLocator.Current.RegisterInstance(typeof(ITextProvider), mockITextProvider.Object);
            Support.Configure();
        }

        [TestInitialize]
        public void InitTest()
        {
            _verifyResult = String.Empty;
        }

        [TestMethod]
        public void FactoryTest()
        {
            PizzaStore store = new ChicagoPizzaStore();
            var target = store.CreatePizza(PizzaType.Cheese);

            Assert.IsTrue(target is ChicagoStyleCheesePizza);

            store = new NYPizzaStyleStore();
            target = store.CreatePizza(PizzaType.Cheese);

            Assert.IsTrue(target is NYStyleCheesePizza);
        }

        [TestMethod]
        public void ChicagoPizzaStoreTest()
        {
            PizzaStore store = new ChicagoPizzaStore();
            store.OrderPizza(PizzaType.Cheese);

            Assert.AreEqual(_verifyResult,
                            "Preparing Chicago Style Deep Dish Cheese PizzaTossing dough...Adding souce...Adding toppings:    Shredded Mozarella CheeseBake for 25 minutes at 350Cutting the pizza into square slicesPlace pizza in official PizzaStore box");
            
            _verifyResult = String.Empty;
            store.OrderPizza(PizzaType.Veggie);

            Assert.AreEqual(_verifyResult,
                            "Preparing Chicago Style Veggie PizzaTossing dough...Adding souce...Adding toppings:    Shredded Mozarella CheeseBake for 25 minutes at 350Cutting the pizza into square slicesPlace pizza in official PizzaStore box");
        }

        [TestMethod]
        public void NYPizzaStoreTest()
        {
            PizzaStore store = new NYPizzaStyleStore();
            store.OrderPizza(PizzaType.Cheese);

            Assert.AreEqual(_verifyResult,
                            "Preparing NY Style Sauce and Cheese PizzaTossing dough...Adding souce...Adding toppings:    Grated Reggiano CheeseBake for 25 minutes at 350Cutting the pizza into diagonal slicesPlace pizza in official PizzaStore box");

            _verifyResult = String.Empty;
            store.OrderPizza(PizzaType.Veggie);

            Assert.AreEqual(_verifyResult,
                            "Preparing NY Style Veggie PizzaTossing dough...Adding souce...Adding toppings:    Grated Reggiano CheeseBake for 25 minutes at 350Cutting the pizza into diagonal slicesPlace pizza in official PizzaStore box");
        }
    }
}