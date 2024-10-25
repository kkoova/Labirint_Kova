using System.Globalization;
using System.Resources;
using System.Threading;
using Labirint_Kova.Properties;

namespace Labirint_Kova.Logic
{
    /// <summary>
    /// Настройка языка приложения
    /// </summary>
    public static class LanguageManager
    {
        private static ResourceManager resourceManager;

        /// <summary>
        /// Установка изначального языка = Русский
        /// </summary>
        static LanguageManager()
        {
            SetLanguage("ru");
        }

        /// <summary>
        /// Уставновка нового языка
        /// </summary>
        /// <param name="language">Язык</param>
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
