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
        public WeatherForm()
        {
            InitializeComponent();
            //delay = 1;
            txtCity.Text = Properties.Settings.Default.defaultCity;
            string City = txtCity.Text;
            getWeather(City);
        }

        private void getW_Click(object sender, EventArgs e)
        {
            
            string City = txtCity.Text;
            Properties.Settings.Default.defaultCity = City;
            Properties.Settings.Default.Save();
            getWeather(City);
            /*            int minutes = delay;
                        int seconds = minutes * 60;
                        int milliseconds = seconds * 1000;
            
                        do 
                        {
                            getWeather(City);
                            System.Threading.Thread.Sleep(milliseconds);
                        }while(true);   
             */
        }

        private void getWeather(string City)
        {
            wD = WeatherAPI.GetWeather(LanguageCode.en_US, City);

            string baseURL = "http://www.google.com";
            string iconToday = baseURL + wD.iconTODAY;
            string icon = baseURL + wD.icon;
            string iconTOMORROW = baseURL + wD.iconTOMORROW;
            string iconDAY2 = baseURL + wD.iconDAY2;
            string iconDAY3 = baseURL + wD.iconDAY3;
            
            lblCity.Text = wD.city;
            icnCurrent.ImageLocation = icon;
            icnDay2.ImageLocation = iconDAY2;
            icnDay3.ImageLocation = iconDAY3;
            icnToday.ImageLocation = iconToday;
            icnTomorrow.ImageLocation = iconTOMORROW;

            lblCurrentCond.Text = wD.condition;
            lblCurrentF.Text = "Temperature: " + wD.temp_f.ToString() + "°F";

            lblDay2.Text = wD.day_of_weekDAY2;
            lblDay2Cond.Text = wD.conditionDAY2;
            lblDay2High.Text = "High:  " + wD.highDAY2.ToString() + "°F";
            lblDay2Low.Text = "Low:  " + wD.lowDAY2.ToString() + "°F";

            lblDay3.Text = wD.day_of_weekDAY3;
            lblDay3Cond.Text = wD.conditionDAY3;
            lblDay3High.Text = "High:  " + wD.highDAY3.ToString() + "°F";
            lblDay3Low.Text = "Low:  " + wD.lowDAY3.ToString() + "°F";

            lblToday.Text = wD.day_of_weekTODAY;
            lblTodayCond.Text = wD.conditionTODAY;
            lblTodayHigh.Text = "High:  " + wD.highTODAY.ToString() + "°F";
            lblTodayLow.Text = "Low:  " + wD.lowTODAY.ToString() + "°F";

            lblTomorrow.Text = wD.day_of_weekTOMORROW;
            lblTomorrowCond.Text = wD.conditionTOMORROW;
            lblTomorrowHigh.Text = "High:  " + wD.highTOMORROW.ToString() + "°F";
            lblTomorrowLow.Text = "Low:  " + wD.lowTOMORROW.ToString() + "°F";

            lblWind.Text = wD.wind_condition;

        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {

        }

/*        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.EditValue.ToString() == "Never")
                delay = 0;
            if (comboBoxEdit1.EditValue.ToString() == "1 Minute")
                delay = 1;
            if (comboBoxEdit1.EditValue.ToString() == "2 Minutes")
                delay = 2;
            if (comboBoxEdit1.EditValue.ToString() == "5 Minutes")
                delay = 5;
            if (comboBoxEdit1.EditValue.ToString() == "10 Minute")
                delay = 10;
            if (comboBoxEdit1.EditValue.ToString() == "30 Minutes")
                delay = 30;
            if (comboBoxEdit1.EditValue.ToString() == "1 Hour")
                delay = 1 * 60;
            if (comboBoxEdit1.EditValue.ToString() == "2 Hours")
                delay = 2 * 60;
            if (comboBoxEdit1.EditValue.ToString() == "4 Hours")
                delay = 4 * 60;
            if (comboBoxEdit1.EditValue.ToString() == "Select AutoUpdate Interval")
                delay = 1;

        }
 */
    }
}
