using Labirint_Kova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_Kova.Forms
{
    public partial class MazeForm : Form
    {
        private MazeBlock[] blocks;
        public MazeForm()
        {
            InitializeComponent();

            DoubleBuffered = true;
            Paint += new PaintEventHandler(DrawMaze3D);

            InitializeBlocks();

        }

        /// <summary>
        /// Инициализация блоков
        /// </summary>
        private void InitializeBlocks()
        {
            int formWidth = (ClientSize.Width - 450) / 2;
            int formHeight = (ClientSize.Height - 450) / 2;

            blocks = new MazeBlock[]
                {
                new StaticBlock(0, formHeight + 450, ClientSize.Width, 112, Color.Green),
                new StaticBlock(0, formHeight + 562, ClientSize.Width, 112, Color.Yellow),
                new StaticBlock(0, formHeight + 674, ClientSize.Width, 112, Color.Red),

                new StaticBlock(0, formHeight - 112, ClientSize.Width, 112, Color.Green),
                new StaticBlock(0, formHeight - 224, ClientSize.Width, 112, Color.Yellow),
                new StaticBlock(0, formHeight - 336, ClientSize.Width, 112, Color.Red),

                new PerspectiveBlock(
                    formWidth + 550, 
                    formHeight + 225, 
                    200, 450, 1.5f, 
                    Color.Red, 
                    PerspectiveBlock.PerspectiveDirection.Right
                ),

                new PerspectiveBlock(
                    formWidth + 750,
                    formHeight + 225,
                    200, 500, 1.5f,
                    Color.Blue,
                    PerspectiveBlock.PerspectiveDirection.Right
                ),

                new PerspectiveBlock(
                    formWidth - 100,
                    formHeight + 225,
                    200, 450, 1.5f, 
                    Color.Red, 
                    PerspectiveBlock.PerspectiveDirection.Left
                ),

                new StaticBlock(formWidth, formHeight, 450, 450, Color.Green),
                };
        }

        private void DrawMaze3D(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.LightGray);

            foreach (var block in blocks)
            {
                block.Draw(g);
            }
        }

        private void MazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void MazeForm_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in Controls)
            {
                picture.BackColor = Color.Transparent;
            }
        }
    }
}
