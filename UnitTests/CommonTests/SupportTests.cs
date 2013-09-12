using System.Xml.Linq;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.CommonTests
{
    [TestClass]
    public class SupportTests
    {
        private readonly Mock<ITextProvider> _textProviderMockFirst = new Mock<ITextProvider>();
        private readonly Mock<ITextProvider> _textProviderMockSecond = new Mock<ITextProvider>();

        [TestInitialize]
        public void Init()
        {
            _textProviderMockFirst.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()));
            _textProviderMockFirst.Setup(x => x.Wait());

            _textProviderMockSecond.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()));
            _textProviderMockSecond.Setup(x => x.Wait());
        }

        [TestMethod]
        public void SupportInitializeTest()
        {
            DIServiceLocator.Current.RegisterInstance(typeof(ITextProvider), _textProviderMockFirst.Object);
            "Test".Print();
            _textProviderMockFirst.Verify(x=>x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()), Times.Once());
            "Test2".Print();
            _textProviderMockFirst.Verify(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()), Times.Exactly(2));

            DIServiceLocator.Current.RegisterInstance(typeof(ITextProvider), _textProviderMockSecond.Object);
            "Test3".Print();
            "Test4".Print();
            _textProviderMockFirst.Verify(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()), Times.Exactly(4));

            Support.Configure();
            "Test5".Print();
            _textProviderMockSecond.Verify(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()), Times.Once());
            "Test6".Print();
            _textProviderMockSecond.Verify(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()), Times.Exactly(2));

            _textProviderMockFirst.Verify(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()), Times.Exactly(4));
        }

        [TestMethod]
        public void ToXmlTest()
        {
            var source = new TestClass {I = 5, S = "Test"};
            var target = source.ToXml();

            XNamespace ns1 = "http://www.w3.org/2001/XMLSchema-instance";
            XNamespace ns2 = "http://www.w3.org/2001/XMLSchema";
            var example = new XElement("TestClass", new XAttribute(XNamespace.Xmlns + "xsi", ns1),
                                       new XAttribute(XNamespace.Xmlns + "xsd", ns2), new XElement("I", 5),
                                       new XElement("S", "Test"));
            Assert.IsTrue(XNode.DeepEquals(target, example));
            Assert.AreEqual(target.ToString(), example.ToString());

            const string exampleString =
                "<TestClass xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <I>5</I>\r\n  <S>Test</S>\r\n</TestClass>";
            Assert.AreEqual(target.ToString(), exampleString);
        }

        [TestMethod]
        public void FromXmlTest()
        {
            
        }

        public class TestClass
        {
            public int I { get; set; }
            public string S { get; set; }
        }
    }

    
}