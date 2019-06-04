using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather.Core;
using Weather.Core.Units;
using Weather.Providers;

namespace Weather.Providers.Tests
{
    [TestClass]
    public class OpenWeatherMapProviderTests
    {
        [TestMethod]
        public void ParseCurrentWeather()
        {
            var input = GetResource("Input.OpenWeatherMap.weather.json");

            var provider = new OpenWeatherMapProvider();
            var day = provider.ParseCurrentWeather(input);

            Assert.AreEqual(new DateTime(2019, 6, 4, 15, 52, 57), day.Date);
            Assert.AreEqual(day.Temperature.Celsius, 29.42, 0.01);
            Assert.AreEqual(WeatherCondition.FewClouds, day.Condition);
            Assert.AreEqual(RelativeHumidity.FromPercentage(0.6).Percentage, day.Humidity.Percentage, 0.1);
            Assert.IsNotNull(day.ApparentTemperature);

            var wind = day.Wind;
            Assert.AreEqual(Direction.East, wind.Direction);
            Assert.AreEqual(3.6, wind.Speed.KilometersPerHour, 0.1);
        }

        private static string GetResource(string name)
        {
            string ns = typeof(OpenWeatherMapProviderTests).Namespace;
            var fullName = ns + "." + name;
            var assembly = Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream(fullName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
