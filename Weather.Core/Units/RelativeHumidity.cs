using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Units
{
    /// <summary>
    /// Value representing a physical quantity of relative humidity.
    /// </summary>
    public class RelativeHumidity
    {
        public double Percentage { get;  }

        private RelativeHumidity(double percentage)
        {
            Percentage = percentage;
        }

        public static RelativeHumidity FromPercentage(double percentage)
        {
            return new RelativeHumidity(percentage);
        }
    }
}
