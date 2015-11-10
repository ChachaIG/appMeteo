using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callApi
{
    public class Forecasts
    {
        public string City { get; set; }
        public string Description { get; set; }
        public decimal MaxTemp { get; set; }

        public override string ToString()
        {
            return City + ": " + "Description," + Description + " Temp : " + MaxTemp;
        }
    }


}
