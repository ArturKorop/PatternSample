using System.Collections.Generic;
using Common.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternLibrary.Patterns.Adapter.Code.Adapters;
using PatternLibrary.Patterns.Adapter.Code.Ducks;
using PatternLibrary.Patterns.Adapter.Interface;
using UnitTests.Helper;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class AdapterTests
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            HelperInstance.InitClassWithITextProvider(HelperInstance.GetTestTextProvider());
        }

        [TestMethod]
        public void AdapterTest()
        {
            var duck = new MallardDuck();
            var turkeyOne = new Mock<ITurkey>();
            turkeyOne.Setup(x => x.Gobble()).Callback(() => " I'm a turkeyOne gobble ".P());
            turkeyOne.Setup(x => x.Fly()).Callback(() => " I'm a turkeyOne flying ".P());
            var turkeyTwo = new Mock<ITurkey>();
            turkeyTwo.Setup(x => x.Gobble()).Callback(() => " I'm a turkeyTwo gobble ".P());
            turkeyTwo.Setup(x => x.Fly()).Callback(() => " I'm a turkeyTwo flying ".P());

            var turkeyOneLikeDuck = new TurkeyAdapter(turkeyOne.Object);
            var turkeyTwoLikeDuck = new TurkeyAdapter(turkeyTwo.Object);

            var targets = new List<IDuck> {duck, turkeyOneLikeDuck, turkeyTwoLikeDuck};

            foreach (var target in targets)
            {
                target.Quack();
                target.Fly();
            }

            Assert.AreEqual(HelperInstance.Result,
                            "QuackI'm flying I'm a turkeyOne gobble  I'm a turkeyOne flying  I'm a turkeyOne flying  I'm a turkeyOne flying  I'm a turkeyOne flying  I'm a turkeyOne flying  I'm a turkeyTwo gobble  I'm a turkeyTwo flying  I'm a turkeyTwo flying  I'm a turkeyTwo flying  I'm a turkeyTwo flying  I'm a turkeyTwo flying ");
            turkeyOne.Verify(x=>x.Fly(), Times.Exactly(5));
            turkeyOne.Verify(x => x.Gobble(), Times.Once());
            turkeyTwo.Verify(x => x.Fly(), Times.Exactly(5));
            turkeyTwo.Verify(x => x.Gobble(), Times.Once());
        }
    }
}