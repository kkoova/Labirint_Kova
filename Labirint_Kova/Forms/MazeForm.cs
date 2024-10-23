using Labirint_Kova.Logic;
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
        private readonly GenerateMaze mazeGenerator;
        private readonly Player player;
        private readonly int[,] maze;
        private List<MazeBlocks> mazeBlocks;
        public MazeForm()
        {
            InitializeComponent();

            DoubleBuffered = true;

            InitializeBlocks();

            mazeGenerator = new GenerateMaze();
            mazeGenerator.GenerateNumerMaze();
            maze = mazeGenerator.GetMaze();

            player = new Player(1, maze.GetLength(1) - 2);

        }

        /// <summary>
        /// Инициализация блоков
        /// </summary>
        private void InitializeBlocks()
        {
            var blockSize = 450;
            var centerX = (ClientSize.Width - blockSize) / 2;
            var centerY = (ClientSize.Height - blockSize) / 2;
            var formWidth = ClientSize.Width;

            mazeBlocks = MazeBuilder.CreateMazeBlocks(centerX, centerY, blockSize, formWidth);
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

        private void MazeForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (var block in mazeBlocks)
            {
                using (var brush = new SolidBrush(block.BlockColor))
                {
                    e.Graphics.FillPolygon(brush, block.Points);
                }
            }
        }
    }
}
