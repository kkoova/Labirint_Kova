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
        private RotatablePictureBox rotatingPictureBox;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ImageIn();
            TimerIn();
        }

        /// <summary>
        /// Настройка таймера
        /// </summary>
        private void TimerIn()
        {
            rotationTimer.Interval = 30;
            rotationTimer.Tick += RotationTimer_Tick;
            rotationTimer.Start();
        }

        /// <summary>
        /// Создание изображения
        /// </summary>
        private void ImageIn()
        {
            rotatingPictureBox = new RotatablePictureBox
            {
                Image = Properties.Resources.MazePng,
                Size = new Size(2000, 2000),
                Location = new Point(500, -100),
            };

            Controls.Add(rotatingPictureBox);
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
            var mazeForm = new MazeForm();
            mazeForm.ShowDialog();
        }

        /// <summary>
        /// Событие таймера
        /// </summary>
        private void RotationTimer_Tick(object sender, EventArgs e)
        {
            rotatingPictureBox.RotationAngle += 0.02f;
            if (rotatingPictureBox.RotationAngle >= 360f)
            {
                rotatingPictureBox.RotationAngle = 0f;
            }
        }
    }
}
