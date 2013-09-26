using System;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternLibrary.Patterns.Command.Code;
using PatternLibrary.Patterns.Command.Interface;
using UnitTests.Helper;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class CommandTests
    {
        readonly RemoteControl _remoteControl = new RemoteControl();

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            DIServiceLocator.Current.RegisterInstance(typeof(ITextProvider), HelperInstance.EmptyTextProvider);
            Support.Configure();
        }

        [TestMethod]
        public void RemoteControlInitTest()
        {
            var mockOn = new Mock<ICommand>();
            mockOn.Setup(x => x.Exequte());
            mockOn.Setup(x => x.Undo());
            var mockOff = new Mock<ICommand>();
            mockOn.Setup(x => x.Exequte());
            mockOn.Setup(x => x.Undo());
            _remoteControl.SetCommand(3, mockOn.Object, mockOff.Object);

            _remoteControl.OnButtonPushed(1);
            _remoteControl.OffButtonPushed(4);
            _remoteControl.OnButtonPushed(6);
            _remoteControl.UndoButtonPushed();
            _remoteControl.OnButtonPushed(3);
            _remoteControl.OffButtonPushed(3);
            _remoteControl.OnButtonPushed(2);
            _remoteControl.OnButtonPushed(3);
            _remoteControl.UndoButtonPushed();
            _remoteControl.UndoButtonPushed();
            _remoteControl.UndoButtonPushed();

            mockOn.Verify(x=>x.Exequte(), Times.Exactly(2));
            mockOff.Verify(x=>x.Exequte(), Times.Once());
            mockOn.Verify(x => x.Undo(), Times.Once());
            mockOff.Verify(x => x.Undo(), Times.Once());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OnButtonPressedTest1()
        {
            _remoteControl.OnButtonPushed(8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OnButtonPressedTest2()
        {
            _remoteControl.OnButtonPushed(7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OnButtonPressedTest3()
        {
            _remoteControl.OnButtonPushed(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OnButtonPressedTest4()
        {
            _remoteControl.OnButtonPushed(-7);
        }
    }
}