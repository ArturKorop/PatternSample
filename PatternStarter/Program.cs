using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;

namespace PatternStarter
{
    class Program
    {
        private static readonly UnityContainer Container = new UnityContainer();

        static void Main(string[] args)
        {
            Configure();

            Support.Wait();
        }

        private static void Configure()
        {
            DIServiceLocator.Current.RegisterInstance(typeof(ITextProvider), new ConsoleTextProvider());
        }
    }
}
