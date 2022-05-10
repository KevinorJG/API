using System.Threading.Tasks;

namespace OpenWaether.Domain.Interfaces
{
    public interface IModel<T>
    {
        Task<T> GetWeather();
        Task<string> GetIcon();
        public string Recibir(string city);

    }
}
