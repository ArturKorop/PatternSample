using PatternLibrary.Patterns.Factory.Code.Ingredients.ICheeses;
using PatternLibrary.Patterns.Factory.Code.Ingredients.IClams;
using PatternLibrary.Patterns.Factory.Code.Ingredients.IDoughs;
using PatternLibrary.Patterns.Factory.Code.Ingredients.ISauces;
using PatternLibrary.Patterns.Factory.Interface;
using PatternLibrary.Patterns.Factory.Interface.Ingredients;

namespace PatternLibrary.Patterns.Factory.Code.IngredientFactories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IVeggie[] CreateVeggies()
        {
            throw new System.NotImplementedException();
        }

        public IClam CreateClam()
        {
            return new FreshClam();
        }

        public IPepperoni CreatePepperoni()
        {
            throw new System.NotImplementedException();
        }
    }
}