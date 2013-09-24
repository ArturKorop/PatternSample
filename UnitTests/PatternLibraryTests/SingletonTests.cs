using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternLibrary.Patterns.Singleton.Code;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonTest()
        {
            var lastFill = false;
            var lastDrain = true;
            var verifyResult = true;
            var mockITextProvider = new Mock<ITextProvider>();
            mockITextProvider.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>())).Callback<string, object[]>((format, args)=>
            {
                if (format.Contains("Fill"))
                {
                    if (!lastFill)
                        lastFill = true;
                    else
                        verifyResult = false;
                }
                else if (format.Contains("Drain"))
                {
                    if (!lastDrain)
                        lastDrain = true;
                    else
                        verifyResult = false;
                }
            });
            DIServiceLocator.Current.RegisterInstance(typeof (ITextProvider), mockITextProvider.Object);
            Support.Configure();

            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int current = i;
                Task.Factory.StartNew(() =>
                {
                    ChocolateBoiler.Instance.Fill(current.ToString(CultureInfo.InvariantCulture));
                    Thread.Sleep(rand.Next(1000));
                    ChocolateBoiler.Instance.Drain(current.ToString(CultureInfo.InvariantCulture));
                });
            }

            Assert.IsTrue(verifyResult);
            mockITextProvider.Verify(x=>x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()),Times.Exactly(6));
        }
    }
}