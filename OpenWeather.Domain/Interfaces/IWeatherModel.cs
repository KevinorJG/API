using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWaether.Domain.Interfaces
{
    public interface IWeatherModel<T>
    { 
        Task<T> GetForecast();
    }
}
