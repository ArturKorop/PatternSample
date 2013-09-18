using PatternLibrary.Patterns.Factory.Abstract;

namespace PatternLibrary.Patterns.Factory.Code.Pizzas
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
         {
             Name = "NY Style Veggie Pizza";
             Dough = "Thin Crust Dough";
             Sauce = "Marinara Sauce";

             Toppings.Add("Grated Reggiano Cheese");
         }
    }
}