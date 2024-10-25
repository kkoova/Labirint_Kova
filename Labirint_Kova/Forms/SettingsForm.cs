using System.Windows.Forms;
using Labirint_Kova.Logic;

namespace Labirint_Kova.Forms
{
    /// <summary>
    /// Форма настроек
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
            InitializeText();
        }

        /// <summary>
        /// Обновление текста
        /// </summary>
        public void InitializeText()
        {
            label1.Text = LanguageManager.GetText("GameName");
            SettBtn.Text = LanguageManager.GetText("SettingsTxt");
            label2.Text = LanguageManager.GetText("LanguageSett");
        }

        /// <summary>
        /// Заркытие формы
        /// </summary>
        private void ExitBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обновление языка текста
        /// </summary>
        private void languageComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedLanguage = languageComboBox.SelectedItem.ToString();
            LanguageManager.SetLanguage(selectedLanguage);

            // Обновляем текст на текущей форме
            InitializeText();

            // Обновляем язык на всех открытых формах
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainForm anotherForm)
                {
                    anotherForm.UpdateLanguage();
                }

                if (form is MazeForm anotherForm2)
                {
                    anotherForm2.UpdateLanguage();
                }
            }
        }
    }
}
