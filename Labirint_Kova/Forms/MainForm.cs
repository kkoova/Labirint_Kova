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
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выход из приложение по нажатию кнопки
        /// </summary>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
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
        /// Создание новой формы
        /// </summary>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            BackPi.Visible = true;
            var mazeForm = new MazeForm();
            mazeForm.ShowDialog();
        }

        private void SettBtn_Click(object sender, EventArgs e)
        {
            BackPi.Visible = true;
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackPi.Visible = false;
        }

        private void BackPi_ControlAdded(object sender, ControlEventArgs e)
        {
            BackPi.Visible = false;
        }
    }
}
