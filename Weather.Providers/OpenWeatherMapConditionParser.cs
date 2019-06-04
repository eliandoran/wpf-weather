using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core;

namespace Weather.Providers
{
    /// <summary>
    /// Converts OpenWeatherMap icons to <see cref="WeatherCondition"/>.
    /// </summary>
    class OpenWeatherMapConditionParser
    {

        private static readonly Dictionary<string, WeatherCondition> iconMappings = new Dictionary<string, WeatherCondition>
        {
            { "01", WeatherCondition.Clear },
            { "02", WeatherCondition.FewClouds },
            { "03", WeatherCondition.ScatteredClouds },
            { "04", WeatherCondition.BrokenClouds },
            { "09", WeatherCondition.ShowerRain },
            { "10", WeatherCondition.Rain },
            { "11", WeatherCondition.Thunderstorm },
            { "13", WeatherCondition.Snow },
            { "50", WeatherCondition.Mist }
        };

        public static WeatherCondition Parse(string iconName)
        {
            iconName = iconName.Substring(0, iconName.Length - 1);
            return iconMappings[iconName];
        }

    }
}
