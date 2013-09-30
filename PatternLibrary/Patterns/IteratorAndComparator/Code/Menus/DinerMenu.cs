using System;
using System.Collections.Generic;
using Common.Code;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Menus
{
    public class DinerMenu
    {
        private const int MaxItems = 6;
        private int _numberOfItems;
        private readonly MenuItem[] _menuItems;

        public MenuItem[] MenuItems
        {
            get { return _menuItems; }
        }

        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxItems];
            AddItem(new MenuItem("Vegetarian BLT", "(Fakin`) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            AddItem(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            AddItem(new MenuItem("Soup of the day", "Soup of the day, with a side of patato salad", false, 3.29));
            AddItem(new MenuItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05));
        }

        private void AddItem(MenuItem item)
        {
            if (_numberOfItems > MaxItems)
            {
                "Sorry, menu is full! Can't add item to menu".P();
            }
            else
            {
                _menuItems[_numberOfItems] = item;
                _numberOfItems++;
            }
        }
    }
}