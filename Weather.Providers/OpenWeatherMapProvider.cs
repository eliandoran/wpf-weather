using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core;
using Newtonsoft.Json.Linq;
using Weather.Core.Units;
using Newtonsoft.Json;
using Weather.Providers.OpenWeatherMap.JsonModel;
using Weather.Providers.OpenWeatherMap;

namespace Weather.Providers
{
    public class OpenWeatherMapProvider : WeatherProvider
    {
        public WeatherInfo Obtain()
        {
            var result = new WeatherInfo();

            return result;
        }

        public List<WeatherDay> ParseForecast(String forecastString)
        {
            var forecast = JsonConvert.DeserializeObject<OwmForecast>(forecastString);
            var result = new List<WeatherDay>();

            foreach (var day in forecast.list)
            {
                result.Add(new WeatherDay()
                {
                    Date = DateTimeOffset.FromUnixTimeSeconds(day.dt).DateTime,
                    Condition = OpenWeatherMapConditionParser.Parse(day.weather[0].icon),
                    Humidity = RelativeHumidity.FromPercentage(day.main.humidity),
                    Temperature = Temperature.FromCelsius(day.main.temp / 10),
                    Wind = new Wind()
                    {
                        Direction = DirectionParser.FromDegrees(day.wind.deg),
                        Speed = Speed.FromKilometersPerHour(day.wind.speed)
                    }
                });
            }

            return ForecastFilter.Filter(result);
        }

        public WeatherDay ParseCurrentWeather(String jsonString)
        {
            var json = JObject.Parse(jsonString);
            var main = json["main"];
            var weather = json["weather"][0];
            var wind = json["wind"];

            var result = new WeatherDay()
            {
                Date = DateTimeOffset.FromUnixTimeSeconds(long.Parse(json["dt"].ToString())).DateTime,
                Temperature = Temperature.FromCelsius(double.Parse(main["temp"].ToString()) / 10),
                Humidity = RelativeHumidity.FromPercentage(double.Parse(main["humidity"].ToString()) / 100),
                Condition = OpenWeatherMapConditionParser.Parse(weather["icon"].ToString()),
                Wind = ParseWind(wind)
            };

            result.ApparentTemperature = ApparentTemperatureCalculator.Calculate(result);
            return result;
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
