using Labirint_Kova.Logic;
using Labirint_Kova.Models;
using Labirint_Kova.Models.Player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint_Kova.Forms
{
    public partial class MazeForm : Form
    {
        private readonly GenerateMaze mazeGenerator;
        private readonly PlayerController playerController;
        private readonly Player player;

        private readonly int[,] maze;
        private int[,] visibleArea;

        private List<MazeBlocks> mazeBlocks;
        public MazeForm()
        {
            InitializeComponent();

            DoubleBuffered = true;

            mazeGenerator = new GenerateMaze();
            mazeGenerator.GenerateNumerMaze();
            maze = mazeGenerator.GetMaze();

            player = new Player(1, maze.GetLength(1) - 1);
            playerController = new PlayerController(player, maze);
            visibleArea = player.GetVisibleArea(maze);

            InitializeBlocks();
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

            mazeBlocks = MazeBuilder.CreateMazeBlocks(centerX, centerY, blockSize, formWidth, visibleArea);
        }

        private void MazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            int dx = 0, dy = 0;

            switch (e.KeyCode)
            {
                case Keys.W:
                    dy = -1;
                    break;
                case Keys.S:
                    dy = 1;
                    break;
                case Keys.A:
                    dx = -1;
                    break;
                case Keys.D:
                    dx = 1;
                    break;
                default:
                    return;
            }

            playerController.Move(dx, dy);
            visibleArea = player.GetVisibleArea(maze);
            MazeBlocksVisibility.UpdateMazeBlocksVisibility(mazeBlocks, visibleArea);
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
                    if (block.IsVisible)
                    {
                        e.Graphics.FillPolygon(brush, block.Points);
                    }
                }
            }
        }
    }
}
