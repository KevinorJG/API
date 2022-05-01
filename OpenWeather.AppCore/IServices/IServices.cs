using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices<T>
    {
        Task<T> GetWather();
        Task<string> GetIcon();
        public string Recibir(string city);
    }
}
