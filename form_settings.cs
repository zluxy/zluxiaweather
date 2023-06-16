using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZluxiaWeather.other;
using IWshRuntimeLibrary;
using System.Reflection;

namespace ZluxiaWeather
{
    public partial class form_settings : Form
    {
        public form_settings()
        {
            InitializeComponent();
        }

        static string configFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\config.ini";
        static string autoStart_path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\ZluxiaWeather.lnk";
        cfg ini = new cfg(configFile);

        private void form_settings_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(configFile))
            {
                if (ini.IniReadValue("Settings", "StartCity") != String.Empty)
                    tbox_cityName.Text = ini.IniReadValue("Settings", "StartCity");
                if (bool.Parse(ini.IniReadValue("Settings", "DarkMode")))
                    sw_darkMode.Checked = true;
                if (bool.Parse(ini.IniReadValue("Settings", "Fahreneit")))
                    sw_fahreneit.Checked = true;
                if (bool.Parse(ini.IniReadValue("Settings", "TopMost")))
                    sw_topMost.Checked = true;
            }

            #region Darkmode
            (Color, Color, Color) colors = other.other.CheckDarkMode(bool.Parse(ini.IniReadValue("Settings", "DarkMode")));
            this.BackColor = colors.Item2;
            btn_close.IconColor = colors.Item3;
            foreach (Control lbl in Controls)
            {
                if (lbl is GunaLabel)
                    lbl.ForeColor = colors.Item3;
            }
            tbox_cityName.BaseColor = colors.Item1;
            tbox_cityName.ForeColor = colors.Item3;
            tbox_cityName.FocusedBaseColor = colors.Item1;
            tbox_cityName.FocusedForeColor = colors.Item3;
            num_refreshTime.BaseColor = colors.Item1;
            num_refreshTime.ForeColor = colors.Item3;
            #endregion

            checkAutoStart();
        }

        #region checkAutoStart
        private void checkAutoStart()
        {
            if (System.IO.File.Exists(autoStart_path))
            {
                btn_autoStart.BaseColor = Color.Red;
                btn_autoStart.Text = "Удалить";
            }
            else
            {
                btn_autoStart.BaseColor = Color.DodgerBlue;
                btn_autoStart.Text = "Создать";
            }
        }
        #endregion

        #region save & create shortcut
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(configFile))
                System.IO.File.WriteAllText(configFile, String.Empty);

            using (StreamWriter sw = (System.IO.File.Exists(configFile)) ? System.IO.File.AppendText(configFile) : System.IO.File.CreateText(configFile))
            {
                sw.Flush();
                sw.WriteLine("[Settings]");
                sw.WriteLine($"StartCity={tbox_cityName.Text}");
                sw.WriteLine($"RefreshTime={num_refreshTime.Value}");
                sw.WriteLine($"DarkMode={sw_darkMode.Checked}");
                sw.WriteLine($"Fahreneit={sw_fahreneit.Checked}");
                sw.WriteLine($"TopMost={sw_topMost.Checked}");
                sw.Close();
            }

            Notify("Настройки успешно сохранены", "ZluxiaWeather", "Уведомление о сохранении");
        }

        private void btn_createShortcut_Click(object sender, EventArgs e)
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\ZluxiaWeather.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Новый ярлык для ZluxiaWeather";
            shortcut.TargetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\ZluxiaWeather.exe";
            shortcut.Save();

            Notify("Ярлык успешно создан", "ZluxiaWeather", "Ярлык создан");
        }

        private void Notify(string tipText, string text, string title)
        {
            notifyIcon_save.BalloonTipText = tipText;
            notifyIcon_save.Text = text;
            notifyIcon_save.BalloonTipTitle = title;
            notifyIcon_save.Visible = true;
            notifyIcon_save.ShowBalloonTip(1000);
        }
        #endregion

        #region tbox cityName
        private void tbox_cityName_Enter(object sender, EventArgs e)
        {
            if (tbox_cityName.Text == "Лондон")
                tbox_cityName.Text = String.Empty;
        }

        private void tbox_cityName_Leave(object sender, EventArgs e)
        {
            if (tbox_cityName.Text.Length == 0)
                tbox_cityName.Text = "Лондон";
        }
        #endregion

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Вы хотите перезапустить ZluxiaWeather?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg.Equals(DialogResult.Yes))
                Application.Restart();
        }

        private void btn_autoStart_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(autoStart_path))
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(autoStart_path);
                shortcut.Description = "Новый ярлык для ZluxiaWeather";
                shortcut.TargetPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\ZluxiaWeather.exe";
                shortcut.Save();

                Notify("ZluxiaWeather теперь будет запускаться вместе с Windows", "ZluxiaWeather", "Добавлено автозапуск");
            }
            else
            {
                System.IO.File.Delete(autoStart_path);
                Notify("ZluxiaWeather удален из папки автозапуска Windows", "ZluxiaWeather", "Автозапуск удален");
            }

            checkAutoStart();
        }

        private void tbox_cityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_refreshTime_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Fahreneit_Click(object sender, EventArgs e)
        {

        }
    }
}
