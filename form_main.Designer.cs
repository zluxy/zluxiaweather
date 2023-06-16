namespace ZluxiaWeather
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.elipse_form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnl_left = new Guna.UI.WinForms.GunaPanel();
            this.lbl_cityName = new Guna.UI.WinForms.GunaLabel();
            this.tbox_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_description = new Guna.UI.WinForms.GunaLabel();
            this.sep_left = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_hour = new Guna.UI.WinForms.GunaLabel();
            this.lbl_day = new Guna.UI.WinForms.GunaLabel();
            this.lbl_temperatureUnit = new Guna.UI.WinForms.GunaLabel();
            this.lbl_temperature = new Guna.UI.WinForms.GunaLabel();
            this.lbl_today = new Guna.UI.WinForms.GunaLabel();
            this.sep_day = new Guna.UI.WinForms.GunaSeparator();
            this.rbtn_celsius = new Guna.UI.WinForms.GunaAdvenceButton();
            this.rbtn_fahrenheit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_humidity = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_humidityText = new Guna.UI.WinForms.GunaLabel();
            this.lbl_humidityUnit = new Guna.UI.WinForms.GunaLabel();
            this.tbar_humidity = new Guna.UI.WinForms.GunaVTrackBar();
            this.lbl_humidity = new Guna.UI.WinForms.GunaLabel();
            this.lbl_humidityTitle = new Guna.UI.WinForms.GunaLabel();
            this.pnl_visibility = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_visibilityText = new Guna.UI.WinForms.GunaLabel();
            this.lbl_visibilityUnit = new Guna.UI.WinForms.GunaLabel();
            this.lbl_visibility = new Guna.UI.WinForms.GunaLabel();
            this.lbl_visibilityTitle = new Guna.UI.WinForms.GunaLabel();
            this.pnl_wind = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_windDirection = new Guna.UI.WinForms.GunaLabel();
            this.lbl_windUnit = new Guna.UI.WinForms.GunaLabel();
            this.lbl_windSpeed = new Guna.UI.WinForms.GunaLabel();
            this.lbl_windTitle = new Guna.UI.WinForms.GunaLabel();
            this.pnl_sunriseSunset = new Guna.UI.WinForms.GunaElipsePanel();
            this.lbl_sunset = new Guna.UI.WinForms.GunaLabel();
            this.lbl_sunrise = new Guna.UI.WinForms.GunaLabel();
            this.lbl_sunriseSunsetTitle = new Guna.UI.WinForms.GunaLabel();
            this.drag_form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btn_close = new Guna.UI.WinForms.GunaControlBox();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.btn_minimize = new Guna.UI.WinForms.GunaControlBox();
            this.notifyicon_TW = new System.Windows.Forms.NotifyIcon(this.components);
            this.pbox_sunset = new Guna.UI.WinForms.GunaPictureBox();
            this.pbox_sunrise = new Guna.UI.WinForms.GunaPictureBox();
            this.pbox_city = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_settings = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_search = new Guna.UI.WinForms.GunaCircleButton();
            this.pbox_globalStatus = new Guna.UI.WinForms.GunaPictureBox();
            this.pnl_left.SuspendLayout();
            this.pnl_humidity.SuspendLayout();
            this.pnl_visibility.SuspendLayout();
            this.pnl_wind.SuspendLayout();
            this.pnl_sunriseSunset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_sunset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_sunrise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_city)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_globalStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.Radius = 40;
            this.elipse_form.TargetControl = this;
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.White;
            this.pnl_left.Controls.Add(this.btn_settings);
            this.pnl_left.Controls.Add(this.lbl_cityName);
            this.pnl_left.Controls.Add(this.btn_search);
            this.pnl_left.Controls.Add(this.tbox_search);
            this.pnl_left.Controls.Add(this.lbl_description);
            this.pnl_left.Controls.Add(this.sep_left);
            this.pnl_left.Controls.Add(this.lbl_hour);
            this.pnl_left.Controls.Add(this.lbl_day);
            this.pnl_left.Controls.Add(this.lbl_temperatureUnit);
            this.pnl_left.Controls.Add(this.lbl_temperature);
            this.pnl_left.Controls.Add(this.pbox_globalStatus);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(232, 644);
            this.pnl_left.TabIndex = 0;
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.Black;
            this.lbl_cityName.Location = new System.Drawing.Point(3, 77);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(229, 41);
            this.lbl_cityName.TabIndex = 17;
            this.lbl_cityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_search
            // 
            this.tbox_search.BackColor = System.Drawing.Color.White;
            this.tbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_search.FocusedLineColor = System.Drawing.Color.DodgerBlue;
            this.tbox_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.LineColor = System.Drawing.Color.Gainsboro;
            this.tbox_search.Location = new System.Drawing.Point(57, 24);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.SelectedText = "";
            this.tbox_search.Size = new System.Drawing.Size(137, 30);
            this.tbox_search.TabIndex = 15;
            this.tbox_search.Text = "Екатеринбург";
            this.tbox_search.TextChanged += new System.EventHandler(this.tbox_search_TextChanged);
            this.tbox_search.Enter += new System.EventHandler(this.tbox_search_Enter);
            this.tbox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_search_KeyPress);
            this.tbox_search.Leave += new System.EventHandler(this.tbox_search_Leave);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_description.Font = new System.Drawing.Font("Calibri", 16F);
            this.lbl_description.ForeColor = System.Drawing.Color.Black;
            this.lbl_description.Location = new System.Drawing.Point(23, 535);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(95, 27);
            this.lbl_description.TabIndex = 10;
            this.lbl_description.Text = "Облачно";
            // 
            // sep_left
            // 
            this.sep_left.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.sep_left.Location = new System.Drawing.Point(13, 517);
            this.sep_left.Name = "sep_left";
            this.sep_left.Size = new System.Drawing.Size(205, 10);
            this.sep_left.TabIndex = 13;
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hour.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lbl_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_hour.Location = new System.Drawing.Point(22, 449);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(67, 31);
            this.lbl_hour.TabIndex = 12;
            this.lbl_hour.Text = "16:00";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_day.ForeColor = System.Drawing.Color.Black;
            this.lbl_day.Location = new System.Drawing.Point(23, 420);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(157, 29);
            this.lbl_day.TabIndex = 10;
            this.lbl_day.Text = "Понедельник,";
            // 
            // lbl_temperatureUnit
            // 
            this.lbl_temperatureUnit.AutoSize = true;
            this.lbl_temperatureUnit.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temperatureUnit.Location = new System.Drawing.Point(110, 355);
            this.lbl_temperatureUnit.Name = "lbl_temperatureUnit";
            this.lbl_temperatureUnit.Size = new System.Drawing.Size(52, 45);
            this.lbl_temperatureUnit.TabIndex = 11;
            this.lbl_temperatureUnit.Text = "°C";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temperature.Font = new System.Drawing.Font("Segoe UI", 54F);
            this.lbl_temperature.Location = new System.Drawing.Point(5, 314);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(118, 96);
            this.lbl_temperature.TabIndex = 10;
            this.lbl_temperature.Text = "10";
            // 
            // lbl_today
            // 
            this.lbl_today.AutoSize = true;
            this.lbl_today.BackColor = System.Drawing.Color.Transparent;
            this.lbl_today.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_today.Location = new System.Drawing.Point(261, 17);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(82, 24);
            this.lbl_today.TabIndex = 1;
            this.lbl_today.Text = "Сегодня";
            // 
            // sep_day
            // 
            this.sep_day.BackColor = System.Drawing.Color.Transparent;
            this.sep_day.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.sep_day.Location = new System.Drawing.Point(265, 44);
            this.sep_day.Name = "sep_day";
            this.sep_day.Size = new System.Drawing.Size(55, 10);
            this.sep_day.TabIndex = 2;
            // 
            // rbtn_celsius
            // 
            this.rbtn_celsius.Animated = true;
            this.rbtn_celsius.AnimationHoverSpeed = 0.07F;
            this.rbtn_celsius.AnimationSpeed = 0.03F;
            this.rbtn_celsius.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_celsius.BaseColor = System.Drawing.Color.White;
            this.rbtn_celsius.BorderColor = System.Drawing.Color.Black;
            this.rbtn_celsius.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rbtn_celsius.Checked = true;
            this.rbtn_celsius.CheckedBaseColor = System.Drawing.Color.Silver;
            this.rbtn_celsius.CheckedBorderColor = System.Drawing.Color.Black;
            this.rbtn_celsius.CheckedForeColor = System.Drawing.Color.Black;
            this.rbtn_celsius.CheckedImage = null;
            this.rbtn_celsius.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rbtn_celsius.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rbtn_celsius.FocusedColor = System.Drawing.Color.Empty;
            this.rbtn_celsius.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_celsius.ForeColor = System.Drawing.Color.Black;
            this.rbtn_celsius.Image = null;
            this.rbtn_celsius.ImageSize = new System.Drawing.Size(20, 20);
            this.rbtn_celsius.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_celsius.Location = new System.Drawing.Point(769, 14);
            this.rbtn_celsius.Name = "rbtn_celsius";
            this.rbtn_celsius.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.rbtn_celsius.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rbtn_celsius.OnHoverForeColor = System.Drawing.Color.White;
            this.rbtn_celsius.OnHoverImage = null;
            this.rbtn_celsius.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_celsius.OnPressedColor = System.Drawing.Color.Black;
            this.rbtn_celsius.Radius = 22;
            this.rbtn_celsius.Size = new System.Drawing.Size(45, 45);
            this.rbtn_celsius.TabIndex = 3;
            this.rbtn_celsius.Text = "°C";
            this.rbtn_celsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rbtn_celsius.Click += new System.EventHandler(this.rbtn_celsius_Click);
            // 
            // rbtn_fahrenheit
            // 
            this.rbtn_fahrenheit.Animated = true;
            this.rbtn_fahrenheit.AnimationHoverSpeed = 0.07F;
            this.rbtn_fahrenheit.AnimationSpeed = 0.03F;
            this.rbtn_fahrenheit.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_fahrenheit.BaseColor = System.Drawing.SystemColors.Window;
            this.rbtn_fahrenheit.BorderColor = System.Drawing.Color.Blue;
            this.rbtn_fahrenheit.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.rbtn_fahrenheit.CheckedBaseColor = System.Drawing.Color.DarkGray;
            this.rbtn_fahrenheit.CheckedBorderColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.CheckedForeColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.CheckedImage = null;
            this.rbtn_fahrenheit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rbtn_fahrenheit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rbtn_fahrenheit.FocusedColor = System.Drawing.Color.Empty;
            this.rbtn_fahrenheit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_fahrenheit.ForeColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.Image = null;
            this.rbtn_fahrenheit.ImageSize = new System.Drawing.Size(20, 20);
            this.rbtn_fahrenheit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_fahrenheit.Location = new System.Drawing.Point(826, 14);
            this.rbtn_fahrenheit.Name = "rbtn_fahrenheit";
            this.rbtn_fahrenheit.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.rbtn_fahrenheit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.rbtn_fahrenheit.OnHoverForeColor = System.Drawing.Color.White;
            this.rbtn_fahrenheit.OnHoverImage = null;
            this.rbtn_fahrenheit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rbtn_fahrenheit.OnPressedColor = System.Drawing.Color.Black;
            this.rbtn_fahrenheit.Radius = 22;
            this.rbtn_fahrenheit.Size = new System.Drawing.Size(45, 45);
            this.rbtn_fahrenheit.TabIndex = 4;
            this.rbtn_fahrenheit.Text = "°F";
            this.rbtn_fahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rbtn_fahrenheit.Click += new System.EventHandler(this.rbtn_fahrenheit_Click);
            // 
            // pnl_humidity
            // 
            this.pnl_humidity.BackColor = System.Drawing.Color.Transparent;
            this.pnl_humidity.BaseColor = System.Drawing.Color.White;
            this.pnl_humidity.Controls.Add(this.lbl_humidityText);
            this.pnl_humidity.Controls.Add(this.lbl_humidityUnit);
            this.pnl_humidity.Controls.Add(this.tbar_humidity);
            this.pnl_humidity.Controls.Add(this.lbl_humidity);
            this.pnl_humidity.Controls.Add(this.lbl_humidityTitle);
            this.pnl_humidity.Location = new System.Drawing.Point(626, 367);
            this.pnl_humidity.Name = "pnl_humidity";
            this.pnl_humidity.Radius = 40;
            this.pnl_humidity.Size = new System.Drawing.Size(333, 235);
            this.pnl_humidity.TabIndex = 5;
            // 
            // lbl_humidityText
            // 
            this.lbl_humidityText.AutoSize = true;
            this.lbl_humidityText.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_humidityText.ForeColor = System.Drawing.Color.Black;
            this.lbl_humidityText.Location = new System.Drawing.Point(33, 185);
            this.lbl_humidityText.Name = "lbl_humidityText";
            this.lbl_humidityText.Size = new System.Drawing.Size(131, 29);
            this.lbl_humidityText.TabIndex = 10;
            this.lbl_humidityText.Text = "Нормально";
            // 
            // lbl_humidityUnit
            // 
            this.lbl_humidityUnit.AutoSize = true;
            this.lbl_humidityUnit.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humidityUnit.Location = new System.Drawing.Point(135, 72);
            this.lbl_humidityUnit.Name = "lbl_humidityUnit";
            this.lbl_humidityUnit.Size = new System.Drawing.Size(46, 45);
            this.lbl_humidityUnit.TabIndex = 6;
            this.lbl_humidityUnit.Text = "%";
            // 
            // tbar_humidity
            // 
            this.tbar_humidity.Enabled = false;
            this.tbar_humidity.Location = new System.Drawing.Point(251, 35);
            this.tbar_humidity.Name = "tbar_humidity";
            this.tbar_humidity.Size = new System.Drawing.Size(23, 166);
            this.tbar_humidity.TabIndex = 5;
            this.tbar_humidity.TrackColor = System.Drawing.Color.DodgerBlue;
            this.tbar_humidity.TrackHoverColor = System.Drawing.Color.Gray;
            this.tbar_humidity.TrackIdleColor = System.Drawing.Color.Silver;
            this.tbar_humidity.TrackPressedColor = System.Drawing.Color.Black;
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humidity.Location = new System.Drawing.Point(13, 68);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_humidity.Size = new System.Drawing.Size(142, 86);
            this.lbl_humidity.TabIndex = 4;
            this.lbl_humidity.Text = "100";
            this.lbl_humidity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_humidityTitle
            // 
            this.lbl_humidityTitle.AutoSize = true;
            this.lbl_humidityTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humidityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_humidityTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_humidityTitle.Name = "lbl_humidityTitle";
            this.lbl_humidityTitle.Size = new System.Drawing.Size(107, 26);
            this.lbl_humidityTitle.TabIndex = 3;
            this.lbl_humidityTitle.Text = "Влажность";
            // 
            // pnl_visibility
            // 
            this.pnl_visibility.BackColor = System.Drawing.Color.Transparent;
            this.pnl_visibility.BaseColor = System.Drawing.Color.White;
            this.pnl_visibility.Controls.Add(this.lbl_visibilityText);
            this.pnl_visibility.Controls.Add(this.lbl_visibilityUnit);
            this.pnl_visibility.Controls.Add(this.lbl_visibility);
            this.pnl_visibility.Controls.Add(this.lbl_visibilityTitle);
            this.pnl_visibility.Location = new System.Drawing.Point(265, 367);
            this.pnl_visibility.Name = "pnl_visibility";
            this.pnl_visibility.Radius = 40;
            this.pnl_visibility.Size = new System.Drawing.Size(333, 235);
            this.pnl_visibility.TabIndex = 6;
            // 
            // lbl_visibilityText
            // 
            this.lbl_visibilityText.AutoSize = true;
            this.lbl_visibilityText.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_visibilityText.ForeColor = System.Drawing.Color.Black;
            this.lbl_visibilityText.Location = new System.Drawing.Point(33, 185);
            this.lbl_visibilityText.Name = "lbl_visibilityText";
            this.lbl_visibilityText.Size = new System.Drawing.Size(131, 29);
            this.lbl_visibilityText.TabIndex = 9;
            this.lbl_visibilityText.Text = "Нормально";
            // 
            // lbl_visibilityUnit
            // 
            this.lbl_visibilityUnit.AutoSize = true;
            this.lbl_visibilityUnit.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visibilityUnit.ForeColor = System.Drawing.Color.Black;
            this.lbl_visibilityUnit.Location = new System.Drawing.Point(148, 109);
            this.lbl_visibilityUnit.Name = "lbl_visibilityUnit";
            this.lbl_visibilityUnit.Size = new System.Drawing.Size(48, 36);
            this.lbl_visibilityUnit.TabIndex = 8;
            this.lbl_visibilityUnit.Text = "км";
            // 
            // lbl_visibility
            // 
            this.lbl_visibility.AutoSize = true;
            this.lbl_visibility.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visibility.Location = new System.Drawing.Point(19, 68);
            this.lbl_visibility.Name = "lbl_visibility";
            this.lbl_visibility.Size = new System.Drawing.Size(142, 86);
            this.lbl_visibility.TabIndex = 7;
            this.lbl_visibility.Text = "100";
            // 
            // lbl_visibilityTitle
            // 
            this.lbl_visibilityTitle.AutoSize = true;
            this.lbl_visibilityTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visibilityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_visibilityTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_visibilityTitle.Name = "lbl_visibilityTitle";
            this.lbl_visibilityTitle.Size = new System.Drawing.Size(109, 26);
            this.lbl_visibilityTitle.TabIndex = 2;
            this.lbl_visibilityTitle.Text = "Видимость";
            // 
            // pnl_wind
            // 
            this.pnl_wind.BackColor = System.Drawing.Color.Transparent;
            this.pnl_wind.BaseColor = System.Drawing.Color.White;
            this.pnl_wind.Controls.Add(this.lbl_windDirection);
            this.pnl_wind.Controls.Add(this.lbl_windUnit);
            this.pnl_wind.Controls.Add(this.lbl_windSpeed);
            this.pnl_wind.Controls.Add(this.lbl_windTitle);
            this.pnl_wind.Location = new System.Drawing.Point(265, 108);
            this.pnl_wind.Name = "pnl_wind";
            this.pnl_wind.Radius = 40;
            this.pnl_wind.Size = new System.Drawing.Size(333, 235);
            this.pnl_wind.TabIndex = 8;
            // 
            // lbl_windDirection
            // 
            this.lbl_windDirection.AutoSize = true;
            this.lbl_windDirection.Font = new System.Drawing.Font("Calibri", 15F);
            this.lbl_windDirection.ForeColor = System.Drawing.Color.Black;
            this.lbl_windDirection.Location = new System.Drawing.Point(30, 185);
            this.lbl_windDirection.Name = "lbl_windDirection";
            this.lbl_windDirection.Size = new System.Drawing.Size(153, 24);
            this.lbl_windDirection.TabIndex = 7;
            this.lbl_windDirection.Text = "Запад-юго-запад";
            // 
            // lbl_windUnit
            // 
            this.lbl_windUnit.AutoSize = true;
            this.lbl_windUnit.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windUnit.ForeColor = System.Drawing.Color.Black;
            this.lbl_windUnit.Location = new System.Drawing.Point(182, 108);
            this.lbl_windUnit.Name = "lbl_windUnit";
            this.lbl_windUnit.Size = new System.Drawing.Size(73, 36);
            this.lbl_windUnit.TabIndex = 6;
            this.lbl_windUnit.Text = "км/ч";
            // 
            // lbl_windSpeed
            // 
            this.lbl_windSpeed.AutoSize = true;
            this.lbl_windSpeed.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windSpeed.Location = new System.Drawing.Point(19, 67);
            this.lbl_windSpeed.Name = "lbl_windSpeed";
            this.lbl_windSpeed.Size = new System.Drawing.Size(177, 86);
            this.lbl_windSpeed.TabIndex = 5;
            this.lbl_windSpeed.Text = "1050";
            // 
            // lbl_windTitle
            // 
            this.lbl_windTitle.AutoSize = true;
            this.lbl_windTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_windTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_windTitle.Name = "lbl_windTitle";
            this.lbl_windTitle.Size = new System.Drawing.Size(62, 26);
            this.lbl_windTitle.TabIndex = 1;
            this.lbl_windTitle.Text = "Ветер";
            this.lbl_windTitle.Click += new System.EventHandler(this.lbl_windTitle_Click);
            // 
            // pnl_sunriseSunset
            // 
            this.pnl_sunriseSunset.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sunriseSunset.BaseColor = System.Drawing.Color.White;
            this.pnl_sunriseSunset.Controls.Add(this.pbox_sunset);
            this.pnl_sunriseSunset.Controls.Add(this.lbl_sunset);
            this.pnl_sunriseSunset.Controls.Add(this.lbl_sunrise);
            this.pnl_sunriseSunset.Controls.Add(this.pbox_sunrise);
            this.pnl_sunriseSunset.Controls.Add(this.lbl_sunriseSunsetTitle);
            this.pnl_sunriseSunset.Location = new System.Drawing.Point(626, 108);
            this.pnl_sunriseSunset.Name = "pnl_sunriseSunset";
            this.pnl_sunriseSunset.Radius = 40;
            this.pnl_sunriseSunset.Size = new System.Drawing.Size(333, 235);
            this.pnl_sunriseSunset.TabIndex = 7;
            // 
            // lbl_sunset
            // 
            this.lbl_sunset.AutoSize = true;
            this.lbl_sunset.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunset.ForeColor = System.Drawing.Color.Black;
            this.lbl_sunset.Location = new System.Drawing.Point(100, 159);
            this.lbl_sunset.Name = "lbl_sunset";
            this.lbl_sunset.Size = new System.Drawing.Size(99, 26);
            this.lbl_sunset.TabIndex = 3;
            this.lbl_sunset.Text = "6:35 ночи";
            // 
            // lbl_sunrise
            // 
            this.lbl_sunrise.AutoSize = true;
            this.lbl_sunrise.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunrise.ForeColor = System.Drawing.Color.Black;
            this.lbl_sunrise.Location = new System.Drawing.Point(100, 91);
            this.lbl_sunrise.Name = "lbl_sunrise";
            this.lbl_sunrise.Size = new System.Drawing.Size(95, 26);
            this.lbl_sunrise.TabIndex = 2;
            this.lbl_sunrise.Text = "6:35 утра";
            // 
            // lbl_sunriseSunsetTitle
            // 
            this.lbl_sunriseSunsetTitle.AutoSize = true;
            this.lbl_sunriseSunsetTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sunriseSunsetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.lbl_sunriseSunsetTitle.Location = new System.Drawing.Point(33, 17);
            this.lbl_sunriseSunsetTitle.Name = "lbl_sunriseSunsetTitle";
            this.lbl_sunriseSunsetTitle.Size = new System.Drawing.Size(145, 26);
            this.lbl_sunriseSunsetTitle.TabIndex = 0;
            this.lbl_sunriseSunsetTitle.Text = "Восход и заход";
            // 
            // drag_form
            // 
            this.drag_form.TargetControl = this;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconSize = 15F;
            this.btn_close.Location = new System.Drawing.Point(930, 17);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBackColor = System.Drawing.Color.Red;
            this.btn_close.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(45, 29);
            this.btn_close.TabIndex = 9;
            // 
            // timer_refresh
            // 
            this.timer_refresh.Enabled = true;
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.AnimationHoverSpeed = 0.07F;
            this.btn_minimize.AnimationSpeed = 0.03F;
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btn_minimize.IconColor = System.Drawing.Color.Black;
            this.btn_minimize.IconSize = 15F;
            this.btn_minimize.Location = new System.Drawing.Point(877, 17);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.OnHoverBackColor = System.Drawing.Color.Red;
            this.btn_minimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_minimize.OnPressedColor = System.Drawing.Color.Black;
            this.btn_minimize.Size = new System.Drawing.Size(45, 29);
            this.btn_minimize.TabIndex = 10;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // notifyicon_TW
            // 
            this.notifyicon_TW.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyicon_TW.Icon")));
            this.notifyicon_TW.Text = "ZluxiaWeather";
            // 
            // pbox_sunset
            // 
            this.pbox_sunset.BaseColor = System.Drawing.Color.Transparent;
            this.pbox_sunset.Image = global::ZluxiaWeather.Properties.Resources.moon;
            this.pbox_sunset.Location = new System.Drawing.Point(38, 144);
            this.pbox_sunset.Name = "pbox_sunset";
            this.pbox_sunset.Size = new System.Drawing.Size(52, 52);
            this.pbox_sunset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_sunset.TabIndex = 4;
            this.pbox_sunset.TabStop = false;
            // 
            // pbox_sunrise
            // 
            this.pbox_sunrise.BaseColor = System.Drawing.Color.Transparent;
            this.pbox_sunrise.Image = ((System.Drawing.Image)(resources.GetObject("pbox_sunrise.Image")));
            this.pbox_sunrise.Location = new System.Drawing.Point(38, 76);
            this.pbox_sunrise.Name = "pbox_sunrise";
            this.pbox_sunrise.Size = new System.Drawing.Size(52, 52);
            this.pbox_sunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_sunrise.TabIndex = 1;
            this.pbox_sunrise.TabStop = false;
            // 
            // pbox_city
            // 
            this.pbox_city.BackColor = System.Drawing.Color.Transparent;
            this.pbox_city.BaseColor = System.Drawing.Color.Transparent;
            this.pbox_city.Location = new System.Drawing.Point(1003, 449);
            this.pbox_city.Name = "pbox_city";
            this.pbox_city.Radius = 15;
            this.pbox_city.Size = new System.Drawing.Size(37, 64);
            this.pbox_city.TabIndex = 14;
            this.pbox_city.TabStop = false;
            // 
            // btn_settings
            // 
            this.btn_settings.Animated = true;
            this.btn_settings.AnimationHoverSpeed = 0.07F;
            this.btn_settings.AnimationSpeed = 0.03F;
            this.btn_settings.BaseColor = System.Drawing.Color.Silver;
            this.btn_settings.BorderColor = System.Drawing.Color.White;
            this.btn_settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_settings.FocusedColor = System.Drawing.Color.Empty;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::ZluxiaWeather.Properties.Resources.settings_off;
            this.btn_settings.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_settings.Location = new System.Drawing.Point(162, 535);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btn_settings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_settings.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_settings.OnHoverImage = global::ZluxiaWeather.Properties.Resources.settings_on;
            this.btn_settings.OnPressedColor = System.Drawing.Color.Black;
            this.btn_settings.Size = new System.Drawing.Size(52, 52);
            this.btn_settings.TabIndex = 18;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_search
            // 
            this.btn_search.AnimationHoverSpeed = 0.07F;
            this.btn_search.AnimationSpeed = 0.03F;
            this.btn_search.BaseColor = System.Drawing.Color.White;
            this.btn_search.BorderColor = System.Drawing.Color.Black;
            this.btn_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_search.FocusedColor = System.Drawing.Color.Empty;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = global::ZluxiaWeather.Properties.Resources.search;
            this.btn_search.ImageSize = new System.Drawing.Size(22, 22);
            this.btn_search.Location = new System.Drawing.Point(16, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_search.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_search.OnHoverImage = global::ZluxiaWeather.Properties.Resources.search_on;
            this.btn_search.OnPressedColor = System.Drawing.Color.Black;
            this.btn_search.Size = new System.Drawing.Size(35, 35);
            this.btn_search.TabIndex = 16;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pbox_globalStatus
            // 
            this.pbox_globalStatus.BackColor = System.Drawing.Color.Transparent;
            this.pbox_globalStatus.BaseColor = System.Drawing.Color.Transparent;
            this.pbox_globalStatus.Image = global::ZluxiaWeather.Properties.Resources._11d;
            this.pbox_globalStatus.Location = new System.Drawing.Point(9, 108);
            this.pbox_globalStatus.Name = "pbox_globalStatus";
            this.pbox_globalStatus.Size = new System.Drawing.Size(205, 196);
            this.pbox_globalStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_globalStatus.TabIndex = 0;
            this.pbox_globalStatus.TabStop = false;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(992, 644);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_wind);
            this.Controls.Add(this.pnl_sunriseSunset);
            this.Controls.Add(this.pbox_city);
            this.Controls.Add(this.rbtn_fahrenheit);
            this.Controls.Add(this.rbtn_celsius);
            this.Controls.Add(this.pnl_visibility);
            this.Controls.Add(this.pnl_humidity);
            this.Controls.Add(this.sep_day);
            this.Controls.Add(this.lbl_today);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZluxiaWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.pnl_humidity.ResumeLayout(false);
            this.pnl_humidity.PerformLayout();
            this.pnl_visibility.ResumeLayout(false);
            this.pnl_visibility.PerformLayout();
            this.pnl_wind.ResumeLayout(false);
            this.pnl_wind.PerformLayout();
            this.pnl_sunriseSunset.ResumeLayout(false);
            this.pnl_sunriseSunset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_sunset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_sunrise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_city)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_globalStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipse_form;
        private Guna.UI.WinForms.GunaPanel pnl_left;
        private Guna.UI.WinForms.GunaAdvenceButton rbtn_fahrenheit;
        private Guna.UI.WinForms.GunaAdvenceButton rbtn_celsius;
        private Guna.UI.WinForms.GunaSeparator sep_day;
        private Guna.UI.WinForms.GunaLabel lbl_today;
        private Guna.UI.WinForms.GunaElipsePanel pnl_wind;
        private Guna.UI.WinForms.GunaLabel lbl_windTitle;
        private Guna.UI.WinForms.GunaElipsePanel pnl_sunriseSunset;
        private Guna.UI.WinForms.GunaLabel lbl_sunriseSunsetTitle;
        private Guna.UI.WinForms.GunaElipsePanel pnl_visibility;
        private Guna.UI.WinForms.GunaLabel lbl_visibilityTitle;
        private Guna.UI.WinForms.GunaElipsePanel pnl_humidity;
        private Guna.UI.WinForms.GunaPictureBox pbox_sunrise;
        private Guna.UI.WinForms.GunaLabel lbl_humidityTitle;
        private Guna.UI.WinForms.GunaLabel lbl_windDirection;
        private Guna.UI.WinForms.GunaLabel lbl_windUnit;
        private Guna.UI.WinForms.GunaLabel lbl_windSpeed;
        private Guna.UI.WinForms.GunaLabel lbl_sunset;
        private Guna.UI.WinForms.GunaLabel lbl_sunrise;
        private Guna.UI.WinForms.GunaLabel lbl_visibilityText;
        private Guna.UI.WinForms.GunaLabel lbl_visibilityUnit;
        private Guna.UI.WinForms.GunaLabel lbl_visibility;
        private Guna.UI.WinForms.GunaLabel lbl_humidityText;
        private Guna.UI.WinForms.GunaLabel lbl_humidityUnit;
        private Guna.UI.WinForms.GunaVTrackBar tbar_humidity;
        private Guna.UI.WinForms.GunaLabel lbl_humidity;
        private Guna.UI.WinForms.GunaLabel lbl_hour;
        private Guna.UI.WinForms.GunaLabel lbl_day;
        private Guna.UI.WinForms.GunaLabel lbl_temperatureUnit;
        private Guna.UI.WinForms.GunaLabel lbl_temperature;
        private Guna.UI.WinForms.GunaPictureBox pbox_globalStatus;
        private Guna.UI.WinForms.GunaDragControl drag_form;
        private Guna.UI.WinForms.GunaSeparator sep_left;
        private Guna.UI.WinForms.GunaPictureBox pbox_city;
        private Guna.UI.WinForms.GunaLabel lbl_description;
        private Guna.UI.WinForms.GunaCircleButton btn_search;
        private Guna.UI.WinForms.GunaLineTextBox tbox_search;
        private Guna.UI.WinForms.GunaLabel lbl_cityName;
        private Guna.UI.WinForms.GunaControlBox btn_close;
        private Guna.UI.WinForms.GunaCircleButton btn_settings;
        private System.Windows.Forms.Timer timer_refresh;
        private Guna.UI.WinForms.GunaControlBox btn_minimize;
        private System.Windows.Forms.NotifyIcon notifyicon_TW;
        private Guna.UI.WinForms.GunaPictureBox pbox_sunset;
    }
}

