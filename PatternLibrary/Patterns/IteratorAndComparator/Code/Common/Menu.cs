using System.Collections.Generic;
using Common.Code;
using PatternLibrary.Patterns.IteratorAndComparator.Abstract;

namespace PatternLibrary.Patterns.IteratorAndComparator.Code.Common
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            "{0}, {1}".P(_name, _description);
            "---------------------------".P();

            foreach (var menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }

        public override IEnumerable<MenuComponent> GetEnumerable()
        {
            foreach (var menuComponent in _menuComponents)
            {
                yield return menuComponent;
                if (menuComponent.GetEnumerable() == null) continue;

                foreach (var component in menuComponent.GetEnumerable())
                {
                    yield return component;
                }
            }
        } 
    }
}