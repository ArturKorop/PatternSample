using Common.Code;
using PatternLibrary.Patterns.TemplateMethod.Abstract;

namespace PatternLibrary.Patterns.TemplateMethod.Code.Caffeines
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            "Steeping the tea".P();
        }

        protected override void AddCondiments()
        {
            "Adding Lemon".P();
        }

        protected override bool CustomerWantsCondiments()
        {
            return false;
        }
    }
}