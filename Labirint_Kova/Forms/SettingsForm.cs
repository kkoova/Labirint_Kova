using System.Windows.Forms;
using Labirint_Kova.Logic;

namespace Labirint_Kova.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeText();
        }
        public void InitializeText()
        {
            label1.Text = LanguageManager.GetText("GameName");
            SettBtn.Text = LanguageManager.GetText("SettingsTxt");
            label2.Text = LanguageManager.GetText("LanguageSett");
        }

        private void ExitBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedLanguage = languageComboBox.SelectedItem.ToString();
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
