using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ForecastController : ApiController
    {

        public CityForecast[] Get()
        {
            /* if (region == "namur")
             {
                 return new string[] {
                "ensoleillé","brumeux","gris"
                 };
             }
             else
             {
                 return new string[] {
                "nuageux","pluvieux","gris"
                 };
             }*/

            return new CityForecast[]
            {
                new CityForecast()
                {
                    City = "Namur", Description = "ensoleillé", MaxTemp = 15
                },

                new CityForecast()
                {
                    City = "Bruxelle", Description = "nuageux", MaxTemp = 12
                }


           }.OrderBy(Forecast => Forecast.City).ToArray();
            //return GetForeCastFromDatabase().OrderBy(Forecast => Forecast.City).ToArray();

        }

        /*private CityForecast[] GetForeCastFromDatabase()
        {
            SqlConnection connexion = new SqlConnection("Data Source = (LocalDb)\\MSSQLLocalDb; Initial Catalog = testBD; Integrated Security = True; Pooling = False");
            connexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM[Table]", connexion);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CityForecast> forecasts = new List<CityForecast>();

            while (reader.Read())
            {
                CityForecast forecast = new CityForecast();
                forecast.City = (string)reader["City"];
                forecast.Description =(string) reader["Description"];
                forecast.MaxTemp = (decimal)reader["MaxTemp"];
                forecasts.Add(forecast);
            }
            reader.Close();
            connexion.Close();
            return forecasts.ToArray();
        }*/
    }
}
          

       /* public string[] Post(string region)
        {
            if (region == "namur")
            {
                return new string[] {
               "ensoleillé","brumeux","gris"
                };
            }
            else
            {
                return new string[] {
               "nuageux","pluvieux","gris"
                };
            }
        }
    }*/

