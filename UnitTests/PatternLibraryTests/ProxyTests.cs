using Common.Code;
using Common.Code.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternProxy;
using UnitTests.Helper;

namespace UnitTests.PatternLibraryTests
{
    [TestClass]
    public class ProxyTests
    {
        [ClassInitialize]
        public static void InitClass(TestContext context)
        {
            HelperInstance.InitClassWithITextProvider(new ConsoleTextProvider());
        }

        [TestMethod]
         public void InitProxyTest()
        {
            var service = new MainService();
            service.GetStatus().P();
            service.GetGumball();
            service.GetStatus().P();
        }
    }
}