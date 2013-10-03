using Common.Code;
using PatternLibrary.Patterns.Proxy.Code;

namespace PatternLibrary.Patterns.Proxy
{
    /// <summary>
    /// For running this pattern need doing some steps:
    /// 1) Build PatternProxyStarter
    /// 2) Copy files from build folder of PatternProxyStarter to other place
    /// 3) Run PatternProxyStarter.exe
    /// 4) Check, that adderess in PatternProxyStarter equals address in GumballMonitor
    /// 5) Run ProxyStarter and see results of its work
    /// </summary>
    [Runnable]
    public class ProxyStarter
    {
        public static void Start()
        {
            var monitor = new GumballMonitor();
            monitor.PrintStatus();
            monitor.GetGumball();
            monitor.GetGumball();
            monitor.GetGumball();
            monitor.PrintStatus();
        } 
    }
}