using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Common.Code;
using PatternLibrary.Patterns.Singleton.Code;

namespace PatternLibrary.Patterns.Singleton
{
    [Runnable()]
    public class SingletonStarter
    {
        public static void Start()
        {
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
        } 
    }
}