namespace PatternLibrary.Patterns.CompositePatterns.Interface
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}