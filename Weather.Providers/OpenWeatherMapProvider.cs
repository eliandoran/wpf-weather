using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core;
using Newtonsoft.Json.Linq;
using Weather.Core.Units;

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
            var json = JObject.Parse(jsonString);
            var main = json["main"];
            var weather = json["weather"][0];
            var wind = json["wind"];

            return new WeatherDay()
            {
                Date = DateTimeOffset.FromUnixTimeSeconds(long.Parse(json["dt"].ToString())).DateTime,
                Temperature = Temperature.FromCelsius(double.Parse(main["temp"].ToString()) / 10),
                Humidity = RelativeHumidity.FromPercentage(double.Parse(main["humidity"].ToString()) / 100),
                Condition = OpenWeatherMapConditionParser.Parse(weather["icon"].ToString()),
                Wind = ParseWind(wind),
            };
        }

        private Wind ParseWind(JToken windToken)
        {
            return new Wind()
            {
                Direction = DirectionParser.FromDegrees(double.Parse(windToken["deg"].ToString())),
                Speed = Speed.FromKilometersPerHour(double.Parse(windToken["speed"].ToString()))
            };
        }

    }
}
