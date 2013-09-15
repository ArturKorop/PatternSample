namespace PatternLibrary.Patterns.Decorator.Abstract
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage;

        public override abstract string Description { get; }
    }
}