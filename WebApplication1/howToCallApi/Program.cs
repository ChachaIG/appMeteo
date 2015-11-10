using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
