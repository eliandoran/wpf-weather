using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Units
{
    /// <summary>
    /// Value representing a physical quantity of speed.
    /// </summary>
    public struct Speed
    {
        public double KilometersPerHour { get; }

        private Speed(double kmph)
        {
            KilometersPerHour = kmph;
        }

        /// <summary>
        /// Builds a new <see cref="Speed"/> from the given value, expressed in kilometers per hour (km/h).
        /// </summary>
        /// <param name="kmph">the speed in kilometers per hour.</param>
        /// <returns>A <see cref="Speed"/> with the given value</returns>
        public static Speed FromKilometersPerHour(double kmph)
        {
            return new Speed(kmph);
        }
    }
}
