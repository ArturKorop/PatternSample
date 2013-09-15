using Common.Code;
using PatternLibrary.Patterns.Observer.Code;

namespace PatternLibrary.Patterns.Observer
{
    [Runnable]
    public class ObserverStarter
    {
        public static void Start()
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionalDisplay(weatherData);
            var statisticDisplay = new StatisticDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}