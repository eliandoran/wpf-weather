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
    /// Interaction logic for Forecast.xaml
    /// </summary>
    public partial class Forecast : UserControl
    {
        public static readonly DependencyProperty ForecastDataProperty = DependencyProperty.Register(
            "ForecastData", typeof(List<WeatherDay>), typeof(Forecast));

        public List<WeatherDay> ForecastData
        {
            get { return (List<WeatherDay>)GetValue(ForecastDataProperty); }
            set { SetValue(ForecastDataProperty, value); }
        }

        public Forecast()
        {
            InitializeComponent();
        }
    }
}
