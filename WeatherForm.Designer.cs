﻿namespace Weather
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.txtCity = new System.Windows.Forms.TextBox();
            this.icnCurrent = new System.Windows.Forms.PictureBox();
            this.getW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentCond = new System.Windows.Forms.Label();
            this.lblCurrentF = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTodayCond = new System.Windows.Forms.Label();
            this.lblTodayHigh = new System.Windows.Forms.Label();
            this.lblTodayLow = new System.Windows.Forms.Label();
            this.icnToday = new System.Windows.Forms.PictureBox();
            this.icnTomorrow = new System.Windows.Forms.PictureBox();
            this.lblTomorrowLow = new System.Windows.Forms.Label();
            this.lblTomorrowHigh = new System.Windows.Forms.Label();
            this.lblTomorrowCond = new System.Windows.Forms.Label();
            this.lblTomorrow = new System.Windows.Forms.Label();
            this.icnDay2 = new System.Windows.Forms.PictureBox();
            this.lblDay2Low = new System.Windows.Forms.Label();
            this.lblDay2High = new System.Windows.Forms.Label();
            this.lblDay2Cond = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.icnDay3 = new System.Windows.Forms.PictureBox();
            this.lblDay3Low = new System.Windows.Forms.Label();
            this.lblDay3High = new System.Windows.Forms.Label();
            this.lblDay3Cond = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxEdit1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.icnCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnDay3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(13, 13);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(104, 20);
            this.txtCity.TabIndex = 1;
            // 
            // icnCurrent
            // 
            this.icnCurrent.Location = new System.Drawing.Point(12, 133);
            this.icnCurrent.Name = "icnCurrent";
            this.icnCurrent.Size = new System.Drawing.Size(59, 50);
            this.icnCurrent.TabIndex = 2;
            this.icnCurrent.TabStop = false;
            // 
            // getW
            // 
            this.getW.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.getW.Location = new System.Drawing.Point(132, 11);
            this.getW.Name = "getW";
            this.getW.Size = new System.Drawing.Size(93, 23);
            this.getW.TabIndex = 3;
            this.getW.Text = "Get Weather";
            this.getW.UseVisualStyleBackColor = true;
            this.getW.Click += new System.EventHandler(this.getW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Conditions";
            // 
            // lblCurrentCond
            // 
            this.lblCurrentCond.AutoSize = true;
            this.lblCurrentCond.Location = new System.Drawing.Point(13, 85);
            this.lblCurrentCond.Name = "lblCurrentCond";
            this.lblCurrentCond.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentCond.TabIndex = 5;
            // 
            // lblCurrentF
            // 
            this.lblCurrentF.AutoSize = true;
            this.lblCurrentF.Location = new System.Drawing.Point(13, 100);
            this.lblCurrentF.Name = "lblCurrentF";
            this.lblCurrentF.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentF.TabIndex = 6;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(13, 115);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(0, 13);
            this.lblWind.TabIndex = 7;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(215, 61);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(0, 13);
            this.lblToday.TabIndex = 8;
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayCond
            // 
            this.lblTodayCond.AutoSize = true;
            this.lblTodayCond.Location = new System.Drawing.Point(189, 85);
            this.lblTodayCond.Name = "lblTodayCond";
            this.lblTodayCond.Size = new System.Drawing.Size(0, 13);
            this.lblTodayCond.TabIndex = 9;
            // 
            // lblTodayHigh
            // 
            this.lblTodayHigh.AutoSize = true;
            this.lblTodayHigh.Location = new System.Drawing.Point(189, 100);
            this.lblTodayHigh.Name = "lblTodayHigh";
            this.lblTodayHigh.Size = new System.Drawing.Size(0, 13);
            this.lblTodayHigh.TabIndex = 10;
            // 
            // lblTodayLow
            // 
            this.lblTodayLow.AutoSize = true;
            this.lblTodayLow.Location = new System.Drawing.Point(189, 115);
            this.lblTodayLow.Name = "lblTodayLow";
            this.lblTodayLow.Size = new System.Drawing.Size(0, 13);
            this.lblTodayLow.TabIndex = 11;
            // 
            // icnToday
            // 
            this.icnToday.Location = new System.Drawing.Point(204, 131);
            this.icnToday.Name = "icnToday";
            this.icnToday.Size = new System.Drawing.Size(58, 52);
            this.icnToday.TabIndex = 12;
            this.icnToday.TabStop = false;
            // 
            // icnTomorrow
            // 
            this.icnTomorrow.Location = new System.Drawing.Point(332, 131);
            this.icnTomorrow.Name = "icnTomorrow";
            this.icnTomorrow.Size = new System.Drawing.Size(58, 52);
            this.icnTomorrow.TabIndex = 17;
            this.icnTomorrow.TabStop = false;
            // 
            // lblTomorrowLow
            // 
            this.lblTomorrowLow.AutoSize = true;
            this.lblTomorrowLow.Location = new System.Drawing.Point(317, 115);
            this.lblTomorrowLow.Name = "lblTomorrowLow";
            this.lblTomorrowLow.Size = new System.Drawing.Size(0, 13);
            this.lblTomorrowLow.TabIndex = 16;
            // 
            // lblTomorrowHigh
            // 
            this.lblTomorrowHigh.AutoSize = true;
            this.lblTomorrowHigh.Location = new System.Drawing.Point(317, 100);
            this.lblTomorrowHigh.Name = "lblTomorrowHigh";
            this.lblTomorrowHigh.Size = new System.Drawing.Size(0, 13);
            this.lblTomorrowHigh.TabIndex = 15;
            // 
            // lblTomorrowCond
            // 
            this.lblTomorrowCond.AutoSize = true;
            this.lblTomorrowCond.Location = new System.Drawing.Point(317, 85);
            this.lblTomorrowCond.Name = "lblTomorrowCond";
            this.lblTomorrowCond.Size = new System.Drawing.Size(0, 13);
            this.lblTomorrowCond.TabIndex = 14;
            // 
            // lblTomorrow
            // 
            this.lblTomorrow.AutoSize = true;
            this.lblTomorrow.Location = new System.Drawing.Point(343, 61);
            this.lblTomorrow.Name = "lblTomorrow";
            this.lblTomorrow.Size = new System.Drawing.Size(0, 13);
            this.lblTomorrow.TabIndex = 13;
            this.lblTomorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icnDay2
            // 
            this.icnDay2.Location = new System.Drawing.Point(455, 131);
            this.icnDay2.Name = "icnDay2";
            this.icnDay2.Size = new System.Drawing.Size(58, 52);
            this.icnDay2.TabIndex = 22;
            this.icnDay2.TabStop = false;
            // 
            // lblDay2Low
            // 
            this.lblDay2Low.AutoSize = true;
            this.lblDay2Low.Location = new System.Drawing.Point(440, 115);
            this.lblDay2Low.Name = "lblDay2Low";
            this.lblDay2Low.Size = new System.Drawing.Size(0, 13);
            this.lblDay2Low.TabIndex = 21;
            // 
            // lblDay2High
            // 
            this.lblDay2High.AutoSize = true;
            this.lblDay2High.Location = new System.Drawing.Point(440, 100);
            this.lblDay2High.Name = "lblDay2High";
            this.lblDay2High.Size = new System.Drawing.Size(0, 13);
            this.lblDay2High.TabIndex = 20;
            // 
            // lblDay2Cond
            // 
            this.lblDay2Cond.AutoSize = true;
            this.lblDay2Cond.Location = new System.Drawing.Point(440, 85);
            this.lblDay2Cond.Name = "lblDay2Cond";
            this.lblDay2Cond.Size = new System.Drawing.Size(0, 13);
            this.lblDay2Cond.TabIndex = 19;
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Location = new System.Drawing.Point(466, 61);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(0, 13);
            this.lblDay2.TabIndex = 18;
            this.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icnDay3
            // 
            this.icnDay3.Location = new System.Drawing.Point(578, 131);
            this.icnDay3.Name = "icnDay3";
            this.icnDay3.Size = new System.Drawing.Size(58, 52);
            this.icnDay3.TabIndex = 27;
            this.icnDay3.TabStop = false;
            // 
            // lblDay3Low
            // 
            this.lblDay3Low.AutoSize = true;
            this.lblDay3Low.Location = new System.Drawing.Point(563, 115);
            this.lblDay3Low.Name = "lblDay3Low";
            this.lblDay3Low.Size = new System.Drawing.Size(0, 13);
            this.lblDay3Low.TabIndex = 26;
            // 
            // lblDay3High
            // 
            this.lblDay3High.AutoSize = true;
            this.lblDay3High.Location = new System.Drawing.Point(563, 100);
            this.lblDay3High.Name = "lblDay3High";
            this.lblDay3High.Size = new System.Drawing.Size(0, 13);
            this.lblDay3High.TabIndex = 25;
            // 
            // lblDay3Cond
            // 
            this.lblDay3Cond.AutoSize = true;
            this.lblDay3Cond.Location = new System.Drawing.Point(563, 85);
            this.lblDay3Cond.Name = "lblDay3Cond";
            this.lblDay3Cond.Size = new System.Drawing.Size(0, 13);
            this.lblDay3Cond.TabIndex = 24;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Location = new System.Drawing.Point(589, 61);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(0, 13);
            this.lblDay3.TabIndex = 23;
            this.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Maroon;
            this.lblCity.Location = new System.Drawing.Point(7, 36);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 25);
            this.lblCity.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Weather.Properties.Settings.Default, "intervalText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxEdit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit1.FormattingEnabled = true;
            this.comboBoxEdit1.Items.AddRange(new object[] {
            "Never",
            "1 Minute",
            "2 Minutes",
            "5 Minutes",
            "10 Minutes",
            "30 Minutes",
            "1 Hour",
            "2 Hours",
            "4 Hours"});
            this.comboBoxEdit1.Location = new System.Drawing.Point(555, 11);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEdit1.TabIndex = 31;
            this.comboBoxEdit1.Text = global::Weather.Properties.Settings.Default.intervalText;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "AutoUpdate:";
            // 
            // comboLang
            // 
            this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Items.AddRange(new object[] {
            "English (GB)",
            "English (US)",
            "Deutsch",
            "Français",
            "Italiano",
            "日本語",
            "Русский"});
            this.comboLang.Location = new System.Drawing.Point(283, 11);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(121, 21);
            this.comboLang.TabIndex = 33;
            this.comboLang.SelectedIndexChanged += new System.EventHandler(this.comboLang_SelectedIndexChanged);
            // 
            // WeatherForm
            // 
            this.AcceptButton = this.getW;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(688, 197);
            this.Controls.Add(this.comboLang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.icnDay3);
            this.Controls.Add(this.lblDay3Low);
            this.Controls.Add(this.lblDay3High);
            this.Controls.Add(this.lblDay3Cond);
            this.Controls.Add(this.lblDay3);
            this.Controls.Add(this.icnDay2);
            this.Controls.Add(this.lblDay2Low);
            this.Controls.Add(this.lblDay2High);
            this.Controls.Add(this.lblDay2Cond);
            this.Controls.Add(this.lblDay2);
            this.Controls.Add(this.icnTomorrow);
            this.Controls.Add(this.lblTomorrowLow);
            this.Controls.Add(this.lblTomorrowHigh);
            this.Controls.Add(this.lblTomorrowCond);
            this.Controls.Add(this.lblTomorrow);
            this.Controls.Add(this.icnToday);
            this.Controls.Add(this.lblTodayLow);
            this.Controls.Add(this.lblTodayHigh);
            this.Controls.Add(this.lblTodayCond);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblCurrentF);
            this.Controls.Add(this.lblCurrentCond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getW);
            this.Controls.Add(this.icnCurrent);
            this.Controls.Add(this.txtCity);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Weather.Properties.Settings.Default, "windowPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::Weather.Properties.Settings.Default.windowPosition;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeatherForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeatherForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.icnCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnDay3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Animaonline.WeatherAPI.WeatherData wD;

        private string City;
        public int delay;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.PictureBox icnCurrent;
        private System.Windows.Forms.Button getW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentCond;
        private System.Windows.Forms.Label lblCurrentF;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTodayCond;
        private System.Windows.Forms.Label lblTodayHigh;
        private System.Windows.Forms.Label lblTodayLow;
        private System.Windows.Forms.PictureBox icnToday;
        private System.Windows.Forms.PictureBox icnTomorrow;
        private System.Windows.Forms.Label lblTomorrowLow;
        private System.Windows.Forms.Label lblTomorrowHigh;
        private System.Windows.Forms.Label lblTomorrowCond;
        private System.Windows.Forms.Label lblTomorrow;
        private System.Windows.Forms.PictureBox icnDay2;
        private System.Windows.Forms.Label lblDay2Low;
        private System.Windows.Forms.Label lblDay2High;
        private System.Windows.Forms.Label lblDay2Cond;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.PictureBox icnDay3;
        private System.Windows.Forms.Label lblDay3Low;
        private System.Windows.Forms.Label lblDay3High;
        private System.Windows.Forms.Label lblDay3Cond;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox comboBoxEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboLang;
    }
}

