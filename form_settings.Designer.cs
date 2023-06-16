namespace ZluxiaWeather
{
    partial class form_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_settings));
            this.elipse_form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.btn_close = new Guna.UI.WinForms.GunaControlBox();
            this.lbl_cityName = new Guna.UI.WinForms.GunaLabel();
            this.sw_darkMode = new Guna.UI.WinForms.GunaWinSwitch();
            this.lbl_darkMode = new Guna.UI.WinForms.GunaLabel();
            this.lbl_shortcut = new Guna.UI.WinForms.GunaLabel();
            this.btn_createShortcut = new Guna.UI.WinForms.GunaButton();
            this.tbox_cityName = new Guna.UI.WinForms.GunaTextBox();
            this.btn_save = new Guna.UI.WinForms.GunaButton();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.drag_form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.notifyIcon_save = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_refreshTime = new Guna.UI.WinForms.GunaLabel();
            this.num_refreshTime = new Guna.UI.WinForms.GunaNumeric();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_Fahreneit = new Guna.UI.WinForms.GunaLabel();
            this.sw_fahreneit = new Guna.UI.WinForms.GunaWinSwitch();
            this.lbl_widgetSettings = new Guna.UI.WinForms.GunaLabel();
            this.lbl_topMost = new Guna.UI.WinForms.GunaLabel();
            this.sw_topMost = new Guna.UI.WinForms.GunaWinSwitch();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.btn_autoStart = new Guna.UI.WinForms.GunaButton();
            this.lbl_autoStart = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.Radius = 20;
            this.elipse_form.TargetControl = this;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(84, 19);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Настройки";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconSize = 15F;
            this.btn_close.Location = new System.Drawing.Point(384, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBackColor = System.Drawing.Color.Red;
            this.btn_close.OnHoverIconColor = System.Drawing.Color.White;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(45, 29);
            this.btn_close.TabIndex = 1;
            this.btn_close.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.Location = new System.Drawing.Point(18, 95);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(144, 19);
            this.lbl_cityName.TabIndex = 3;
            this.lbl_cityName.Text = "Стандартный город";
            // 
            // sw_darkMode
            // 
            this.sw_darkMode.BaseColor = System.Drawing.SystemColors.Control;
            this.sw_darkMode.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.sw_darkMode.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.sw_darkMode.FillColor = System.Drawing.Color.White;
            this.sw_darkMode.Location = new System.Drawing.Point(155, 217);
            this.sw_darkMode.Name = "sw_darkMode";
            this.sw_darkMode.Size = new System.Drawing.Size(43, 22);
            this.sw_darkMode.TabIndex = 4;
            // 
            // lbl_darkMode
            // 
            this.lbl_darkMode.AutoSize = true;
            this.lbl_darkMode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_darkMode.Location = new System.Drawing.Point(18, 217);
            this.lbl_darkMode.Name = "lbl_darkMode";
            this.lbl_darkMode.Size = new System.Drawing.Size(115, 19);
            this.lbl_darkMode.TabIndex = 5;
            this.lbl_darkMode.Text = "Темный режим";
            // 
            // lbl_shortcut
            // 
            this.lbl_shortcut.AutoSize = true;
            this.lbl_shortcut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_shortcut.Location = new System.Drawing.Point(221, 57);
            this.lbl_shortcut.Name = "lbl_shortcut";
            this.lbl_shortcut.Size = new System.Drawing.Size(133, 18);
            this.lbl_shortcut.TabIndex = 6;
            this.lbl_shortcut.Text = "Ярлык на раб.столе";
            // 
            // btn_createShortcut
            // 
            this.btn_createShortcut.AnimationHoverSpeed = 0.07F;
            this.btn_createShortcut.AnimationSpeed = 0.03F;
            this.btn_createShortcut.BackColor = System.Drawing.Color.Transparent;
            this.btn_createShortcut.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_createShortcut.BorderColor = System.Drawing.Color.Black;
            this.btn_createShortcut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_createShortcut.FocusedColor = System.Drawing.Color.Empty;
            this.btn_createShortcut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_createShortcut.ForeColor = System.Drawing.Color.White;
            this.btn_createShortcut.Image = null;
            this.btn_createShortcut.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_createShortcut.Location = new System.Drawing.Point(363, 52);
            this.btn_createShortcut.Name = "btn_createShortcut";
            this.btn_createShortcut.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btn_createShortcut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_createShortcut.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_createShortcut.OnHoverImage = null;
            this.btn_createShortcut.OnPressedColor = System.Drawing.Color.Black;
            this.btn_createShortcut.Radius = 5;
            this.btn_createShortcut.Size = new System.Drawing.Size(66, 29);
            this.btn_createShortcut.TabIndex = 7;
            this.btn_createShortcut.Text = "Создать";
            this.btn_createShortcut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_createShortcut.Click += new System.EventHandler(this.btn_createShortcut_Click);
            // 
            // tbox_cityName
            // 
            this.tbox_cityName.BackColor = System.Drawing.Color.Transparent;
            this.tbox_cityName.BaseColor = System.Drawing.Color.White;
            this.tbox_cityName.BorderColor = System.Drawing.Color.Silver;
            this.tbox_cityName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_cityName.FocusedBaseColor = System.Drawing.Color.White;
            this.tbox_cityName.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.tbox_cityName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbox_cityName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_cityName.Location = new System.Drawing.Point(22, 126);
            this.tbox_cityName.Name = "tbox_cityName";
            this.tbox_cityName.PasswordChar = '\0';
            this.tbox_cityName.Radius = 10;
            this.tbox_cityName.SelectedText = "";
            this.tbox_cityName.Size = new System.Drawing.Size(160, 30);
            this.tbox_cityName.TabIndex = 8;
            this.tbox_cityName.Text = "Екатеринбург";
            this.tbox_cityName.TextChanged += new System.EventHandler(this.tbox_cityName_TextChanged);
            this.tbox_cityName.Enter += new System.EventHandler(this.tbox_cityName_Enter);
            this.tbox_cityName.Leave += new System.EventHandler(this.tbox_cityName_Leave);
            // 
            // btn_save
            // 
            this.btn_save.AnimationHoverSpeed = 0.07F;
            this.btn_save.AnimationSpeed = 0.03F;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_save.BorderColor = System.Drawing.Color.Black;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = null;
            this.btn_save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_save.Location = new System.Drawing.Point(177, 250);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_save.Radius = 5;
            this.btn_save.Size = new System.Drawing.Size(66, 29);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Сохранить";
            this.btn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(204, 84);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 149);
            this.gunaVSeparator1.TabIndex = 10;
            // 
            // drag_form
            // 
            this.drag_form.TargetControl = this;
            // 
            // notifyIcon_save
            // 
            this.notifyIcon_save.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon_save.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_save.Icon")));
            this.notifyIcon_save.Text = "ZluxiaWeather";
            this.notifyIcon_save.Visible = true;
            // 
            // lbl_refreshTime
            // 
            this.lbl_refreshTime.AutoSize = true;
            this.lbl_refreshTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_refreshTime.Location = new System.Drawing.Point(18, 159);
            this.lbl_refreshTime.Name = "lbl_refreshTime";
            this.lbl_refreshTime.Size = new System.Drawing.Size(146, 19);
            this.lbl_refreshTime.TabIndex = 11;
            this.lbl_refreshTime.Text = "Время обнов. (мин)";
            this.lbl_refreshTime.Click += new System.EventHandler(this.lbl_refreshTime_Click);
            // 
            // num_refreshTime
            // 
            this.num_refreshTime.BaseColor = System.Drawing.Color.White;
            this.num_refreshTime.BorderColor = System.Drawing.Color.Silver;
            this.num_refreshTime.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.num_refreshTime.ButtonForeColor = System.Drawing.Color.White;
            this.num_refreshTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.num_refreshTime.ForeColor = System.Drawing.Color.Black;
            this.num_refreshTime.Location = new System.Drawing.Point(23, 181);
            this.num_refreshTime.Maximum = ((long)(9999999));
            this.num_refreshTime.Minimum = ((long)(0));
            this.num_refreshTime.Name = "num_refreshTime";
            this.num_refreshTime.Size = new System.Drawing.Size(75, 30);
            this.num_refreshTime.TabIndex = 12;
            this.num_refreshTime.Text = "gunaNumeric1";
            this.num_refreshTime.Value = ((long)(10));
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(220, 84);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(209, 8);
            this.gunaSeparator1.TabIndex = 13;
            // 
            // lbl_Fahreneit
            // 
            this.lbl_Fahreneit.AutoSize = true;
            this.lbl_Fahreneit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fahreneit.Location = new System.Drawing.Point(220, 129);
            this.lbl_Fahreneit.Name = "lbl_Fahreneit";
            this.lbl_Fahreneit.Size = new System.Drawing.Size(93, 19);
            this.lbl_Fahreneit.TabIndex = 15;
            this.lbl_Fahreneit.Text = "Фаренгейты";
            this.lbl_Fahreneit.Click += new System.EventHandler(this.lbl_Fahreneit_Click);
            // 
            // sw_fahreneit
            // 
            this.sw_fahreneit.BaseColor = System.Drawing.SystemColors.Control;
            this.sw_fahreneit.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.sw_fahreneit.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.sw_fahreneit.FillColor = System.Drawing.Color.White;
            this.sw_fahreneit.Location = new System.Drawing.Point(360, 129);
            this.sw_fahreneit.Name = "sw_fahreneit";
            this.sw_fahreneit.Size = new System.Drawing.Size(40, 22);
            this.sw_fahreneit.TabIndex = 14;
            // 
            // lbl_widgetSettings
            // 
            this.lbl_widgetSettings.AutoSize = true;
            this.lbl_widgetSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_widgetSettings.Location = new System.Drawing.Point(220, 95);
            this.lbl_widgetSettings.Name = "lbl_widgetSettings";
            this.lbl_widgetSettings.Size = new System.Drawing.Size(152, 19);
            this.lbl_widgetSettings.TabIndex = 16;
            this.lbl_widgetSettings.Text = "Настройки виджетов";
            // 
            // lbl_topMost
            // 
            this.lbl_topMost.AutoSize = true;
            this.lbl_topMost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_topMost.Location = new System.Drawing.Point(220, 163);
            this.lbl_topMost.Name = "lbl_topMost";
            this.lbl_topMost.Size = new System.Drawing.Size(36, 19);
            this.lbl_topMost.TabIndex = 18;
            this.lbl_topMost.Text = "Топ ";
            // 
            // sw_topMost
            // 
            this.sw_topMost.BaseColor = System.Drawing.SystemColors.Control;
            this.sw_topMost.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.sw_topMost.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.sw_topMost.FillColor = System.Drawing.Color.White;
            this.sw_topMost.Location = new System.Drawing.Point(360, 163);
            this.sw_topMost.Name = "sw_topMost";
            this.sw_topMost.Size = new System.Drawing.Size(40, 22);
            this.sw_topMost.TabIndex = 17;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(12, 84);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(186, 8);
            this.gunaSeparator2.TabIndex = 19;
            // 
            // btn_autoStart
            // 
            this.btn_autoStart.Animated = true;
            this.btn_autoStart.AnimationHoverSpeed = 0.07F;
            this.btn_autoStart.AnimationSpeed = 0.03F;
            this.btn_autoStart.BackColor = System.Drawing.Color.Transparent;
            this.btn_autoStart.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btn_autoStart.BorderColor = System.Drawing.Color.Black;
            this.btn_autoStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_autoStart.FocusedColor = System.Drawing.Color.Empty;
            this.btn_autoStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_autoStart.ForeColor = System.Drawing.Color.White;
            this.btn_autoStart.Image = null;
            this.btn_autoStart.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_autoStart.Location = new System.Drawing.Point(132, 52);
            this.btn_autoStart.Name = "btn_autoStart";
            this.btn_autoStart.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btn_autoStart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_autoStart.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_autoStart.OnHoverImage = null;
            this.btn_autoStart.OnPressedColor = System.Drawing.Color.Black;
            this.btn_autoStart.Radius = 5;
            this.btn_autoStart.Size = new System.Drawing.Size(66, 29);
            this.btn_autoStart.TabIndex = 21;
            this.btn_autoStart.Text = "Назначить";
            this.btn_autoStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_autoStart.Click += new System.EventHandler(this.btn_autoStart_Click);
            // 
            // lbl_autoStart
            // 
            this.lbl_autoStart.AutoSize = true;
            this.lbl_autoStart.Font = new System.Drawing.Font("Calibri", 11F);
            this.lbl_autoStart.Location = new System.Drawing.Point(25, 57);
            this.lbl_autoStart.Name = "lbl_autoStart";
            this.lbl_autoStart.Size = new System.Drawing.Size(80, 18);
            this.lbl_autoStart.TabIndex = 20;
            this.lbl_autoStart.Text = "АвтоЗапуск";
            // 
            // form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btn_autoStart);
            this.Controls.Add(this.lbl_autoStart);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.lbl_topMost);
            this.Controls.Add(this.sw_topMost);
            this.Controls.Add(this.lbl_widgetSettings);
            this.Controls.Add(this.lbl_Fahreneit);
            this.Controls.Add(this.sw_fahreneit);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.num_refreshTime);
            this.Controls.Add(this.lbl_refreshTime);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbox_cityName);
            this.Controls.Add(this.btn_createShortcut);
            this.Controls.Add(this.lbl_shortcut);
            this.Controls.Add(this.lbl_darkMode);
            this.Controls.Add(this.sw_darkMode);
            this.Controls.Add(this.lbl_cityName);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZluxiaWeather Settings";
            this.Load += new System.EventHandler(this.form_settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elipse_form;
        private Guna.UI.WinForms.GunaControlBox btn_close;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaLabel lbl_cityName;
        private Guna.UI.WinForms.GunaLabel lbl_darkMode;
        private Guna.UI.WinForms.GunaWinSwitch sw_darkMode;
        private Guna.UI.WinForms.GunaLabel lbl_shortcut;
        private Guna.UI.WinForms.GunaButton btn_createShortcut;
        private Guna.UI.WinForms.GunaTextBox tbox_cityName;
        private Guna.UI.WinForms.GunaButton btn_save;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaDragControl drag_form;
        private System.Windows.Forms.NotifyIcon notifyIcon_save;
        private Guna.UI.WinForms.GunaNumeric num_refreshTime;
        private Guna.UI.WinForms.GunaLabel lbl_refreshTime;
        private Guna.UI.WinForms.GunaLabel lbl_widgetSettings;
        private Guna.UI.WinForms.GunaLabel lbl_Fahreneit;
        private Guna.UI.WinForms.GunaWinSwitch sw_fahreneit;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel lbl_topMost;
        private Guna.UI.WinForms.GunaWinSwitch sw_topMost;
        private Guna.UI.WinForms.GunaButton btn_autoStart;
        private Guna.UI.WinForms.GunaLabel lbl_autoStart;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
    }
}