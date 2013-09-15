using System;
using Common.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternLibrary.Patterns.Strategy.Abstract;
using PatternLibrary.Patterns.Strategy.Interaface;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class StartegyTests
    {
        readonly Mock<IFlyBehavior> _mockIFlyBehavior = new Mock<IFlyBehavior>();
        readonly Mock<IQuackBehavior> _mockIQuackBehavior = new Mock<IQuackBehavior>();

        [TestInitialize]
        public void Init()
        {
            _mockIFlyBehavior.Setup(x => x.Fly());
            _mockIQuackBehavior.Setup(x => x.Quack());
        }

        [TestMethod]
        public void AbstarctDuckTest()
        {
            var target = new DuckTest();
            Assert.IsNotNull(target);

            Exception exception = null;
            try
            {
                target.PerformFly();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
            Assert.IsTrue(exception is NullReferenceException);

            exception = null;
            try
            {
                target.PerformQuack();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
            Assert.IsTrue(exception is NullReferenceException);

            target.FlyBehavior = _mockIFlyBehavior.Object;
            target.QuackBehavior = _mockIQuackBehavior.Object;

            target.PerformFly();
            target.PerformQuack();

            _mockIFlyBehavior.Verify(x=>x.Fly(), Times.Once());
            _mockIQuackBehavior.Verify(x => x.Quack(), Times.Once());
        }

        public class DuckTest : Duck
        {
            public override void Display()
            {
                "I am test duck".P();
            }
        }
    }
}