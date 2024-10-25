using System.Globalization;
using System.Resources;
using System.Threading;
using Labirint_Kova.Properties;

namespace Labirint_Kova.Logic
{
    using System.Globalization;
    using System.Resources;
    using System.Threading;

    public static class LanguageManager
    {
        private static ResourceManager resourceManager;

        static LanguageManager()
        {
            SetLanguage("ru");
        }

        public static void SetLanguage(string language)
        {
            if (language == "ru")
            {
                resourceManager = new ResourceManager($"Labirint_Kova.Properties.Resources", typeof(Resources).Assembly);
            }
            else
            {
                resourceManager = new ResourceManager($"Labirint_Kova.Properties.Resources{language}", typeof(Resources).Assembly);
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }

        public static string GetText(string key) => resourceManager.GetString(key);
    }

}
