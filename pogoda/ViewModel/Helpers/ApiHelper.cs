using Newtonsoft.Json;
using pogoda.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace pogoda.ViewModel.Helpers
{
    class ApiHelper
    {
        static string city = "Moscow";

        public static async Task<WeatherData> GetWeatherDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=dc02e68c8a7e8f4425e085ea7dadb233&lang=ru&units=metric";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonResponse);
                    return weatherData;
                }
            }

            return null;
        }
    }
}