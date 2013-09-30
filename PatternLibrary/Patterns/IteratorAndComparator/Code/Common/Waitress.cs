using System;
using Common.Code;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Iterators;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Menus;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Common
{
    public class Waitress
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private readonly DinerMenu _dinerMenu;
        private readonly CafeMenu _cafeMenu;

        public Waitress()
        {
            _pancakeHouseMenu = new PancakeHouseMenu();
            _dinerMenu = new DinerMenu();
            _cafeMenu = new CafeMenu();
        }

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = new PancakeHouseIterator(_pancakeHouseMenu.MenuItems);
            var dinerIterator = new DinerMenuIterator(_dinerMenu.MenuItems);
            var cafeIterator = new CafeMenuIterator(_cafeMenu.MenuItems);
            var commonIterator = new CommonIterator { pancakeIterator, dinerIterator, cafeIterator };
            foreach (var item in commonIterator)
            {
                if (item != null)
                    "{0} - {1}, {2} : {3}".P(item.Name, item.Description, item.Vegetarian ? "Veggie" : "Not veggie",
                                             item.Price);
            }
        }

        public void PrintBreakfastMenu()
        {
            
        }

        public void PrintLaunchMeny()
        {
            
        }

        public void PrintVegetarianMenu()
        {
            
        }

        public bool IsItemVegetarian(string name)
        {
            return true;
        }
    }
}