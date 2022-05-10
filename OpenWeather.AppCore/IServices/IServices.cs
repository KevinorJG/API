using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices<T>
    {
        Task<T> GetWeather();
        Task<string> GetIcon();
        public string Recibir(string city);
    }
}
