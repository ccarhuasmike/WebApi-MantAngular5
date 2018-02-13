using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApoMant.Utils
{
    public class ConfigurationManagerAppSettings
    {
        public static string host;

        public ConfigurationManagerAppSettings() {
            host = ConfigurationManager.AppSettings["host"];
        }
    }
}