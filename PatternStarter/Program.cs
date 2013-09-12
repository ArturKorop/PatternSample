using System.Linq;
using System.Reflection;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;

namespace PatternStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Configure();

            Assembly assembly = Assembly.Load("PatternLibrary");
            var types = assembly.GetTypes();
            foreach (var start in from type in types
                                  let attributes = (from attr in type.GetCustomAttributes(false)
                                                    where attr is RunnableAttribute
                                                    let temp = attr as RunnableAttribute
                                                    select temp)
                                  from start in
                                      (from attribute in attributes
                                       where attribute.IsRunnable
                                       select type.GetMethod("Start"))
                                  select start)
            {
                start.Invoke(null, null);
            }

            Support.Wait();
        }

        private static void Configure()
        {
            DIServiceLocator.Current.RegisterInstance(typeof(ITextProvider), new ConsoleTextProvider());
        }
    }
}
