using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using callApi;

namespace howToCallApi
{
    class Program
    {
        static void Main(string[] args)
        {
            CallWebApiAsync();
            
            Console.ReadKey();
        }

        static async Task CallWebApiAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://forecastlabo2.azurewebsites.net/api/Forecast");
            string json = await response.Content.ReadAsStringAsync();
            var forecasts = Newtonsoft.Json.JsonConvert.DeserializeObject<Forecasts[]>(json);
            foreach(var forecast in forecasts)
            {
                Console.WriteLine(forecast.ToString());
            }
            
            
        }

        



    }
}