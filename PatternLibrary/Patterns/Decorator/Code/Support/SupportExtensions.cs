﻿using System;
using PatternLibrary.Patterns.Decorator.Abstract;

namespace PatternLibrary.Patterns.Decorator.Code.Support
{
    public static class SupportExtensions
    {
        public static Beverage AddComponent<T>(this Beverage beverage) where T : CondimentDecorator
        {
            return (T) Activator.CreateInstance(typeof (T), beverage);
        }

        public static void AddComponent<T>(ref Beverage beverage) where T : CondimentDecorator
        {
            beverage = (T)Activator.CreateInstance(typeof (T), beverage);
        }
    }
}