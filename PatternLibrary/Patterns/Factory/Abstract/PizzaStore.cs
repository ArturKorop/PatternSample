using PatternLibrary.Patterns.Factory.Enum;

namespace PatternLibrary.Patterns.Factory.Abstract
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
         {
             Pizza pizza = CreatePizza(type);

             pizza.Prepare();
             pizza.Bake();
             pizza.Cut();
             pizza.Box();

             return pizza;
         }

         public abstract Pizza CreatePizza(PizzaType type);
    }
}