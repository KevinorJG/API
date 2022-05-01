using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;


namespace Common
{
    public class AppSettings
    {
        public static string ApiUrl { get => ConfigurationManager.AppSettings.Get("ApiUrl"); }
        public static string Token { get => ConfigurationManager.AppSettings.Get("Token"); }
        public static string ApiIcons { get => ConfigurationManager.AppSettings.Get("ApiIcons"); }
        public static string ApiUrlOneCall { get => ConfigurationManager.AppSettings.Get("ApiUrlOneCall"); }

        public static string PathDefault { get => ConfigurationManager.AppSettings.Get("PathDefault");}
        public static string DirectoryJson { get => ConfigurationManager.AppSettings.Get("DirectoryJson"); }
     

    }
}
