using Common.Code;

namespace PatternLibrary.Patterns.TemplateMethod.Abstract
{
    public abstract class CaffeineBeverage
    {
        public void PrepareReceipt()
        {
            BoilWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments())
                AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected abstract bool CustomerWantsCondiments();

        private void BoilWater()
        {
            "Boiling water".P();
        }

        private void PourInCup()
        {
            "Pouring into cup".P();
        }
    }
}