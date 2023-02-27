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
            using(WebClient webClient = new WebClient())
            {
                string lat = "45.70";
                string lon = "9.67";
                string dataI = DateTime.Now.ToString("yyyy-MM-dd");
                //fare chiamate per qualità aria
                //add probabilità preciitazioni
                //https://open-meteo.com/en/docs/geocoding-api#geocoding_form
                //https://open-meteo.com/en/docs/air-quality-api#api_form
                DateTime tmp =Convert.ToDateTime(dataI);

                tmp = tmp.AddDays(14);
                string dataF = tmp.ToString("yyyy-MM-dd");
                string url = string.Format("https://api.open-meteo.com/v1/forecast?latitude="+lat+"&longitude="+lon+"&hourly=temperature_2m,relativehumidity_2m,apparent_temperature,precipitation,surface_pressure,cloudcover,windspeed_10m,winddirection_10m&daily=temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset&timezone=Europe%2FBerlin&start_date="+dataI+"&end_date="+dataF);
                var json =webClient.DownloadString(url);
                Weather.root Rilevation=JsonConvert.DeserializeObject<Weather.root>(json);
                string datetime = DateTime.Now.ToString("HH");
                int hour = Convert.ToInt32(datetime);
                myform.lbl_TempAttuale.Text = Convert.ToString(Rilevation.hourly.temperature_2m[hour]+"°C");
                myform.lbl_minmax.Text = Convert.ToString(Rilevation.daily.temperature_2m_min[0]+"°/"+ Rilevation.daily.temperature_2m_max[0]+"°");
                myform.lbl_Percepita.Text = Convert.ToString(Rilevation.hourly.apparent_temperature[hour] + "°C");
                myform.lbl_precipitazioni.Text = Convert.ToString(Rilevation.hourly.precipitation[hour]+" mm");
                string alba= Convert.ToString(Rilevation.daily.sunrise[0]);
                myform.lbl_Alba.Text = alba.Substring(alba.Length - 5);
                string tramonto = Convert.ToString(Rilevation.daily.sunset[0]);
                myform.lbl_tramonto.Text = tramonto.Substring(tramonto.Length-5);
                myform.lbl_Ivento.Text = Convert.ToString(Rilevation.hourly.windspeed_10m[hour]+" Km/h");
                myform.lbl_Pressione.Text = Convert.ToString(Rilevation.hourly.surface_pressure[hour]* 0.000987);
                myform.lbl_Umidita.Text = Convert.ToString(Rilevation.hourly.relativehumidity_2m[hour]+"%");
            }   
        }
    }
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
        public string precipitation { get; set; }
        public string surface_pressure { get; set; }
        public string cloudcover { get; set; }
        public string windspeed_10m { get; set; }
        public string winddirection_10m { get; set; }

    }
    public class hourly
    {
        public List<string> time { get; set; }
        public List<float> temperature_2m { get; set; }
        public List<int> relativehumidity_2m { get; set; }
        public List<float> apparent_temperature { get; set; }
        public List<float> precipitation { get; set; }
        public List<float> surface_pressure { get; set; }
        public List<int> cloudcover { get; set; }
        public List<float> windspeed_10m { get; set; }
        public List<int> winddirection_10m { get; set; }
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
        public daily_units  daily_Units  {get; set;}
        public daily daily { get; set; }
    
    }
}

