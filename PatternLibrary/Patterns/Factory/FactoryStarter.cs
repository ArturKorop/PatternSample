using Common.Code;
using PatternLibrary.Patterns.Factory.Abstract;
using PatternLibrary.Patterns.Factory.Code.PizzaStores;
using PatternLibrary.Patterns.Factory.Enum;

namespace PatternLibrary.Patterns.Factory
{
    [Runnable(true)]
    public class FactoryStarter
    {
         public static void Start()
         {
             PizzaStore pizzaStore = new NYPizzaStyleStore();
             pizzaStore.OrderPizza(PizzaType.Cheese);
             "----------------------".P();
             pizzaStore = new ChicagoPizzaStore();
             pizzaStore.OrderPizza(PizzaType.Cheese);
         }
    }
}