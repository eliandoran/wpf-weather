using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    class WeatherInfo
    {
        /// <summary>
        /// The date the weather information was obtained.
        /// </summary>
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Weather information for the current day.
        /// </summary>
        public WeatherDay Current { get; set; }

        /// <summary>
        /// Forecasted weather information for the next days.
        /// The order of the items is guaranteed to be chronological.
        /// </summary>
        public List<WeatherDay> Forecast { get; set; }
    }
}
