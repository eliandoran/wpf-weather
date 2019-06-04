using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Model
{
    /// <summary>
    /// Contains information about the wind.
    /// </summary>
    class Wind
    {
        /// <summary>
        /// The speed of the wind.
        /// </summary>
        public Speed Speed { get; set; }

        /// <summary>
        /// The direction of the wind.
        /// </summary>
        public Direction Direction { get; set; }
    }
}
