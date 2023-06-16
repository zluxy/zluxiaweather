using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ZluxiaWeather
{
    public class api
    {
        private static HttpClient apiUrl { get; set; }

        public static HttpClient init()
        {
            apiUrl = new HttpClient(new HttpClientHandler());
            apiUrl.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");
            apiUrl.DefaultRequestHeaders.Accept.Clear();
            apiUrl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var queryString = apiUrl.BaseAddress.Query;
            var queryBuilder = new StringBuilder(queryString);
            if (string.IsNullOrEmpty(queryString))
                queryBuilder.Append("?");
            else
                queryBuilder.Append("&");

            queryBuilder.Append("lang=ru");

            apiUrl.BaseAddress = new Uri(apiUrl.BaseAddress.GetLeftPart(UriPartial.Path) + queryBuilder.ToString());

            return apiUrl;
        }
    }
}
