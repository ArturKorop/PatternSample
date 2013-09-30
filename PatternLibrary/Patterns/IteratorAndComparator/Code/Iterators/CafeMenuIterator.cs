using System.Collections;
using System.Collections.Generic;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Iterators
{
    public class CafeMenuIterator : IEnumerable<MenuItem>
    {
        private readonly Dictionary<string, MenuItem> _menuItems;
 
        public CafeMenuIterator(Dictionary<string, MenuItem> menuItems)
        {
            _menuItems = menuItems;
            
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return _menuItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}