using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Weather.Core;

namespace Weather.ValueConverters
{
    class WeatherConditionImageValueConverter : IValueConverter
    {
        private static readonly Dictionary<WeatherCondition, string> conditionMappings = new Dictionary<WeatherCondition, string>()
        {
            { WeatherCondition.BrokenClouds, "Cloud" },
            { WeatherCondition.Clear, "Clear" },
            { WeatherCondition.FewClouds, "CloudSun" },
            { WeatherCondition.Mist, "Cloud" },
            { WeatherCondition.ScatteredClouds, "CloudSun" },
            { WeatherCondition.ShowerRain, "Rain" },
            { WeatherCondition.Snow, "Snow" },
            { WeatherCondition.Thunderstorm, "Thunderstorm" }
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is WeatherCondition))
                return value;

            var condition = (WeatherCondition)value;
            var icon = conditionMappings[condition];

            return "pack://application:,,,/Assets/" + icon + ".svg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
