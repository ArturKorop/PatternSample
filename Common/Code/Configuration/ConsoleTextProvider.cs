using System;
using Common.Interfaces;

namespace Common.Code.Configuration
{
    public class ConsoleTextProvider : ITextProvider
    {
        public int Test = 0;

        public void WriteLine(string format, params object[] args)
        {
            Test++;
            Console.WriteLine(format, args);
        }

        public void Wait()
        {
            Console.ReadKey();
        }
    }
}