using Common.Code;
using PatternLibrary.Patterns.TemplateMethod.Code.Caffeines;

namespace PatternLibrary.Patterns.TemplateMethod
{
    [Runnable]
    public class TemplateMethodStarter
    {
        public static void Start()
        {
            var tea = new Tea();
            var coffee = new Coffee();
            tea.PrepareReceipt();
            coffee.PrepareReceipt();
        }
    }
}