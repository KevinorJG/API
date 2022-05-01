using AppCore.IServices;
using AppCore.Services;
using Autofac;
using OpenWaether.Domain.Interfaces;
using OpenWeather.Domain.Entities;
using OpenWeather.Infraestructure.Repository;
using System;
using System.Windows.Forms;

namespace OpenWeather.Presentation.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ContainerBuilder();
            builder.RegisterType<ApiGetRepository>().As<IModel<City.Root>>();
            builder.RegisterType<CityServices>().As<IServices<City.Root>>();
        
            builder.RegisterType<ApiGetRepository>().As<IWeatherModel<Weather.Root>>();
            builder.RegisterType<WeatherServices>().As<IWeatherServices<Weather.Root>>();
           
            var container = builder.Build();
         
            Application.Run(new Form1(container.Resolve<IServices<City.Root>>(), container.Resolve<IWeatherServices<Weather.Root>>()));
        }
    }
}
