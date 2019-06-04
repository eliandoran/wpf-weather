using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            Assert.AreEqual(new DateTime(2017, 1, 30, 15, 20, 0), day.Date);
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
