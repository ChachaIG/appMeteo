using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class AccesDonnees
    {
        public CityForecast[] GetForeCastFromDatabase()
        {
            #region sans entityFramework
            /*
            SqlConnection connexion = new SqlConnection("Data Source = (LocalDb)\\MSSQLLocalDb; Initial Catalog = meteo; Integrated Security = True; Pooling = False");
            connexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM[Table]", connexion);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CityForecast> forecasts = new List<CityForecast>();

            while (reader.Read())
            {
                CityForecast forecast = new CityForecast();
                forecast.City = (string)reader["ville"];
                forecast.Description = (string)reader["description"];
                forecast.MaxTemp = (int)reader["maxTemp"];
                forecasts.Add(forecast);
            }
            reader.Close();
            connexion.Close();
            return forecasts.ToArray();*/
            #endregion
            meteoEntities ctx = new meteoEntities();
            var tab = ctx.Tables.ToArray();
            List<CityForecast> forcasts = new List<CityForecast>();
            foreach(Table elem in tab)
            {
                CityForecast forcast = new CityForecast();
                forcast.City = elem.ville;
                forcast.Description = elem.description;
                forcast.MaxTemp = (int)elem.maxTemp;
                forcasts.Add(forcast);
            }
            return forcasts.ToArray();
            
        }
    }
}
