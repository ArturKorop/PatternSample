using PatternLibrary.Patterns.IteratorAndComposite.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComposite.Code.Menus
{
    public class DinerMenu : Menu
    {
        public DinerMenu() : base("Diner", "Standard diner menu")
        {
           
            base.Add(new MenuItem("Vegetarian BLT", "(Fakin`) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            base.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            base.Add(new MenuItem("Soup of the day", "Soup of the day, with a side of patato salad", false, 3.29));
            base.Add(new MenuItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05));
        }
    }
}