using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PatternLibrary.Patterns.IteratorAndComparator.Code.Common;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Iterators
{
    public class CommonIterator : IEnumerable<MenuItem>
    {
        private readonly List<IEnumerable<MenuItem>> _enumerables;

        public CommonIterator()
        {
            _enumerables = new List<IEnumerable<MenuItem>>();
        }

        public void Add(IEnumerable<MenuItem> enumerable)
        {
            _enumerables.Add(enumerable);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return _enumerables.SelectMany(enumerable => enumerable).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}