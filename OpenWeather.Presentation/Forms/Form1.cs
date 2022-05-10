using AppCore.IServices;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;
using OpenWeather.Domain.Entities;

namespace OpenWeather.Presentation.Forms
{
    public partial class Form1 : Form
    {
        
        private IServices<City.Root> services;
        private IWeatherServices<Weather.Root> weatherServices;

        public Form1(IServices<City.Root> services, IWeatherServices<Weather.Root> weatherServices)
        {
            this.weatherServices = weatherServices;
            this.services = services;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Obtiene el nombre del pais local
            RegionInfo Country = new RegionInfo("NI");
            services.Recibir(Country.DisplayName);

            //llama a los servicios para efectuar la consulta
            var root = services.GetWeather();
            var getIcon = services.GetIcon();
            var getForecast = weatherServices.GetForecast();
            REST(root, getIcon,getForecast);         

        }

        public void REST(Task<City.Root> root, Task<string> getIcon, Task<Weather.Root> getForecast)
        {
            //Se espera ah que todas las tareas finalicen
            Task.WaitAll(root, getIcon,getForecast);
            //Se insertan los texto a mostrar en la interfaz
            pictureBox1.ImageLocation = getIcon.Result;
            labelCondicion.Text = root.Result.weather[0].main;
            labelDetalles.Text = root.Result.weather[0].description;
            labelViento.Text = root.Result.wind.speed + " m/s";
            labelPresion.Text = getForecast.Result.hourly[0].pressure + "hPa";
            labelTem.Text = ((int)(double.Parse(root.Result.main.temp) - 273.15)).ToString() + "°C";
            labelCiudad.Text = root.Result.name + " / " + root.Result.sys.country;
            labelLatitud.Text = getForecast.Result.lat; ;
            labelLongitud.Text = getForecast.Result.lon;
            //convierte una dato UNIT a un dato en fecha
            dynamic dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(double.Parse(getForecast.Result.hourly[0].dt)).ToLocalTime();
            labelDt.Text = $"{dt}";

        }
        private void CityTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    services.Recibir(CityTexBox.Text);
                    Task<City.Root> clima = services.GetWeather();
                    Task<string> icon = services.GetIcon();             
                    var foreCast= weatherServices.GetForecast();

                    if (clima.IsFaulted)
                    {
                        MessageBox.Show("Pais no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        REST(clima, icon, foreCast);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
