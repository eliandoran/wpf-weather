using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Weather.Core;
using Weather.Providers;

namespace Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly String weatherJsonString = "{\"coord\":{\"lon\":24.16,\"lat\":45.79},\"weather\":[{\"id\":801,\"main\":\"Clouds\",\"description\":\"few clouds\",\"icon\":\"02d\"}],\"base\":\"stations\",\"main\":{\"temp\":294.21,\"pressure\":1012,\"humidity\":60,\"temp_min\":294.15,\"temp_max\":294.26},\"visibility\":10000,\"wind\":{\"speed\":3.6,\"deg\":110},\"clouds\":{\"all\":20},\"dt\":1559663577,\"sys\":{\"type\":1,\"id\":6920,\"message\":0.0055,\"country\":\"RO\",\"sunrise\":1559615749,\"sunset\":1559671663},\"timezone\":10800,\"id\":667268,\"name\":\"Sibiu\",\"cod\":200}";

        public static readonly DependencyProperty WeatherProperty = DependencyProperty.Register(
            "Weather", typeof(WeatherDay), typeof(MainWindow));

        public WeatherDay Weather
        {
            get { return (WeatherDay)GetValue(WeatherProperty); }
            set { SetValue(WeatherProperty, value); }
        }

        public MainWindow()
        {
            var provider = new OpenWeatherMapProvider();
            Weather = provider.ParseCurrentWeather(weatherJsonString);

            InitializeComponent();
        }
    }
}
