using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Providers.OpenWeatherMap.JsonModel
{
    public class OwmWind
    {
        public double speed { get; set; }

        public double deg { get; set; }
    }
}
