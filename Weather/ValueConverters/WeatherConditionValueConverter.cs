using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Weather.Core;

namespace Weather.ValueConverters
{
    class WeatherConditionValueConverter : IValueConverter
    {
        private static readonly Dictionary<WeatherCondition, string> conditionMappings = new Dictionary<WeatherCondition, string>()
        {
            { WeatherCondition.BrokenClouds, "Broken clouds" },
            { WeatherCondition.Clear, "Clear" },
            { WeatherCondition.FewClouds, "Few clouds" },
            { WeatherCondition.Mist, "Mist" },
            { WeatherCondition.Rain, "Rain" },
            { WeatherCondition.ScatteredClouds, "Scattered clouds" },
            { WeatherCondition.ShowerRain, "Shower rain" },
            { WeatherCondition.Snow, "Snow" },
            { WeatherCondition.Thunderstorm, "Thunderstorm" }
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is WeatherCondition))
                return value;

            var condition = (WeatherCondition)value;
            return conditionMappings[condition];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
