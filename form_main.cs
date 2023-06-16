using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZluxiaWeather.other;
using ZluxiaWeather.Core;
using ZluxiaWeather.Properties;
using System.Threading;
using System.Reflection;
using System.Net;
using System.Globalization;

namespace ZluxiaWeather
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }
        static string configFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.ini";
        cfg ini = new cfg(configFile);
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(configFile))
            {
                LoadElements(ini.IniReadValue("Settings", "StartCity"));
                timer_refresh.Interval = Convert.ToInt32(ini.IniReadValue("Settings", "RefreshTime")) * 60 * 1000; // time in the config * minutes
            }
            else
            {
                LoadElements("Екатеринбург");
                timer_refresh.Interval = 10 * 60 * 1000; // ten minutes
            }

            #region Darkmode
            (Color, Color, Color) colors = other.other.CheckDarkMode(bool.Parse(ini.IniReadValue("Settings", "DarkMode")));
            this.BackColor = colors.Item2;

            #region left panel
            lbl_cityName.BackColor = colors.Item1;
            lbl_cityName.ForeColor = colors.Item3;
            pbox_globalStatus.BaseColor = colors.Item1;
            lbl_temperature.ForeColor = colors.Item3;
            lbl_temperatureUnit.ForeColor = colors.Item3;
            lbl_day.ForeColor = colors.Item3;
            lbl_description.ForeColor = colors.Item3;
            tbox_search.ForeColor = colors.Item3;
            tbox_search.BackColor = colors.Item1;
            pnl_left.BackColor = colors.Item1;

            #endregion

            #region main
            lbl_today.ForeColor = colors.Item3;
            btn_close.IconColor = colors.Item3;
            btn_minimize.IconColor = colors.Item3;

            #region Wind
            lbl_windSpeed.ForeColor = colors.Item3;
            lbl_windUnit.ForeColor = colors.Item3;
            lbl_windUnit.ForeColor = colors.Item3;
            lbl_windDirection.ForeColor = colors.Item3;
            pnl_wind.BaseColor = colors.Item1;

            #endregion

            #region sunriseSunset
            lbl_sunrise.ForeColor = colors.Item3;
            lbl_sunset.ForeColor = colors.Item3;
            pnl_sunriseSunset.BaseColor = colors.Item1;
            #endregion

            #region visibility
            lbl_visibility.ForeColor = colors.Item3;
            lbl_visibilityUnit.ForeColor = colors.Item3;
            lbl_visibilityText.ForeColor = colors.Item3;
            pnl_visibility.BaseColor = colors.Item1;
            #endregion

            #region humidity
            lbl_humidity.ForeColor = colors.Item3;
            lbl_humidityUnit.ForeColor = colors.Item3;
            lbl_humidityText.ForeColor = colors.Item3;
            pnl_humidity.BaseColor = colors.Item1;

            #endregion

            #endregion

            #endregion

        }
        private dynamic weather;
        public async void LoadElements(string cityName)
        {
            try
            {

                connectedToInternet();

                DateTime today = DateTime.Now;

                weather = await WeatherServ.load(cityName);

                #region wind speed
                lbl_windSpeed.Text = weather.wind.speed.ToString();
                lbl_windUnit.Location = new Point(lbl_windSpeed.Width - 2, lbl_windUnit.Location.Y);
                lbl_windDirection.Text = other.other.windDirection(weather.wind.deg);
                #endregion

                #region sunset&sunrise
                lbl_sunrise.Text = other.other.ConvertFromUnixTimestamp(weather.sys.sunrise).ToLocalTime().ToString(@"hh\:mm") + " утра";
                lbl_sunset.Text = other.other.ConvertFromUnixTimestamp(weather.sys.sunset).ToLocalTime().ToString(@"hh\:mm") + " ночи";
                #endregion

                #region visibility
                double visibility = weather.visibility / 1000;
                lbl_visibility.Text = visibility.ToString();
                lbl_visibilityUnit.Location = new Point(lbl_visibility.Width - 2, lbl_visibilityUnit.Location.Y);
                switch (visibility)
                {
                    case double n when (n >= 7):
                        lbl_visibilityText.Text = "Нормально";
                        break;
                    case double n when (n >= 5):
                        lbl_visibilityText.Text = "Средне";
                        break;
                    case double n when (n >= 0):
                        lbl_visibilityText.Text = "Плохо";
                        break;
                }
                #endregion

                #region humidity
                int humidity = weather.main.humidity;
                lbl_humidity.Text = humidity.ToString();
                lbl_humidityUnit.Location = new Point(lbl_humidity.Width - 2, lbl_humidityUnit.Location.Y);
                tbar_humidity.Value = humidity;
                switch (other.other.ktoCelsius(weather.main.temp))
                {
                    case double n when ((n >= 20 && n <= 40 && humidity <= 40) || (n >= 10 && n <= 20 && humidity <= 30) || (n <= 10 && humidity <= 20)):
                        lbl_humidityText.Text = "Нормально";
                        break;
                    case double n when (humidity <= 10):
                        lbl_humidityText.Text = "Сухо";
                        break;
                    default:
                        lbl_humidityText.Text = "Влажно";
                        break;
                }
                #endregion

                #region left_panel
                lbl_cityName.Text = weather.name;
                if (rbtn_celsius.Checked)
                    lbl_temperature.Text = Math.Round(other.other.ktoCelsius(weather.main.temp), 1).ToString();
                if (rbtn_fahrenheit.Checked)
                    lbl_temperature.Text = Math.Round(other.other.ktoFahreneit(weather.main.temp), 1).ToString();

                lbl_temperatureUnit.Location = new Point(lbl_temperature.Location.X + lbl_temperature.Width - 3, lbl_temperatureUnit.Location.Y);

                System.Globalization.CultureInfo ruCulture = new System.Globalization.CultureInfo("ru-RU"); // create a CultureInfo object for Russian
                lbl_day.Text = today.ToString("dddd,", ruCulture);  // get today's day of the week in Russian
                lbl_hour.Location = new Point(lbl_day.Location.X + lbl_day.Width, lbl_day.Location.Y);
                lbl_hour.Text = today.ToShortTimeString();
                lbl_description.Text = weather.weather[0].description;
                pbox_globalStatus.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(weather.weather[0].icon);
                pbox_city.Load($"https://www.countryflags.io/{weather.sys.country}/shiny/64.png");
                #endregion


            }
            catch (Exception)
            {

            }
            //  catch (Exception)
            //  {
            //      MessageBox.Show($"{tbox_search.Text} doesn't exist inside our database or in real life", "City not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //  }
        }
        private void connectedToInternet()
        {
            try
            {
                using (new WebClient().OpenRead("http://google.com/generate_204")) ;
            }
            catch
            {
                timer_refresh.Stop();
                MessageBox.Show("Проверьте ваше интернет-соединение, затем запустите ZluxiaWeather", "Не удалось подключиться к интернету", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void rbtn_celsius_Click(object sender, EventArgs e)
        {
            lbl_temperatureUnit.Text = "°C";
            lbl_temperature.Text = Math.Round(other.other.ktoCelsius(weather.main.temp), 1).ToString();
            lbl_temperatureUnit.Location = new Point(lbl_temperature.Width - 3, lbl_temperatureUnit.Location.Y);
        }

        private void rbtn_fahrenheit_Click(object sender, EventArgs e)
        {
            lbl_temperatureUnit.Text = "°F";
            lbl_temperature.Text = Math.Round(other.other.ktoFahreneit(weather.main.temp), 1).ToString();
            lbl_temperatureUnit.Location = new Point(lbl_temperature.Width - 3, lbl_temperatureUnit.Location.Y);
        }

        #region tbox search
        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadElements(tbox_search.Text);
        }

        private void tbox_search_Enter(object sender, EventArgs e)
        {
            if (tbox_search.Text == "Введите город ...")
                tbox_search.Text = String.Empty;
        }

        private void tbox_search_Leave(object sender, EventArgs e)
        {
            if (tbox_search.Text == String.Empty)
                tbox_search.Text = "Введите город ...";

        }

        private void tbox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btn_search.PerformClick();
        }
        #endregion

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            LoadElements(lbl_cityName.Text);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            new form_settings().Show();
        }
        static Form widget;
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            widget = new form_widget(this);
            widget.Show();
            notifyicon_TW.Visible = true;
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_windTitle_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
