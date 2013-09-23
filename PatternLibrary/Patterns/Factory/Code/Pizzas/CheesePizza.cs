using Common.Code;
using PatternLibrary.Patterns.Factory.Abstract;
using PatternLibrary.Patterns.Factory.Interface;

namespace PatternLibrary.Patterns.Factory.Code.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory )
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            "Preparing: {0}".P(Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();

        }

        public override void Cut()
        {
            "Cutting the pizza into square slices".P();
        }
    }
}