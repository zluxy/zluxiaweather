using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZluxiaWeather.Models
{
    public class Model
    {

 

        #region main
        public double temp { get; set; }
        public double feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }

        #endregion

        #region wind
        public double speed { get; set; }
        public int deg { get; set; }
        #endregion

        #region clouds
        public int all { get; set; }
        #endregion

        #region rain & snow
        [Column("1h")]
        public int onehour {get; set;}
        [Column("3h")]
        public int threehours {get; set;}
        #endregion

        #region sys
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
        #endregion

    }
}
