using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    /// <summary>
    /// Value representing a physical quantity of temperature.
    /// </summary>
    struct Temperature
    {
        private double celsius;

        private Temperature(double celsius)
        {
            this.celsius = celsius;
        }

        /// <summary>
        /// Builds a new <see cref="Temperature"/> from the given value, expressed in Celsius degrees.
        /// </summary>
        /// <param name="celsius">the temperature in Celsius degrees.</param>
        /// <returns>A <see cref="Temperature"/> with the given value</returns>
        public static Temperature FromCelsius(double celsius)
        {
            return new Temperature(celsius);
        }
    }
}
