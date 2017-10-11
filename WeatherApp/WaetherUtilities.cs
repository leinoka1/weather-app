using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace WeatherApp
{
    class WaetherUtilities
    {
        public static int GetTemperature(string locaton, string time)
        {
            int temperature = 0;
            // API Key 52087b841a0e19eae02720bc08ef0b5b 
            // api.openweathermap.org / data / 2.5 / forecast ? id = 524901 & APPID = 52087b841a0e19eae02720bc08ef0b5b;
            HttpClient client = new HttpClient();
            // New code:
            /*
            client.BaseAddress = new Uri("http://api.openweathermap.org/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            */


            //var result = client.GetAsync("http://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b1b15e88fa797225412429c1c50c122a1").GetAwaiter().GetResult();
            var result = client.GetAsync("http://api.openweathermap.org/data/2.5/weather?q=Lappeenranta&appid=52087b841a0e19eae02720bc08ef0b5b&lang=fi").GetAwaiter().GetResult();
            var data = result.Content;
            var body = data.ReadAsStringAsync().GetAwaiter().GetResult();
            Console.WriteLine(body);
           // var bicCodes = JsonConvert.DeserializeObject<List<BicCode>>(body);

            Console.ReadLine();

            return temperature;
        }

    }
}
