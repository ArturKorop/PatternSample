using Common.Code;
using PatternLibrary.Patterns.Factory.Abstract;

namespace PatternLibrary.Patterns.Factory.Code.Pizzas
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
         {
             Name = "Chicago Style Veggie Pizza";
             Dough = "Extra Thick Crust Dough";
             Sauce = "Plum Tomato Sauce";

             Toppings.Add("Shredded Mozarella Cheese");
         }

        public override void Cut()
        {
            "Cutting the pizza into square slices".P();
        }
    }
}