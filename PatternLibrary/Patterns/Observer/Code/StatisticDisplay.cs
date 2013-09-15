using System.Collections.Generic;
using System.Linq;
using Common.Code;
using PatternLibrary.Patterns.Observer.Interface;

namespace PatternLibrary.Patterns.Observer.Code
{
    public class StatisticDisplay : IObserver, IDisplayElement
    {
        private readonly List<float> _temperatures;
        private readonly List<float> _humidities;
        private readonly List<float> _pressures;
        private readonly ISubject _weatherData;

        public StatisticDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);

            _temperatures = new List<float>();
            _humidities = new List<float>();
            _pressures = new List<float>();
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperatures.Add(temp);
            _humidities.Add(humidity);
            _pressures.Add(pressure);

            Display();
        }

        public void Display()
        {
            "Average temperature: {0}".P(GetAverage(_temperatures));
            "Average humiditiy: {0}".P(GetAverage(_humidities));
            "Average pressure: {0}".P(GetAverage(_pressures));
        }

        private float GetAverage(List<float> list)
        {
            return list.Sum()/list.Count;
        }
    }
}