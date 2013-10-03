using Common.Code.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternLibrary.Patterns.State.Code.Common;
using PatternLibrary.Patterns.State.Interface;
using UnitTests.Helper;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class StateTests
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            HelperInstance.InitClassWithITextProvider(new ConsoleTextProvider());
        }

        [TestMethod]
        public void StateWorkingTest()
        {
            IGumballMachine gumballMachine = new GumballMachine(20, "TestGumballMachine");

            for (int i = 0; i < 20; i++)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
            }

            Assert.AreEqual((gumballMachine as GumballMachine).Count, 0);
        }

        [TestMethod]
        public void StateEjectTest()
        {
            IGumballMachine gumballMachine = new GumballMachine(10, "TestGumballMachine");

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQarter();
            gumballMachine.TurnCrank();

            Assert.AreEqual((gumballMachine as GumballMachine).Count, 10);
        }

        [TestMethod]
        public void StateAddGumballsTest()
        {
            IGumballMachine gumballMachine = new GumballMachine(10, "TestGumballMachine");

            for (int i = 0; i < 10; i++)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
            }

            Assert.AreEqual((gumballMachine as GumballMachine).Count, 0);

            gumballMachine.AddGumballs(10);

            Assert.AreEqual((gumballMachine as GumballMachine).Count, 10);

            for (int i = 0; i < 10; i++)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
            }

            Assert.AreEqual((gumballMachine as GumballMachine).Count, 0);
        }
    }
}