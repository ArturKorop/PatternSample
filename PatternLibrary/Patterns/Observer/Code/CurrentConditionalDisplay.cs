using Common.Code;
using PatternLibrary.Patterns.Observer.Interface;

namespace PatternLibrary.Patterns.Observer.Code
{
    public class CurrentConditionalDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionalDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            "Current conditions: {0}F degrees and {1}% humidity".P(_temperature, _humidity);
        }
    }
}