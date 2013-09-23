using System.Collections.Generic;
using Common.Code;
using PatternLibrary.Patterns.Factory.Interface.Ingredients;

namespace PatternLibrary.Patterns.Factory.Abstract
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough Dough;
        protected ISauce Sauce;
        protected ICheese Cheese;
        protected IClam Clam;
        protected IPepperoni Pepperoni;
        protected List<IVeggie> Veggies = new List<IVeggie>();

        public abstract void Prepare();

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