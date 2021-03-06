﻿using System;
using PatternLibrary.Patterns.Factory.Abstract;
using PatternLibrary.Patterns.Factory.Code.IngredientFactories;
using PatternLibrary.Patterns.Factory.Code.Pizzas;
using PatternLibrary.Patterns.Factory.Enum;
using PatternLibrary.Patterns.Factory.Interface;

namespace PatternLibrary.Patterns.Factory.Code.PizzaStores
{
    public class NYPizzaStyleStore : PizzaStore
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory) {Name = "New York Style Cheese Pizza"};
                    break;
                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory){Name = "New York Style Clam Pizza"};
                    break;
                case PizzaType.Veggie:
                case PizzaType.Pepperoni:
                default:
                    throw new ArgumentException("Wrong type of pizza");
            }

            return pizza;
        }
    }
}