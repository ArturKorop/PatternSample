﻿using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Menus
{
    public class CafeMenu : Menu
    {
        public CafeMenu() : base("Cafe", "Standard cafe menu")
        {
            base.Add(new MenuItem("Veggie Burger and Air Fries",
                                     "Veggie Burger on a whole bun, lettuce, tomato, and fries", false, 3.69));
        }

        
    }
}