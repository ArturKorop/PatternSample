using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using PatternLibrary.Patterns.TemplateMethod.Abstract;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class TemplateMethodTests
    {
        [ClassInitialize]
        public static void InitClass(TestContext context)
        {
            Helper.HelperInstance.InitClassWithITextProvider(Helper.HelperInstance.EmptyTextProvider);
        }

        [TestMethod]
        public void TemplateMethodTest()
        {
            var mockCaffeineBeverage = new Mock<CaffeineBeverage>();
            mockCaffeineBeverage.Protected().Setup<bool>("CustomerWantsCondiments").Returns(true);
            var target = mockCaffeineBeverage.Object;
            target.PrepareReceipt();

            mockCaffeineBeverage.Protected().Verify("Brew", Times.Once());
            mockCaffeineBeverage.Protected().Verify("AddCondiments", Times.Once());
            mockCaffeineBeverage.Protected().Verify("CustomerWantsCondiments", Times.Once());
        }
    }
}