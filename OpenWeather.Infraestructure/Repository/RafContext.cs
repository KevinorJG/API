using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using OpenWeather.Domain.Entities;
using Common;

namespace OpenWeather.Infraestructure.Repository
{
    public static class RafContext
    {
          
        public static void CreateJson(Weather.Root objeto )
        {
            try
            {
                string path = Path.GetFullPath("Weather.json").Replace(@AppSettings.PathDefault, string.Empty) + @AppSettings.DirectoryJson;
                string json = JsonConvert.SerializeObject(objeto);
                using (StreamWriter write = new StreamWriter(path))
                {
                    write.Write(json);
                }
            }
            catch (IOException)
            {

                throw new NullReferenceException("Error al guardar");
            }
            
        }
    }

   
}
