using System;
using System.Collections.Generic;
using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Interface
{
    public interface IPriceProvider
    {
        void AddPrice(Type type, double price);
        void AddPricec(Dictionary<Type,double> prices);
        double GetPrice<T>() where T : CondimentDecorator;

    }
}