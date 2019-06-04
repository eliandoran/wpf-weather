using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Units;

namespace Weather.Core
{
    /// <summary>
    /// Contains weather information that can either be real-time information or a forecast.
    /// </summary>
    public class WeatherDay
    {
        /// <summary>
        /// The date of the weather information. No time information is provided.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The current temperature, if the weather information is for the current day or the average temperature if a forecast.
        /// </summary>
        public Temperature Temperature { get; set; }

        /// <summary>
        /// The temperature, adjusted for conditions such as wind speed and humidity (the "feels like" temperature)
        /// </summary>
        public Temperature ApparentTemperature { get; set; }

        /// <summary>
        /// The current temperature, if the weather information is for the current day or the predominant weather condition if a forecast.
        /// </summary>
        public WeatherCondition Condition { get; set; }

        /// <summary>
        /// Information about the wind conditions, either current or forecast.
        /// </summary>
        public Wind Wind { get; set; }
    }
}
