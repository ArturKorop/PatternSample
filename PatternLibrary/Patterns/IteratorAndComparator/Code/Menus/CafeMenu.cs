using System.Collections.Generic;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Menus
{
    public class CafeMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems;

        public Dictionary<string, MenuItem> MenuItems
        {
            get { return _menuItems; }
        }

        public CafeMenu()
        {
            _menuItems = new Dictionary<string, MenuItem>
                {
                    {
                        "Veggie Burger and Air Fries",
                        new MenuItem("Veggie Burger and Air Fries",
                                     "Veggie Burger on a whole bun, lettuce, tomato, and fries", false, 3.69)
                    }
                };
        }
    }
}