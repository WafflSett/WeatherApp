using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Result
    {
        public int id { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int elevation { get; set; }
        public string feature_code { get; set; }
        public string country_code { get; set; }
        public int admin1_id { get; set; }
        public string timezone { get; set; }
        public int population { get; set; }
        public int country_id { get; set; }
        public string country { get; set; }
        public string admin1 { get; set; }
        public int? admin2_id { get; set; }
        public int? admin3_id { get; set; }
        public string admin2 { get; set; }
        public string admin3 { get; set; }
    }
}
