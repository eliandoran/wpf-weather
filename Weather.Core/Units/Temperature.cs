﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Units
{
    /// <summary>
    /// Value representing a physical quantity of temperature.
    /// </summary>
    public struct Temperature
    {
        public double Celsius { get; }

        private Temperature(double celsius)
        {
            Celsius = celsius;
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
