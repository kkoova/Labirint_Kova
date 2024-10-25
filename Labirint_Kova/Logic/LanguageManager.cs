using System.Globalization;
using System.Resources;
using System.Threading;
using Labirint_Kova.Properties;

namespace Labirint_Kova.Logic
{
    public static class LanguageManager
    {
        public static ResourceManager ResourceManager { get; private set; } = Resources.ResourceManager;

        public static void SetLanguage(string language)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            ResourceManager = new ResourceManager($"YourNamespace.Resources.{language}", typeof(Resources).Assembly);
        }

        public static string GetText(string key) => ResourceManager.GetString(key);
    }
}
