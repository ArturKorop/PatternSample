using System;
using PatternLibrary.Patterns.Factory.Abstract;
using PatternLibrary.Patterns.Factory.Code.Pizzas;
using PatternLibrary.Patterns.Factory.Enum;

namespace PatternLibrary.Patterns.Factory.Code.PizzaStores
{
    public class NYPizzaStyleStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza();
                case PizzaType.Veggie:
                    return new NYStyleVeggiePizza();
                case PizzaType.Clam:
                case PizzaType.Pepperoni:
                default:
                    throw new ArgumentException("Wrong type of pizza");
                    
            }
        }
    }
}