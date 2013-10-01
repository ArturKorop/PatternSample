using System.Collections.Generic;
using Common.Code;
using PatternLibrary.Patterns.IteratorAndComposite.Abstract;

namespace PatternLibrary.Patterns.IteratorAndComposite.Code.Common
{
    public class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _vegetarian;
        private readonly double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }
        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _vegetarian;
        }

        public override IEnumerable<MenuComponent> GetEnumerable()
        {
            return null;
        }

        public override void Print()
        {
            "{0} - {1}, {2} : {3}".P(_name, _description, _vegetarian ? "Veggie" : "Not veggie", _price);
        }
    }
}