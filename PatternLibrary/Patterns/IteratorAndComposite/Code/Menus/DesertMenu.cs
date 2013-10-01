using PatternLibrary.Patterns.IteratorAndComposite.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComposite.Code.Menus
{
    public class DesertMenu : Menu
    {
        public DesertMenu() : base("Desert", "Standard desert menu")
        {
            base.Add(new MenuItem("Cake", "Sugar cake", true, 3.59));
        }
    }
}