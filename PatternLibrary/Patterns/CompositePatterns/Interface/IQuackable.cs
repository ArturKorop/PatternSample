namespace PatternLibrary.Patterns.CompositePatterns.Interface
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
        string Name { get; }
    }
}