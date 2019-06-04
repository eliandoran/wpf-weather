using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Weather.Core.Units;

namespace Weather.ValueConverters
{
    public class RelativeHumidityValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is RelativeHumidity))
                return value;

            var humidity = (RelativeHumidity)value;
            return (int)(Math.Round(humidity.Percentage * 100)) + "%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
