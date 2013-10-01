using PatternLibrary.Patterns.IteratorAndComposite.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComposite.Code.Menus
{
    public class PancakeHouseMenu : Menu
    {
        public PancakeHouseMenu() : base("Pancake", "Standard pancake menu")
        {
            base.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99));
            base.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            base.Add(new MenuItem("Blueberry Pancakes", "Pancakes with fresh blueberries", true, 3.49));
            base.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));
        }
    }
}