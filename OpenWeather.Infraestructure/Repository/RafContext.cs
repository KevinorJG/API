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
                using (Stream write = new FileStream(path,FileMode.Create,FileAccess.Write))
                {
                    using(StreamWriter sw = new StreamWriter(write))
                    {
                        if(path.Length > 1)
                        {
                            sw.Write(String.Empty);
                            sw.WriteLine(json);
                        }                       
                    }
                }
            }
            catch (IOException)
            {

                throw new NullReferenceException("Error al guardar");
            }
            
        }
    }

   
}
