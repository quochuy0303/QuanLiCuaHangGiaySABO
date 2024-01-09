using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public static class LanguageManager
    {
        private static ResourceManager resourceManager;
        private static CultureInfo currentCulture;

        public static void Initialize(CultureInfo culture)
        {
            currentCulture = culture;
            resourceManager = new ResourceManager("QuanLiCuaHangGiaySABO.Properties.Resources", typeof(LanguageManager).Assembly);
        }

        public static string GetString(string key)
        {
            return resourceManager.GetString(key, currentCulture);
        }

        public static string GetCurrentCultureName()
        {
            return currentCulture.Name;
        }
    }
}

