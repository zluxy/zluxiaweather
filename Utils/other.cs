using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZluxiaWeather.other
{
    public class other
    {
        public static double ktoCelsius(double k)
        {
            return (k - 273.15);
        }

        public static double ktoFahreneit(double k)
        {
            return ((k - 273.15) * 9 / 5 + 32);
        }

        public static string windDirection(int num)
        {
            int val = (int)((num / 22.5) + 0.5);
            string[] windDirection = { "Север", "Северо-северо-восток", "Северо-восток", "Восток-северо-восток", "Восток", "Восток-юго-восток", "Юго-восток", "Юго-юго-восток", "Юг", "Юго-юго-запад", "Юго-запад", "Запад-юго-запад", "Запад", "Запад-северо-запад", "Северо-запад", "Северо-северо-запад" };
            return windDirection[(val % 16)];
        }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }

        public static (Color, Color, Color) CheckDarkMode(bool check)
        {
            Color mainBgColor;
            Color bgColor;
            Color fColor;
            if (check)
            {
                mainBgColor = Color.FromArgb(28, 29, 33);
                bgColor = Color.FromArgb(36, 37, 42);
                fColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                mainBgColor = Color.FromArgb(246, 246, 247);
                bgColor = Color.White;
                fColor = Color.Black;
            }
            return (mainBgColor, bgColor, fColor);
        }
    }
}
