using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WeatherApp
{
    class Forecast
    {
        [JsonProperty("name")]
        public string LocationName { get; set; }
        
        // [JsonProperty("coord")]
        // public Geolocation Geolocation { get; set; }

        // [JsonProperty("main")]
        // public MeasurementData Measurement { get; set; }

        //[JsonProperty("wind")]
        //public WindData Wind { get; set; }

        //[JsonProperty("weather")]
        //public List<WeatherDescription> Descriptions { get; set; }

    }
    /* Constructor
    public Car(string color, string brand, string model)
    {
        Color = color;
        Brand = brand;
        Model = model;
        Speed = 0;
        _originalColor = color;
    }
    */
}
