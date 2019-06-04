using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Weather.Core.Units;

namespace Weather.ValueConverters
{
    class DirectionValueConverter : IValueConverter
    {
        private static readonly Dictionary<Direction, string> directionMappings = new Dictionary<Direction, string>()
        {
            { Direction.East, "E" },
            { Direction.North, "N" },
            { Direction.NorthEast, "NE" },
            { Direction.NorthWest, "NW" },
            { Direction.South, "S" },
            { Direction.SouthEast, "SE" },
            { Direction.SouthWest, "SW" },
            { Direction.West, "W" }
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Direction))
                return value;

            var direction = (Direction)value;
            return directionMappings[direction];            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
