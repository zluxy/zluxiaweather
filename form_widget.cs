using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZluxiaWeather.Core;
using ZluxiaWeather.Properties;
using ZluxiaWeather.other;

namespace ZluxiaWeather
{
    public partial class form_widget : Form
    {
        private static Form parentForm;
        public form_widget(Form frm)
        {
            parentForm = frm;
            InitializeComponent();
        }
        static string configFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.ini";
        cfg ini = new cfg(configFile);
        private void form_widget_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            if (File.Exists(configFile))
            {
                LoadElements(ini.IniReadValue("Settings", "StartCity"));
                timer_refresh.Interval = Convert.ToInt32(ini.IniReadValue("Settings", "RefreshTime")) * 1000;//60*1000; // time in the config * minutes
            }
            else
            {
                LoadElements("London");
                timer_refresh.Interval = 10 * 60 * 1000;
            }
            this.AutoSize = true;

            if (ConfigurationManager.AppSettings["PoseX"] != String.Empty && ConfigurationManager.AppSettings["PoseY"] != String.Empty)
            {
                this.Location = new Point(Convert.ToInt32(ConfigurationManager.AppSettings["PoseX"]), Convert.ToInt32(ConfigurationManager.AppSettings["PoseY"]));
            }
            else
            {
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - (this.Width / 2), 0);
            }


            if (bool.Parse(ini.IniReadValue("Settings", "TopMost")))
                this.TopMost = true;

            #region Darkmode
            (Color, Color, Color) colors = other.other.CheckDarkMode(bool.Parse(ini.IniReadValue("Settings", "DarkMode")));
            this.BackColor = colors.Item2;
            lbl_cityName.ForeColor = colors.Item3;
            lbl_temperature.ForeColor = colors.Item3;
            #endregion
        }

        public async void LoadElements(string cityName)
        {
            connectedToInternet();

            DateTime today = DateTime.Now;
            var weather = await WeatherServ.load(cityName);
            pbox_globalStatus.Image = (Bitmap)Resources.ResourceManager.GetObject(weather.weather[0].icon);

            if (bool.Parse(ini.IniReadValue("Settings", "Fahreneit")))
                lbl_temperature.Text = Math.Round(other.other.ktoFahreneit(weather.main.temp), 1).ToString() + " °F";
            else
                lbl_temperature.Text = Math.Round(other.other.ktoCelsius(weather.main.temp), 1).ToString() + " °C";

            lbl_cityName.Text = $"{weather.name}, {weather.sys.country}";

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
                MessageBox.Show("Check your internet connection, then start ZluxiaWeather", "Can't reach internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }


        #region show mainform

        private void CloseForm(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["PoseX"].Value = this.Location.X.ToString();
            config.AppSettings.Settings["PoseY"].Value = this.Location.Y.ToString();
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
            this.Close();
        }

        private void form_widget_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Visible = true;
            parentForm.WindowState = FormWindowState.Normal;
        }

        #endregion

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            LoadElements(lbl_cityName.Text);
        }

        private void lbl_cityName_Click(object sender, EventArgs e)
        {

        }
    }
}
