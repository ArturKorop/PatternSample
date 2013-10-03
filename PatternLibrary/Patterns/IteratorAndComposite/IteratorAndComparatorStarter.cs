using Common.Code;
using PatternLibrary.Patterns.IteratorAndComposite.Code.Common;
using PatternLibrary.Patterns.IteratorAndComposite.Code.Menus;

namespace PatternLibrary.Patterns.IteratorAndComposite
{
    [Runnable]
    public class IteratorAndComparatorStarter
    {
        public static void Start()
        {
            var menu = new Menu("Main", "All menu");
            var cafe = new CafeMenu();
            var diner = new DinerMenu();
            var pancake = new PancakeHouseMenu();
            var desert = new DesertMenu();

            menu.Add(cafe);
            menu.Add(diner);
            menu.Add(pancake);
            cafe.Add(desert);

            var waitress = new Waitress(menu);
            waitress.PrintMenu();
            "**********************".P();
            waitress.PrintVegetarianMenu();
        }
    }
}