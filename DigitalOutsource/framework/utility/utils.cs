using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOutsource.framework.utility
{
   public  class utils
    {
        public static string GetAppConfigValue(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;

            var s = appSettings[key];
            return appSettings[key];
        }

        public static string ProjectRoot()
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Replace(@"\bin\Debug", "");
            return path;

        }
        public static void CreateDir(string dir)
        {

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public static string Get_Basefolder()
        {
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            return dir;
        }
    }
}
