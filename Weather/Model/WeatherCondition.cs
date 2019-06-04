using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    /// <summary>
    /// Represents a weather condition (sunny, cloudy, etc.).
    /// </summary>
    /// <remarks>
    /// Adapted from OpenWeatherMap's list of weather conditions:
    /// https://openweathermap.org/weather-conditions
    /// </remarks>
    enum WeatherCondition
    {
        Clear,
        FewClouds,
        ScatteredClouds,
        BrokenClouds,
        ShowerRain,
        Rain,
        Thunderstorm,
        Snow,
        Mist
    }
}
