using System.Collections;
using System.Collections.Generic;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Iterators
{
    public class DinerMenuIterator : IEnumerable<MenuItem>
    {
        private readonly MenuItem[] _menuItems;

        public DinerMenuIterator(MenuItem[] items)
        {
            _menuItems = items;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return  ((IEnumerable<MenuItem>)_menuItems).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}