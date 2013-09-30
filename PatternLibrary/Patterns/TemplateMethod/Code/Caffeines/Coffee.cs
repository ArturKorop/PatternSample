using Common.Code;
using PatternLibrary.Patterns.TemplateMethod.Abstract;

namespace PatternLibrary.Patterns.TemplateMethod.Code.Caffeines
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            "Dripping Coffee through filter".P();
        }

        protected override void AddCondiments()
        {
            "Adding Sugar and Milk".P();
        }

        protected override bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}