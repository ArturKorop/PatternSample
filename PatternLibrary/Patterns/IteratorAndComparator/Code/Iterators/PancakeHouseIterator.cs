using System.Collections;
using System.Collections.Generic;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Iterators
{
    public class PancakeHouseIterator : IEnumerable<MenuItem>
    {
        private readonly List<MenuItem> _menuItems;
 
        public PancakeHouseIterator(List<MenuItem> menuItems)
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