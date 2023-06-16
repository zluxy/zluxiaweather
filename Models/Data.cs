using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZluxiaWeather.Models
{
    public class Data
    {
        public w[] weather { get; set; }
        public Model main { get; set; }
        public int visibility { get; set; }
        public Model wind { get; set; }
        public Model clouds { get; set; }

        public Model rain { get; set; }
        public Model snow { get; set; }

        public int dt { get; set; }

        public Model sys { get; set; }

        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }

    }

    public class w
    {
        #region weather
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        #endregion
    }
}
