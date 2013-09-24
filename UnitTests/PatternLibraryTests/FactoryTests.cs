using System;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternLibrary.Patterns.Factory.Abstract;
using PatternLibrary.Patterns.Factory.Code.IngredientFactories;
using PatternLibrary.Patterns.Factory.Code.Ingredients.ICheeses;
using PatternLibrary.Patterns.Factory.Code.Ingredients.IClams;
using PatternLibrary.Patterns.Factory.Code.Ingredients.IDoughs;
using PatternLibrary.Patterns.Factory.Code.Ingredients.ISauces;
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
            Assert.IsTrue(target is CheesePizza);
            Assert.AreEqual(target.Name, "Chicago Style Cheese Pizza");

            store = new NYPizzaStyleStore();
            target = store.CreatePizza(PizzaType.Cheese);
            Assert.IsTrue(target is CheesePizza);
            Assert.AreEqual(target.Name, "New York Style Cheese Pizza");
        }

        [TestMethod]
        public void ChicagoPizzaStoreTest()
        {
            PizzaStore store = new ChicagoPizzaStore();
            store.OrderPizza(PizzaType.Cheese);

            Assert.AreEqual(_verifyResult,
                            "Preparing: Chicago Style Cheese PizzaBake for 25 minutes at 350Cutting the pizza into square slicesPlace pizza in official PizzaStore box");
            
            _verifyResult = String.Empty;
            store.OrderPizza(PizzaType.Clam);

            Assert.AreEqual(_verifyResult,
                            "Preparing: Chicago Style Clam PizzaBake for 25 minutes at 350Cutting the pizza into square slicesPlace pizza in official PizzaStore box");
        }

        [TestMethod]
        public void NYPizzaStoreTest()
        {
            PizzaStore store = new NYPizzaStyleStore();
            store.OrderPizza(PizzaType.Cheese);

            Assert.AreEqual(_verifyResult,
                            "Preparing: New York Style Cheese PizzaBake for 25 minutes at 350Cutting the pizza into square slicesPlace pizza in official PizzaStore box");

            _verifyResult = String.Empty;
            store.OrderPizza(PizzaType.Clam);

            Assert.AreEqual(_verifyResult,
                            "Preparing: New York Style Clam PizzaBake for 25 minutes at 350Cutting the pizza into square slicesPlace pizza in official PizzaStore box");
        }

        [TestMethod]
        public void ChicagoIngredientFactory()
        {
            var factory = new ChicagoPizzaIngredientFactory();

            Assert.IsTrue(factory.CreateCheese() is ReggianoCheese);
            Assert.IsTrue(factory.CreateClam() is FrozenClam);
            Assert.IsTrue(factory.CreateSauce() is PlumTomatoSauce);
            Assert.IsTrue(factory.CreateDough() is ThickCrustDough);
        }

        [TestMethod]
        public void NYPizzaIngredientFactory()
        {
            var factory = new NYPizzaIngredientFactory();

            Assert.IsTrue(factory.CreateCheese() is MozzarellaCheese);
            Assert.IsTrue(factory.CreateClam() is FreshClam);
            Assert.IsTrue(factory.CreateSauce() is MarinaraSauce);
            Assert.IsTrue(factory.CreateDough() is ThinCrustDough);
        }
    }
}