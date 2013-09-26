using Common.Interfaces;
using Moq;

namespace UnitTests.Helper
{
    public static class HelperInstance
    {
        public static ITextProvider EmptyTextProvider
        {
            get
            {
                var mock = new Mock<ITextProvider>();
                mock.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>()));
                mock.Setup(x => x.Wait());

                return mock.Object;
            }
        }
    }
}