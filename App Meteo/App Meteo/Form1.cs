using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;
using System.Globalization;


namespace App_Meteo
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Invia_Click(object sender, EventArgs e)
        {
            Rileva(this);  
        }
        private void Rileva(Form1 myform)
        {

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string datetime = DateTime.Now.ToString("HH");
                    int hour = Convert.ToInt32(datetime);

                    string lat = "45.70";
                    string lon = "9.67";
                    string dataI = DateTime.Now.ToString("yyyy-MM-dd");

                    //COORDINATE
                    string city = txt_City.Text;
                    string url = string.Format("https://geocoding-api.open-meteo.com/v1/search?name=" + city + "&count=1");

                    var json = webClient.DownloadString(url);
                    City Città = JsonConvert.DeserializeObject<City>(json);
                    if (Città.results == null) {
                        MessageBox.Show("Luogo non trovato", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                      
                        lat = Convert.ToString(Città.results[0].latitude).Replace(",", ".");
                        lon = Convert.ToString(Città.results[0].longitude).Replace(",", ".");
                    }



                    label15.Text = Città.results[0].name;





                    //RILEVAZIONI
                    DateTime tmp = Convert.ToDateTime(dataI);
                    tmp = tmp.AddDays(14);
                    string dataF = tmp.ToString("yyyy-MM-dd");
                    url = string.Format("https://api.open-meteo.com/v1/forecast?latitude=" + lat + "&longitude=" + lon + "&hourly=temperature_2m,relativehumidity_2m,apparent_temperature,cloudcover,precipitation,surface_pressure,windspeed_10m,winddirection_10m,precipitation_probability,weathercode&daily=weathercode,temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset&timezone=Europe%2FBerlin&start_date=" + dataI + "&end_date=" + dataF);
                    json = webClient.DownloadString(url);
                    Weather.root Rilevation = JsonConvert.DeserializeObject<Weather.root>(json);

                    //AIR
                    url = string.Format("https://air-quality-api.open-meteo.com/v1/air-quality?latitude=" + lat + "&longitude=" + lon + "&hourly=pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,sulphur_dioxide,ozone&start_date=" + dataI + "&end_date=" + dataI);
                    json = webClient.DownloadString(url);
                    AirQuality Air = JsonConvert.DeserializeObject<AirQuality>(json);
                    string cond = "";
               
                    switch (Rilevation.hourly.weathercode[hour])
                {
                    case 0:
                        cond = "Sereno";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Sereno.jpg");
                        break;
                    case 1:
                    case 2:
                    case 3:
                        cond = "Parzialmente nuvoloso";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Parz_Nuv.jpg");
                        break;
                    case 45:
                    case 48:
                        cond = "Nebbioso";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Fog.jpg");
                        break;
                    case 51:
                    case 53:
                    case 55:
                        cond = "Pioggerella";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/pioggerella.jpg");
                        break;
                    case 56:
                    case 57:
                        cond = "Pioviggine sopraffusa";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Rain.jpg");
                        break;
                    case 61:
                    case 63:
                    case 65:
                        cond = "Pioggia";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Rain.jpg");
                        break;
                    case 66:
                    case 67:
                        cond = "Pioggia sopraffusa";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Rain.jpg");
                        break;
                    case 71:
                    case 73:
                    case 75:
                        cond = "Neve";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Snow.jpg");

                        break;
                    case 77:
                        cond = "Nevischio";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/nevischio.jpg");

                        break;
                    case 80:
                    case 81:
                    case 82:
                        cond = "Acquazzone";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/acquazzone.jpg");

                        break;
                    case 85:
                    case 86:
                        cond = "Bufera di neve";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/acquazzone.jpg");

                        break;
                    case 95:
                    case 96:
                    case 99:
                        cond = "Temporale";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/acquazzone.jpg");

                        break;
                }
              




                    myform.lbl_TempAttuale.Text = Convert.ToString(Rilevation.hourly.temperature_2m[hour] + "°C");
                    myform.lbl_minmax.Text = Convert.ToString(cond + " " + Rilevation.daily.temperature_2m_min[0] + "°/" + Rilevation.daily.temperature_2m_max[0] + "°");

                    myform.lbl_Percepita.Text = Convert.ToString("Percepita " + Rilevation.hourly.apparent_temperature[hour] + "°C");
                    myform.lbl_precipitazioni.Text = Convert.ToString("Precipitazioni " + Rilevation.hourly.precipitation[hour] + " mm");
                    string alba = Convert.ToString(Rilevation.daily.sunrise[0]);

                    string tramonto = Convert.ToString(Rilevation.daily.sunset[0]);
                    myform.lbl_Alba.Text = "Alba:               " + alba.Substring(alba.Length - 5);
                    myform.lbl_tramonto.Text = "Tramonto:        " + tramonto.Substring(tramonto.Length - 5);
                    myform.lbl_Ivento.Text = Convert.ToString("Vento "+Rilevation.hourly.windspeed_10m[hour] + " Km/h     "+ Rilevation.hourly.winddirection_10m[hour] +"°");
                    myform.lbl_Pressione.Text = Convert.ToString("Pressione " + Rilevation.hourly.surface_pressure[hour] + " mBar");
                    myform.lbl_Umidita.Text = Convert.ToString("Umidità " + Rilevation.hourly.relativehumidity_2m[hour] + "%");
                    myform.lbl_ProPrecipita.Text = Convert.ToString("Probabilità di pioggia " + Rilevation.hourly.precipitation_probability[hour] + "%");

                    myform.lbl_pm25.Text = Convert.ToString("PM2.5           " + Air.hourly.pm2_5[hour]);
                    myform.lbl_pm10.Text = Convert.ToString("PM10            " + Air.hourly.pm10[hour]);
                    myform.lbl_SO2.Text = Convert.ToString("SO2              " + Air.hourly.sulphur_dioxide[hour]);
                    myform.lbl_NO3.Text = Convert.ToString("NO2              " + Air.hourly.nitrogen_dioxide[hour]);
                    myform.lbl_Co.Text = Convert.ToString("CO                " + Air.hourly.carbon_monoxide[hour]);
                    myform.lbl_O.Text = Convert.ToString("O3                 " + Air.hourly.ozone[hour]);

                    myform.lbl_qualitàAria.Text = Convert.ToString("PM2.5 " + Air.hourly.pm2_5[hour]);
                    DateTime thisDay = DateTime.Today;
                    int day = thisDay.Day;
                    string[] dayN = new string[7];
                    for (int i = 0; i <= 6; i++)
                    {
                        DateTime dateValue = new DateTime(thisDay.Year, thisDay.Month, day + i);
                        dayN[i] = dateValue.ToString("ddd");
                    }
                    myform.label1.Text = dayN[2].ToUpper();
                    myform.label2.Text = dayN[3].ToUpper();
                    myform.lbl_Stato.Text = dayN[4].ToUpper();
                    myform.label4.Text = dayN[5].ToUpper();

                    myform.lbl_Nminmax.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[1] + "°/" + Rilevation.daily.temperature_2m_max[1] + "°");
                    myform.lbl_Nminmax2.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[2] + "°/" + Rilevation.daily.temperature_2m_max[2] + "°");
                    myform.lbl_Nminmax3.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[3] + "°/" + Rilevation.daily.temperature_2m_max[3] + "°");
                    myform.lbl_Nminmax4.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[4] + "°/" + Rilevation.daily.temperature_2m_max[4] + "°");
                    myform.lbl_Nminmax5.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[5] + "°/" + Rilevation.daily.temperature_2m_max[5] + "°");
                    myform.pictureBox2.Image = Image.FromFile("../../../Foto/Sole.png");
                    PictureBox[] p = new PictureBox[5];
                    p[0] = pictureBox2;
                    p[1] = pictureBox6;
                    p[2] = pictureBox5;
                    p[3] = pictureBox4;
                    p[4] = pictureBox3;

                    for (int i = 0; i < 5; i++)
                    {
                        switch (Rilevation.daily.weathercode[i])
                        {
                            case 0:
                                p[i].Image = Image.FromFile("../../../Foto/Sole.png");
                                break;
                            case 1:
                            case 2:
                            case 3:
                                p[i].Image = Image.FromFile("../../../Foto/parz_nuv.png");
                                break;
                            case 45:
                            case 48:
                                p[i].Image = Image.FromFile("../../../Foto/Nuv.png");
                                break;
                            case 51:
                            case 53:
                            case 55:
                                p[i].Image = Image.FromFile("../../../Foto/pioggerella.png");
                                break;
                            case 56:
                            case 57:
                                p[i].Image = Image.FromFile("../../../Foto/pioggia.png");
                                break;
                            case 61:
                            case 63:
                            case 65:
                                p[i].Image = Image.FromFile("../../../Foto/pioggia.png");
                                break;
                            case 66:
                            case 67:
                                p[i].Image = Image.FromFile("../../../Foto/pioggia.png");
                                break;
                            case 71:
                            case 73:
                            case 75:
                                p[i].Image = Image.FromFile("../../../Foto/neve.png");

                                break;
                            case 77:

                                p[i].Image = Image.FromFile("../../../Foto/neve.png");

                                break;
                            case 80:
                            case 81:
                            case 82:
                                p[i].Image = Image.FromFile("../../../Foto/Temp.png");

                                break;
                            case 85:
                            case 86:
                                p[i].Image = Image.FromFile("../../../Foto/NeveF.png");

                                break;
                            case 95:
                            case 96:
                            case 99:
                                p[i].Image = Image.FromFile("../../../Foto/Temp.png");
                                break;
                        }
                    }

                    PictureBox[] p1 = new PictureBox[5];
                    p1[0] = pictureBox7;
                    p1[1] = pictureBox10;
                    p1[2] = pictureBox9;
                    p1[3] = pictureBox8;
                    p1[4] = pictureBox11;
                    int j = hour;
                    for (int i = 0; i < p1.Length; i++)
                    {
                        switch (Rilevation.hourly.weathercode[j])
                        {
                            case 0:
                                p1[i].Image = Image.FromFile("../../../Foto/Sole.png");
                                break;
                            case 1:
                            case 2:
                            case 3:
                                p1[i].Image = Image.FromFile("../../../Foto/parz_nuv.png");
                                break;
                            case 45:
                            case 48:
                                p1[i].Image = Image.FromFile("../../../Foto/Nuv.png");
                                break;
                            case 51:
                            case 53:
                            case 55:
                                p1[i].Image = Image.FromFile("../../../Foto/pioggerella.png");
                                break;
                            case 56:
                            case 57:
                                p1[i].Image = Image.FromFile("../../../Foto/pioggia.png");
                                break;
                            case 61:
                            case 63:
                            case 65:
                                p1[i].Image = Image.FromFile("../../../Foto/pioggia.png");
                                break;
                            case 66:
                            case 67:
                                p1[i].Image = Image.FromFile("../../../Foto/pioggia.png");
                                break;
                            case 71:
                            case 73:
                            case 75:
                                p1[i].Image = Image.FromFile("../../../Foto/neve.png");

                                break;
                            case 77:

                                p1[i].Image = Image.FromFile("../../../Foto/neve.png");

                                break;
                            case 80:
                            case 81:
                            case 82:
                                p1[i].Image = Image.FromFile("../../../Foto/Temp.png");

                                break;
                            case 85:
                            case 86:
                                p1[i].Image = Image.FromFile("../../../Foto/NeveF.png");

                                break;
                            case 95:
                            case 96:
                            case 99:
                                p1[i].Image = Image.FromFile("../../../Foto/Temp.png");
                                break;
                        }
                        j = j + 3;
                    }
                    myform.label3.Text = Convert.ToString(Rilevation.hourly.temperature_2m[hour + 3] + "°C");
                    myform.label7.Text = Convert.ToString(Rilevation.hourly.temperature_2m[hour + 6] + "°C");
                    myform.label6.Text = Convert.ToString(Rilevation.hourly.temperature_2m[hour + 9] + "°C");
                    myform.label5.Text = Convert.ToString(Rilevation.hourly.temperature_2m[hour + 12] + "°C");
                    myform.label13.Text = Convert.ToString(Rilevation.hourly.temperature_2m[hour + 15] + "°C");

                    myform.label11.Text = Convert.ToString((Convert.ToInt32(datetime) + 3) % 24 + ":00");
                    myform.label8.Text = Convert.ToString((Convert.ToInt32(datetime) + 6) % 24 + ":00");
                    myform.label9.Text = Convert.ToString((Convert.ToInt32(datetime) + 9) % 24 + ":00");
                    myform.label10.Text = Convert.ToString((Convert.ToInt32(datetime) + 12) % 24 + ":00");
                    myform.label12.Text = Convert.ToString((Convert.ToInt32(datetime) + 15) % 24 + ":00");
                }
                catch
                {
                    MessageBox.Show("Luogo non trovato");
                }
            }



        }

        private void lbl_minmax_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rileva(this);
            pictureBox12.Image= Image.FromFile("../../../Foto/lente.png");

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}






public class AirQuality
{
    public float latitude { get; set; }
    public float longitude { get; set; }
    public float generationtime_ms { get; set; }
    public int utc_offset_seconds { get; set; }
    public string timezone { get; set; }
    public string timezone_abbreviation { get; set; }
    public Hourly_Units hourly_units { get; set; }
    public Hourly hourly { get; set; }
}
public class Hourly_Units
{
    public string time { get; set; }
    public string pm10 { get; set; }
    public string pm2_5 { get; set; }
    public string carbon_monoxide { get; set; }
    public string nitrogen_dioxide { get; set; }
    public string sulphur_dioxide { get; set; }
    public string ozone { get; set; }
}
public class Hourly
{
    public string[] time { get; set; }
    public float[] pm10 { get; set; }
    public float[] pm2_5 { get; set; }
    public float[] carbon_monoxide { get; set; }
    public float[] nitrogen_dioxide { get; set; }
    public float[] sulphur_dioxide { get; set; }
    public float[] ozone { get; set; }
}



public class City
{
    public Result[] results { get; set; }
    public float generationtime_ms { get; set; }
}
public class Result
{
    public int id { get; set; }
    public string name { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
    public float elevation { get; set; }
    public string feature_code { get; set; }
    public string country_code { get; set; }
    public int admin1_id { get; set; }
    public int admin3_id { get; set; }
    public int admin4_id { get; set; }
    public string timezone { get; set; }
    public int population { get; set; }
    public string[] postcodes { get; set; }
    public int country_id { get; set; }
    public string country { get; set; }
    public string admin1 { get; set; }
    public string admin3 { get; set; }
    public string admin4 { get; set; }
}


public class Weather
{
    public class gen
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public float utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
    }
    public class hourly_units
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
        public string relativehumidity_2m { get; set; }
        public string apparent_temperature { get; set; }
        public string cloudcover { get; set; }
        public string precipitation { get; set; }
        public string surface_pressure { get; set; }
        public string windspeed_10m { get; set; }
        public string winddirection_10m { get; set; }
        public string precipitation_probability { get; set; }
        public string weathercode { get; set; }

    }
    public class hourly
    {
        public List<string> time { get; set; }
        public List<float> temperature_2m { get; set; }
        public List<int> relativehumidity_2m { get; set; }
        public List<float> apparent_temperature { get; set; }
        public List<int> cloudcover { get; set; }
        public List<float> precipitation { get; set; }
        public List<float> surface_pressure { get; set; }
        public List<float> windspeed_10m { get; set; }
        public List<int> winddirection_10m { get; set; }
        public List<string> precipitation_probability { get; set; }
        public List<int> weathercode { get; set; }
    }

    public class daily_units
    {
        public string time { get; set; }
        public string temperature_2m_max { get; set; }
        public string temperature_2m_min { get; set; }
        public string apparent_temperature_max { get; set; }
        public string apparent_temperature_min { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string weathercode { get; set; }

    }

    public class daily
    {
        public List<string> time { get; set; }
        public List<float> temperature_2m_max { get; set; }
        public List<float> temperature_2m_min { get; set; }
        public List<float> apparent_temperature_max { get; set; }
        public List<float> apparent_temperature_min { get; set; }
        public List<string> sunrise { get; set; }
        public List<string> sunset { get; set; }
        public List<int> weathercode { get; set; }


    }

    public class root
    {
        public gen gen { get; set; }
        public hourly hourly { get; set; }
        public hourly_units Hourly_units { get; set; }
        public daily_units daily_Units { get; set; }
        public daily daily { get; set; }

    }
}

