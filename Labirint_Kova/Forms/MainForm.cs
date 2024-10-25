using Labirint_Kova.Forms;
using Labirint_Kova.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint_Kova
{
    /// <summary>
    /// Начальная форма
    /// </summary>
    public partial class MainForm : Form
    {
        private string ypravlenie = LanguageManager.GetText("ypravlenie");

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeText();
        }

        /// <summary>
        /// Настройка текста по текущему языку
        /// </summary>
        public void InitializeText()
        {
            label1.Text = LanguageManager.GetText("GameName");
            StartBtn.Text = LanguageManager.GetText("StartTxt");
            SettBtn.Text = LanguageManager.GetText("SettingsTxt");
            ExitBtn.Text = LanguageManager.GetText("EndTxt");
            ypTxt.Text = LanguageManager.GetText("ypBtn");
            ypravlenie = LanguageManager.GetText("ypravlenie");
        }

        /// <summary>
        /// Выход из приложение по нажатию кнопки
        /// </summary>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обновление текста
        /// </summary>
        public void UpdateLanguage()
        {
            InitializeText();
        }

        /// <summary>
        /// Изменение цвета текста по наведению мыши
        /// </summary>
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label button)
            {
                button.ForeColor = Color.DarkOliveGreen;
            }
        }

        /// <summary>
        /// Изменение цвета текста по покиданию мыши
        /// </summary>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label button)
            {
                button.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Создание новой формы игры
        /// </summary>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var mazeForm = new MazeForm();
            mazeForm.ShowDialog();
        }

        /// <summary>
        /// Создание новой формы настроек
        /// </summary>
        private void SettBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            Show();
        }

        /// <summary>
        /// Информация об управлении
        /// </summary>
        private void ypTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ypravlenie);
        }
    }
}
