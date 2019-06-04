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

namespace Weather.Controls
{
    /// <summary>
    /// Interaction logic for WeatherDetails.xaml
    /// </summary>
    public partial class WeatherDetails: UserControl
    {
        public static readonly DependencyProperty WeatherProperty = DependencyProperty.Register(
            "Weather", typeof(WeatherDay), typeof(WeatherDetails));

        public WeatherDay Weather
        {
            get { return (WeatherDay)GetValue(WeatherProperty); }
            set { SetValue(WeatherProperty, value); }
        }

        public WeatherDetails()
        {
            InitializeComponent();
        }
    }
}
