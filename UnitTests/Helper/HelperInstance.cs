using System;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;
using Moq;

namespace UnitTests.Helper
{
    public static class HelperInstance
    {
        public static string Result;

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

        public static ITextProvider GetTestTextProvider()
        {
            var mock = new Mock<ITextProvider>();
            mock.Setup(x => x.WriteLine(It.IsAny<string>(), It.IsAny<object[]>())).Callback<string, object[]>(
                (format, args) =>
                    {
                        Result += String.Format(format, args);
                    });
            mock.Setup(x => x.Wait());

            return mock.Object;
        }

        public static void InitClassWithITextProvider(ITextProvider provider)
        {
            DIServiceLocator.Current.RegisterInstance(typeof (ITextProvider), provider);
            Support.Configure();
        }
    }
}