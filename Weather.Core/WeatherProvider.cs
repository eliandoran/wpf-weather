using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core
{
    /// <summary>
    /// Contract for implementations which can obtain the latest <see cref="WeatherInfo" />.
    /// </summary>
    public interface WeatherProvider
    {
        /// <summary>
        /// Obtains the latest <see cref="WeatherInfo" />.
        /// </summary>
        WeatherInfo Obtain();    
    }
}
