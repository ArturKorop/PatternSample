using System;
using System.Collections.Generic;
using PatternLibrary.Patterns.Decorator.Abstract;
using PatternLibrary.Patterns.Decorator.Code.CondimentDecorators;
using PatternLibrary.Patterns.Decorator.Interface;

namespace PatternLibrary.Patterns.Decorator.Code.Common
{
    public class ComponentCosts : IPriceProvider
    {
        private Dictionary<Type, double> _prices = new Dictionary<Type, double>();

        public ComponentCosts()
        {
            _prices.Add(typeof (Mocha), .20);
            _prices.Add(typeof (Soy), 0.15);
            _prices.Add(typeof (Whip), 0.10);
        }

        public ComponentCosts(Dictionary<Type, double> prices)
        {
            _prices = prices;
        }

        public void AddPrice(Type type, double price)
        {
            _prices.Remove(type);
            _prices.Add(type, price);
        }

        public void AddPricec(Dictionary<Type, double> prices)
        {
            _prices = prices;
        }

        public double GetPrice<T>() where T : CondimentDecorator
        {
            return _prices[typeof (T)];
        }
    }
}