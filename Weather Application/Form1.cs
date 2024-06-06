using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Weather_Application
{
    public partial class WeatherApp : Form
    {
        public WeatherApp()
        {
            InitializeComponent();

            lb_tempC.Visible = false;
            lb_tempZero.Visible = false;
            lab_temp.Visible = false;
        }
        string APIKey = "29e8e546e5ac4f413e3c9ee688325a59";

        private void btn_Search_Click(object sender, EventArgs e)
        {
            getWeather();

            lb_tempC.Visible = true;
            lb_tempZero.Visible = true;
            lab_temp.Visible = true;
        }
        void getWeather()
        {
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", tB_City.Text, APIKey);
                var json = wc.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lab_Condition.Text = Info.weather[0].main;
                lab_Details.Text = Info.weather[0].description;
                lab_Sunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                lab_Sunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                lab_WindSpeed.Text = Info.wind.speed.ToString();
                lab_Pressure.Text = Info.main.pressure.ToString();
                double tempConvert = Info.main.temp - 273.15;
                //lab_temp.Text = Info.main.temp.ToString();
                lab_temp.Text = tempConvert.ToString("F1");
            }
        }

        DateTime convertDateTime(long sec)
        {
            /*DateTime day = DateTime.Now;
            day = day.AddSeconds(sec); */

            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }
    }
}
