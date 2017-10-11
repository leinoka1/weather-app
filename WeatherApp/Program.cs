using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Nice WEATHER ;))");
            Console.ReadKey();
            RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                //Console.ReadLine();
                // 52087b841a0e19eae02720bc08ef0b5b
                client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string apiKey = "52087b841a0e19eae02720bc08ef0b5b";
                Console.WriteLine("Enter city: ");
                string city = Console.ReadLine();
                // string city = "Lappeenranta";
                string language = "fi";

                //HttpResponseMessage responseCw = await client.GetAsync("weather?q=" + city + "&APPID=" + apiKey + "&lang=" + language);
                HttpResponseMessage responseFc = await client.GetAsync("forecast?q=" + city + "&APPID=" + apiKey + "&lang=" + language);
                //Console.WriteLine(responseFc);
                //Console.ReadKey();
                //if (responseCw.StatusCode == HttpStatusCode.OK && responseFc.StatusCode == HttpStatusCode.OK)
                if (responseFc.StatusCode == HttpStatusCode.OK)
                {
                    string wholeDataFc = await responseFc.Content.ReadAsStringAsync();
                    Console.WriteLine(wholeDataFc);
                    Console.ReadKey();

                    //WeatherUtilities wDataCw = responseCw.Content.ReadAsAsync<WeatherUtilities>().Result;
                    WeatherUtilities wDataFc = responseFc.Content.ReadAsAsync<WeatherUtilities>().Result;
                    /*
                    Console.WriteLine("ID City: " + wDataCw.id);
                    Console.WriteLine("City: " + wDataCw.name);
                    Console.WriteLine("OK");
                    */
                    Console.WriteLine("Current Temperature: " + wDataFc.list.main.temp + " K.");
                    
                    /*Console.WriteLine("Current Temperature: " + wDataCw.main.temp + " C.");
                    Console.WriteLine("Current Wind Speed: " + wDataCw.wind.speed + " m/s.");
                    Console.WriteLine("Weather Description: " + wDataCw.weather[0].main + " - " + wDataCw.weather[0].description);
                    */
                    //Console.WriteLine("Weather Description: " + wDataFc.weather[0].main + " - " + wDataFc.weather[0].description);
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
