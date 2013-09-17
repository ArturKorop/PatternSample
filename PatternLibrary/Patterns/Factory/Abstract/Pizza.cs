using System.Collections.Generic;
using Common.Code;

namespace PatternLibrary.Patterns.Factory.Abstract
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public virtual void Prepare()
        {
            "Preparing {0}".P(Name);
            "Tossing dough...".P();
            "Adding souce...".P();
            "Adding toppings: ".P();
            foreach (var topping in Toppings)
            {
                "   {0}".P(topping);
            }
        }

        public virtual void Bake()
        {
            "Bake for 25 minutes at 350".P();
        }

        public virtual void Cut()
        {
            "Cutting the pizza into diagonal slices".P();
        }

        public virtual void Box()
        {
            "Place pizza in official PizzaStore box".P();
        }

        
    }
}