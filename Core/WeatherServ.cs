using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZluxiaWeather.Models;

namespace ZluxiaWeather.Core
{
    public class WeatherServ
    {

        public static async Task<Data> load(string cityName)
        {
            using (HttpResponseMessage response = await api.init().GetAsync($"weather?q={cityName}&appid=1bcc6336317cecebc65a7d48e06b236d"))
            {
                if (response.IsSuccessStatusCode)
                {
                    Data result = await response.Content.ReadAsAsync<Data>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
