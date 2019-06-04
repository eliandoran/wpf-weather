using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Units;

namespace Weather.Providers
{
    public class DirectionParser
    {
        private static readonly int angle = 45;
        private static readonly double halfAngle = angle / 2;

        public static Direction FromDegrees(double degrees)
        {
            degrees = degrees % 360;
            int index = (int)(Math.Round((degrees - halfAngle) / angle));
            return (Direction)index;
        }

    }
}
