using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Animaonline.WeatherAPI;
using System.Threading;
using Weather.Properties;

namespace Weather
{
    public partial class WeatherForm : Form
    {
        LanguageCode Lang;
        string high;
        string low;
        string temp;
        bool celsius;
        string degree;

        public WeatherForm()
        {
            InitializeComponent();
            delay = 1;
            //Load settings
            delay = Settings.Default.intervalTime;
            txtCity.Text = Settings.Default.defaultCity;
            if (txtCity.Text == "")
                txtCity.Text = "North Richland Hills, TX";
            this.Location = Settings.Default.windowPosition;
            comboBoxEdit1.Text = Settings.Default.intervalText;
            City = txtCity.Text;
            comboLang.Text = Settings.Default.defaultLang;
            timer1.Enabled = Settings.Default.timerOn;

            //Get Initial Weather
            City = txtCity.Text;
            getLang(comboLang.Text);
            getWeather(Lang, City);
        }

        private void getW_Click(object sender, EventArgs e)
        {
            //Set delay from minutes to milliseconds
            getDelay(comboBoxEdit1.Text);
            
            //Get Weather
            City = txtCity.Text;
            getLang(comboLang.Text);
            getWeather(Lang, City);

            //Set timer1
            if (comboBoxEdit1.Text == "Never")
            {
                timer1.Enabled = false;
                timer1.Interval = 1;
            }
            if (comboBoxEdit1.Text == "")
            {
                timer1.Enabled = false;
                timer1.Interval = 1;
            }
            else
            {
                timer1.Interval = delay;
                timer1.Enabled = true;
            }
            
        }

        private void getWeather(LanguageCode Lang, string City)
        {
            try
            {
                //Get the data
                wD = WeatherAPI.GetWeather(Lang, City, celsius);

                //Set image locations
                string baseURL = "http://www.google.com";
                string iconToday = baseURL + wD.iconTODAY;
                string icon = baseURL + wD.icon;
                string iconTOMORROW = baseURL + wD.iconTOMORROW;
                string iconDAY2 = baseURL + wD.iconDAY2;
                string iconDAY3 = baseURL + wD.iconDAY3;

                //Set images
                icnCurrent.ImageLocation = icon;
                icnDay2.ImageLocation = iconDAY2;
                icnDay3.ImageLocation = iconDAY3;
                icnToday.ImageLocation = iconToday;
                icnTomorrow.ImageLocation = iconTOMORROW;

                //Current Conditions
                lblCity.Text = wD.city;
                lblCurrentCond.Text = wD.condition;
                lblCurrentF.Text = temp + ": " + wD.temp_f.ToString() + degree;
                lblWind.Text = wD.wind_condition;

                //Day 2's Conditions
                lblDay2.Text = wD.day_of_weekDAY2;
                lblDay2Cond.Text = wD.conditionDAY2;
                lblDay2High.Text = high + ":  " + wD.highDAY2.ToString() + degree;
                lblDay2Low.Text = low + ":  " + wD.lowDAY2.ToString() + degree;

                //Day 3's Conditions
                lblDay3.Text = wD.day_of_weekDAY3;
                lblDay3Cond.Text = wD.conditionDAY3;
                lblDay3High.Text = high + ":  " + wD.highDAY3.ToString() + degree;
                lblDay3Low.Text = low + ":  " + wD.lowDAY3.ToString() + degree;

                //Today's Conditions
                lblToday.Text = wD.day_of_weekTODAY;
                lblTodayCond.Text = wD.conditionTODAY;
                lblTodayHigh.Text = high + ":  " + wD.highTODAY.ToString() + degree;
                lblTodayLow.Text = low + ":  " + wD.lowTODAY.ToString() + degree;

                //Tomorrow's Conditions
                lblTomorrow.Text = wD.day_of_weekTOMORROW;
                lblTomorrowCond.Text = wD.conditionTOMORROW;
                lblTomorrowHigh.Text = high + ":  " + wD.highTOMORROW.ToString() + degree;
                lblTomorrowLow.Text = low + ":  " + wD.lowTOMORROW.ToString() + degree;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            
        }

        private void WeatherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save Settings
            Settings.Default.defaultCity = txtCity.Text;
            Settings.Default.intervalText = comboBoxEdit1.Text;
            Settings.Default.windowPosition = this.Location;
            Settings.Default.timerOn = timer1.Enabled;
            Settings.Default.intervalTime = delay;
            Settings.Default.defaultLang = comboLang.Text;
            Settings.Default.Save();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Refresh Weather Data
            getWeather(Lang, City);
        }


        private void getDelay(string Selection)
        {
            //Set the delay based on User Selection
            if (Selection == "Never")
                delay = 1;
            if (Selection == "1 Minute")
                delay = 1;
            if (Selection == "2 Minutes")
                delay = 2;
            if (Selection == "5 Minutes")
                delay = 5;
            if (Selection == "10 Minute")
                delay = 10;
            if (Selection == "30 Minutes")
                delay = 30;
            if (Selection == "1 Hour")
                delay = 1 * 60;
            if (Selection == "2 Hours")
                delay = 2 * 60;
            if (Selection == "4 Hours")
                delay = 4 * 60;
            if (Selection == "Select AutoUpdate Interval")
                delay = 1;
            delay = (delay * 60000);
            
        }

        private void getLang(string lSelection)
        {
            if (lSelection == "English (GB)")
            {
                Lang = LanguageCode.en_GB;
                temp = "Temperature";
                high = "High";
                low = "Low";
                celsius = true;
                degree = "°C";
            }
            if (lSelection == "English (US)")
            {
                Lang = LanguageCode.en_US;
                temp = "Temperature";
                high = "High";
                low = "Low";
                celsius = false;
                degree = "°F";
            }
            if (lSelection == "Deutsch")
            {
                Lang = LanguageCode.de_DE;
                temp = "Temperatur";
                high = "Hoch";
                low = "Niedrig";
                celsius = true;
                degree = "°C";
            }
            if (lSelection == "Français")
            {
                Lang = LanguageCode.fr_FR;
                temp = "Température";
                high = "Haut";
                low = "Bas";
                celsius = true;
                degree = "°C";
            }
            if (lSelection == "日本語")
            {
                Lang = LanguageCode.ja_JP;
                temp = "温度";
                high = "高い";
                low = "低い";
                celsius = true;
                degree = "°C";
            }
            if (lSelection == "Italiano")
            {
                Lang = LanguageCode.it_IT;
                temp = "Temperatura";
                high = "Alto";
                low = "Basso";
                celsius = true;
                degree = "°C";
            }
            if (lSelection == "Русский")
            {
                Lang = LanguageCode.ru_RU;
                temp = "Температура";
                high = "Высокий";
                low = "Низко";
                celsius = true;
                degree = "°C";
            }
            if (lSelection == "")
            {
                Lang = LanguageCode.en_US;
                temp = "Temperature";
                high = "High";
                low = "Low";
                celsius = false;
                degree = "°F";
            }
            
        }

        private void comboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLang(comboLang.Text);
            getWeather(Lang, City);
        }

        }
    }

