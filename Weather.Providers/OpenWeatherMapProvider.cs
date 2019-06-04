using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core;
using Newtonsoft.Json;

namespace Weather.Providers
{
    public class OpenWeatherMapProvider : WeatherProvider
    {
        public WeatherInfo Obtain()
        {
            var result = new WeatherInfo();

            return result;
        }

        public WeatherDay ParseCurrentWeather(String jsonString)
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            var result = new WeatherDay()
            {
                Date = DateTimeOffset.FromUnixTimeSeconds(long.Parse(data["dt"])).DateTime
            };

            return result;
        }

    }
}
