using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core;

namespace Weather.Providers.OpenWeatherMap
{
    public class ForecastFilter
    {

        public static List<WeatherDay> Filter(List<WeatherDay> fullList)
        {
            var result = new List<WeatherDay>();

            foreach (var entry in fullList)
            {
                if (entry.Date.Hour != 12)
                    continue;

                result.Add(entry);
            }

            return result;
        }

    }
}
