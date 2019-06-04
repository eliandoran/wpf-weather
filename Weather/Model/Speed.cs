using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    /// <summary>
    /// Value representing a physical quantity of speed.
    /// </summary>
    struct Speed
    {
        private double kmph;

        private Speed(double kmph)
        {
            this.kmph = kmph;
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
