using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core;
using Weather.Core.Units;

namespace Weather.Providers
{
    public class ApparentTemperatureCalculator
    {

        public static Temperature Calculate(WeatherDay weather)
        {
            return weather.Temperature;
        }

    }
}
