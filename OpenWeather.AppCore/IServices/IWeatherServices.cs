﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IWeatherServices<T>
    {
        Task<T> GetForecast();
        
    }
}
