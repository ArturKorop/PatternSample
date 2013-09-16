using System;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternLibrary.Patterns.Observer.Code;
using Microsoft.Practices.Unity;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class ObserverTests
    {
        private static string _verifyResult;

        [TestInitialize]
        public void Init()
        {
            DIServiceLocator.SetLocator(new UnityContainer());

            var mockITextProvider = new Mock<ITextProvider>();
            mockITextProvider.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>())).Callback
                <string, object[]>((format, args) =>
                    {
                        _verifyResult = String.Format(format, args);
                    });

            mockITextProvider.Setup(x => x.Wait());

            DIServiceLocator.Current.RegisterInstance(typeof (ITextProvider), mockITextProvider.Object);
            Support.Configure();
        }

        [TestMethod]
        public void WeatherDataAndCurrentConditionalDisplayTest()
        {
            Init();
            var weatherData = new WeatherData();
            var weatherDisplay = new CurrentConditionalDisplay(weatherData);

            _verifyResult = null;
            weatherData.SetMeasurements(10, 10, 10);
            Assert.IsFalse(String.IsNullOrEmpty(_verifyResult));
            Assert.AreEqual(_verifyResult, String.Format("Current conditions: {0}F degrees and {1}% humidity", 10,
                                                         10));
        }

        [TestMethod]
        public void WeatherDataAndStatisticDisplayTest()
        {
            Init();
            var weatherData = new WeatherData();
            var statisticDisplay = new StatisticDisplay(weatherData);

            _verifyResult = null;
            weatherData.SetMeasurements(10, 10, 10);
            Assert.IsFalse(String.IsNullOrEmpty(_verifyResult));
            Assert.AreEqual(_verifyResult, String.Format("Average pressure: {0}", 10));
        }
    }
}