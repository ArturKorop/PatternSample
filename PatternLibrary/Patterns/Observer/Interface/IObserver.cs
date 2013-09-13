namespace PatternLibrary.Patterns.Observer.Interface
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}