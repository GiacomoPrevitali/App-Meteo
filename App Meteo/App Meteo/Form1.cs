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
//using System.Net.Http.Json;
//using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;
using System.Globalization;
//using System.Device.Location;


namespace App_Meteo
{
    public partial class Form1 : Form
    {
        static HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        /*  static async Task Esegui()
          {
              client = new HttpClient();
              client.BaseAddress = new Uri("https://api.open-meteo.com");
              client.DefaultRequestHeaders.Accept.Clear();
              client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

              Weather.root Rilevation = new Weather.root();
              Rilevation = null;
              Rilevation = await GetAlbumAsync("/v1/forecast?latitude=45.70&longitude=9.67&hourly=temperature_2m");
              MessageBox.Show(Convert.ToString(Rilevation.gen.latitude));

          }

          static async Task<Weather.root> GetAlbumAsync(string path)
          {
              Weather.root Rilevation= null;
              HttpResponseMessage response = await client.GetAsync(path);
              if (response.IsSuccessStatusCode)
              {
                   //Rilevation = await JsonSerializer.DeserializeAsync<Weather.root>(await response.Content.ReadAsStreamAsync());
                  Rilevation = JsonConvert.DeserializeObject<Weather.root>(Convert.ToString(response.Content.ReadAsStreamAsync()));
              }
              return Rilevation;
              MessageBox.Show(Rilevation.hourly.time[0]);
               Weather Rilevation = null;
               HttpResponseMessage response = await client.GetAsync(path);
               if (response.IsSuccessStatusCode)
               {
                   Rilevation = await JsonSerializer.DeserializeAsync<Weather>(await response.Content.ReadAsStreamAsync());
               }
               return Rilevation;
          }*/

        private void btn_Invia_Click(object sender, EventArgs e)
        {
            Rileva(this);
            
            
        }
        private void Rileva(Form1 myform)
        {
            using (WebClient webClient = new WebClient())
            {

                string datetime = DateTime.Now.ToString("HH");
                int hour = Convert.ToInt32(datetime);

                string lat = "45.70";
                string lon = "9.67";
                string dataI = DateTime.Now.ToString("yyyy-MM-dd");
                //fare chiamate per qualità aria
                //add probabilità preciitazioni
                //https://open-meteo.com/en/docs/geocoding-api#geocoding_form
                //https://open-meteo.com/en/docs/air-quality-api#api_form

                //COORDINATE
                string city = txt_City.Text;
                string url = string.Format("https://geocoding-api.open-meteo.com/v1/search?name=" + city + "&count=1");
                var json = webClient.DownloadString(url);
                City Città = JsonConvert.DeserializeObject<City>(json);
                //MessageBox.Show(Città.results[0].feature_code);
                lat = Convert.ToString(Città.results[0].latitude).Replace(",", ".");
                lon = Convert.ToString(Città.results[0].longitude).Replace(",", ".");
                //MessageBox.Show(lat + " " + lon);


                //RILEVAZIONI
                DateTime tmp = Convert.ToDateTime(dataI);
                tmp = tmp.AddDays(14);
                string dataF = tmp.ToString("yyyy-MM-dd");
                url = string.Format("https://api.open-meteo.com/v1/forecast?latitude=" + lat + "&longitude=" + lon + "&hourly=temperature_2m,relativehumidity_2m,apparent_temperature,cloudcover,precipitation,surface_pressure,windspeed_10m,winddirection_10m,precipitation_probability,weathercode&daily=temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset&timezone=Europe%2FBerlin&start_date=" + dataI + "&end_date=" + dataF);
                json = webClient.DownloadString(url);
                Weather.root Rilevation = JsonConvert.DeserializeObject<Weather.root>(json);

                //AIR
                url = string.Format("https://air-quality-api.open-meteo.com/v1/air-quality?latitude=" + lat + "&longitude=" + lon + "&hourly=pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,sulphur_dioxide,ozone&start_date=" + dataI + "&end_date=" + dataI);
                json = webClient.DownloadString(url);
                AirQuality Air = JsonConvert.DeserializeObject<AirQuality>(json);
                string cond = "";
                // Rilevation.hourly.weathercode[hour] = 81;
                switch (Rilevation.hourly.weathercode[hour])
                {
                    case 0:
                        cond = "Sereno";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Sereno.jpg");
                        break;
                    case 1: case 2: case 3:
                        cond = "Parzialmente nuvoloso";
                        myform.BackgroundImage = Image.FromFile("../../../Foto/Sfondi/Parz_Nuv.jpg");
                        break;
                    case 45: case 48:
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
                myform.lbl_precipitazioni.Text = Convert.ToString(Rilevation.hourly.precipitation[hour] + " mm");
                string alba = Convert.ToString(Rilevation.daily.sunrise[0]);
                myform.lbl_Alba.Text = "Alba: " + alba.Substring(alba.Length - 5);
                string tramonto = Convert.ToString(Rilevation.daily.sunset[0]);
                myform.lbl_tramonto.Text = "Tramonto: " + tramonto.Substring(tramonto.Length - 5);
                myform.lbl_Ivento.Text = Convert.ToString(Rilevation.hourly.windspeed_10m[hour] + " Km/h");
                myform.lbl_Pressione.Text = Convert.ToString("Pressione " + Rilevation.hourly.surface_pressure[hour] + " mBar");
                myform.lbl_Umidita.Text = Convert.ToString("Umidità " + Rilevation.hourly.relativehumidity_2m[hour] + "%");
                myform.lbl_ProPrecipita.Text = Convert.ToString("Probabilità di pioggia " + Rilevation.hourly.precipitation_probability[hour] + "%");

                myform.lbl_pm25.Text = Convert.ToString("PM2.5 " + Air.hourly.pm2_5[hour]);

                myform.lbl_pm10.Text = Convert.ToString("PM10 " + Air.hourly.pm10[hour]);
                myform.lbl_SO2.Text = Convert.ToString("SO2 " + Air.hourly.sulphur_dioxide[hour]);
                myform.lbl_NO3.Text = Convert.ToString("NO2 " + Air.hourly.nitrogen_dioxide[hour]);
                myform.lbl_Co.Text = Convert.ToString("CO " + Air.hourly.carbon_monoxide[hour]);
                myform.lbl_O.Text = Convert.ToString("O3 " + Air.hourly.ozone[hour]);

                myform.lbl_qualitàAria.Text = Convert.ToString("PM2.5 " + Air.hourly.pm2_5[hour]);
                DateTime thisDay = DateTime.Today;
                int day = thisDay.Day;
                
                for(int i=0; i <= 5; i++)
                {
                    DateTime dateValue = new DateTime(thisDay.Year, thisDay.Month, day+i);
                   // Console.WriteLine(dateValue.ToString("ddd", new CultureInfo("fr-FR")));
                    MessageBox.Show(dateValue.ToString("ddd"));
                }

                myform.lbl_Nminmax.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[1] + "°/" + Rilevation.daily.temperature_2m_max[1] + "°");
                myform.lbl_Nminmax2.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[2] + "°/" + Rilevation.daily.temperature_2m_max[2] + "°");
                myform.lbl_Nminmax3.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[3] + "°/" + Rilevation.daily.temperature_2m_max[3] + "°");
                myform.lbl_Nminmax4.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[4] + "°/" + Rilevation.daily.temperature_2m_max[4] + "°");
                myform.lbl_Nminmax5.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[5] + "°/" + Rilevation.daily.temperature_2m_max[5] + "°");
                MessageBox.Show(Convert.ToString(Rilevation.hourly.weathercode[hour]));
            }

        }
        private Bitmap Freccia(Bitmap freccia, float angle)
        {
           
            Bitmap rotated = new Bitmap(freccia.Width, freccia.Height);
            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.TranslateTransform(rotated.Width / 2, rotated.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotated.Width / 2, -rotated.Height / 2);
                g.DrawImage(rotated, new Point(0, 0));
            }
            return rotated;
        }

        private void lbl_minmax_Click(object sender, EventArgs e)
        {

        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_Air.Visible = !Panel_Air.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rileva(this);
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

