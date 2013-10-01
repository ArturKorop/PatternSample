using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Menus
{
    public class DesertMenu : Menu
    {
        public DesertMenu() : base("Desert", "Standard desert menu")
        {
            base.Add(new MenuItem("Cake", "Sugar cake", true, 3.59));
        }
    }
}