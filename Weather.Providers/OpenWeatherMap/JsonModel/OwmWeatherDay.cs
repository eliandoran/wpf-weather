using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Providers.OpenWeatherMap.JsonModel
{
    public class OwmWeatherDay
    {
        public long dt { get; set; }

        public OwmWeatherMain main { get; set; }

        public List<OwmWeatherEntry> weather { get; set; }

        public OwmWind wind { get; set; }
    }
}
