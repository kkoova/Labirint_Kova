using Labirint_Kova.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_Kova
{
    public partial class MainForm : Form
    {
        private RotatablePictureBox rotatingPictureBox;
        public MainForm()
        {
            InitializeComponent();
            ImageIn();
            TimerIn();
        }

        private void TimerIn()
        {
            rotationTimer.Interval = 30;
            rotationTimer.Tick += RotationTimer_Tick;
            rotationTimer.Start();
        }

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
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label button)
            {
                button.ForeColor = Color.DarkOliveGreen;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label button)
            {
                button.ForeColor = Color.Black;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

        }

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
