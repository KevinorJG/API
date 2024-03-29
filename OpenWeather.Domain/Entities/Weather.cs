﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Domain.Entities
{
    public class Weather
    {
        #region Propertis
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }

            public string icon { get; set; }
        }

        public class hourly
        {
            public string dt { get; set; }
            public string pressure { get; set; }
            public string humidity { get; set; }
            public string temp_min { get; set; }
            public string temp_max { get; set; }
            public string temp { get; set; }
            public string wind_speed { get; set; }


        }

        public class Root
        {
            public List<weather> weather { get; set; }

            public List<hourly> hourly { get; set; }

            public string name { get; set; }

            public string lon { get; set; }
            public string lat { get; set; }

            public string timezone { get; set; }



        }
        #endregion
    }
}
