using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    class WeatherUtilities
    {
        public string name { get; set; }
        public string id { get; set; }
        public CurrentWeather main { get; set; }
        public CurrentWeather wind { get; set; }
        public WeatherForecastMain list { get; set; }
 
        public List<WeatherDescription> weather { get; set; }
    }
}
