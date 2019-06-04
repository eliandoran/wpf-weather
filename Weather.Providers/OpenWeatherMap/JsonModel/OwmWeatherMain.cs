using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Providers.OpenWeatherMap.JsonModel
{
    public class OwmWeatherMain
    {
        public double temp { get; set; }

        public int humidity { get; set; }
    }
}
