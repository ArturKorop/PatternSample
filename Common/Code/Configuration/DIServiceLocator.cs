using Microsoft.Practices.Unity;

namespace Common.Code.Configuration
{
    public static class DIServiceLocator
    {
        private static IUnityContainer _container = new UnityContainer();

        public static void SetLocator(IUnityContainer container)
        {
            _container = container;
        }

        public static IUnityContainer Current
        {
            get { return _container; }
        }
    }
}