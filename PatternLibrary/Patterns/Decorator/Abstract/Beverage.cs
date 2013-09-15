namespace PatternLibrary.Patterns.Decorator.Abstract
{
    public abstract class Beverage
    {
        protected string CurrentDescription = "Unknown Beverage";

        public virtual string Description
        {
            get { return CurrentDescription; }
        }

        public abstract double Cost();
    }
}