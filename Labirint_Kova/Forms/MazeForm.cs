using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_Kova.Forms
{
    public partial class MazeForm : Form
    {
        public MazeForm()
        {
            InitializeComponent();

            Bitmap bitmap = new Bitmap("D:\\C#\\kkoova\\Labirint_Kova\\Labirint_Kova\\Resources\\block (0,3).png");
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(bitmap, 60, 10);
        }

        private void MazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
