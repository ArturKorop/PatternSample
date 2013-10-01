using System;
using PatternLibrary.Patterns.IteratorAndComposite.Abstract;

namespace PatternLibrary.Patterns.IteratorAndComposite.Code.Common
{
    public class Waitress
    {
        private readonly MenuComponent _menus;

        public Waitress(MenuComponent menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            _menus.Print();
        }

        public void PrintBreakfastMenu()
        {
            
        }

        public void PrintLaunchMeny()
        {
            
        }

        public void PrintVegetarianMenu()
        {
            foreach (var menuComponent in _menus.GetEnumerable())
            {
                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotSupportedException)
                {
                }
            }
        }

        public bool IsItemVegetarian(string name)
        {
            return true;
        }
    }
}