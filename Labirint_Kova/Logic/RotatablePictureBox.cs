using System.Windows.Forms;

namespace Labirint_Kova.Logic
{
    internal class RotatablePictureBox : PictureBox
    {
        private float angle;

        public RotatablePictureBox()
        {
            DoubleBuffered = true;
        }

        public float RotationAngle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Image is null)
            {
                base.OnPaint(e);
                return;
            }

            e.Graphics.Clear(BackColor);

            e.Graphics.TranslateTransform(Width / 2.0f, Height / 2.0f);

            e.Graphics.RotateTransform(RotationAngle);

            e.Graphics.TranslateTransform(-Width / 2.0f, -Height / 2.0f);

            int offsetX = (Width - Image.Width) / 2;
            int offsetY = (Height - Image.Height) / 2;

            e.Graphics.DrawImage(Image, offsetX, offsetY);
        }
    }
}
