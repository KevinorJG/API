using AppCore.IServices;
using System.Threading.Tasks;
using OpenWeather.Domain.Entities;
using OpenWaether.Domain.Interfaces;

namespace AppCore.Services
{
    public class CityServices : IServices<City.Root>
    {
        protected IModel<City.Root> model;
       

        public CityServices(IModel<City.Root> model)
        {
            this.model = model;
           
        }

        public Task<string> GetIcon()
        {
            return model.GetIcon();
        }

        public Task<City.Root> GetWather()
        {
            return model.GetWather();
        }

        public string Recibir(string city)
        {
           return model.Recibir(city);  
        }
    }
}
