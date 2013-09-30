using System.Collections.Generic;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Menus
{
    public class PancakeHouseMenu
    {
        private readonly List<MenuItem> _menuItems;

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
        } 

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>
                {
                    new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99),
                    new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99),
                    new MenuItem("Blueberry Pancakes", "Pancakes with fresh blueberries", true, 3.49),
                    new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59)
                };
        }
    }
}