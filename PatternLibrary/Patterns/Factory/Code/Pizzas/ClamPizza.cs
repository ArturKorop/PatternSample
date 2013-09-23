using Common.Code;
using PatternLibrary.Patterns.Factory.Abstract;
using PatternLibrary.Patterns.Factory.Interface;

namespace PatternLibrary.Patterns.Factory.Code.Pizzas
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            "Preparing: {0}".P(Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clam = _ingredientFactory.CreateClam();
        }

        public override void Cut()
        {
            "Cutting the pizza into square slices".P();
        }
    }
}