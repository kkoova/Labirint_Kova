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
        private float angle = 0f;
        public MainForm()
        {
            InitializeComponent();
            TimerIn();
        }

        private void TimerIn()
        {
            rotationTimer.Interval = 150;
            rotationTimer.Tick += RotationTimer_Tick;
            rotationTimer.Start();
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
            angle += 1f;
            if (angle >= 360f)
            {
                angle = 0f;
            }
            MazePngOic.Invalidate();
        }

        private void MazePngOic_Paint(object sender, PaintEventArgs e)
        {
            Image img = Properties.Resources.MazePng;

            e.Graphics.TranslateTransform((float)MazePngOic.Width / 2, (float)MazePngOic.Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.TranslateTransform(-(float)MazePngOic.Width / 2, -(float)MazePngOic.Height / 2);

            e.Graphics.DrawImage(img, new Point(0, 0));
        }
    }
}
