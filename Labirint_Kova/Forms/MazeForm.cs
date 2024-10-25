using Labirint_Kova.Logic;
using Labirint_Kova.Models;
using Labirint_Kova.Models.Player;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint_Kova.Forms
{
    /// <summary>
    /// Форма игры лабиринта
    /// </summary>
    public partial class MazeForm : Form
    {
        private readonly GenerateMaze mazeGenerator;
        private readonly PlayerController playerController;
        private readonly Player player;

        private readonly int[,] maze;
        private int[,] visibleArea;

        private List<MazeBlocks> mazeBlocks;

        /// <summary>
        /// Конструктор формы лабиринта.
        /// Инициализирует компоненты формы и задает начальные параметры лабиринта,
        /// игрока, блока видимости и системы управления.
        /// </summary>
        public MazeForm()
        {
            InitializeComponent();

            DoubleBuffered = true;

            mazeGenerator = new GenerateMaze();
            mazeGenerator.GenerateNumerMaze();
            maze = mazeGenerator.GetMaze();

            player = new Player(maze.GetLength(0) - 2, 1);
            playerController = new PlayerController(player, maze);
            visibleArea = player.GetVisibleArea(maze, 0);

            InitializeBlocks();
        }

        /// <summary>
        /// Инициализация блоков
        /// </summary>
        private void InitializeBlocks()
        {
            var blockSize = 250;
            var centerX = (ClientSize.Width - blockSize) / 2;
            var centerY = (ClientSize.Height - blockSize) / 2;
            var formWidth = ClientSize.Width + 40;

            mazeBlocks = MazeBuilder.CreateMazeBlocks(centerX, centerY, blockSize, formWidth, visibleArea);
        }

        /// <summary>
        /// Обработчик события нажатия клавиш.
        /// Отвечает за передвижение игрока по лабиринту в зависимости от нажатой клавиши.
        /// Проверяет возможные направления движения и обновляет видимую область лабиринта.
        /// </summary>
        private void MazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            var direction = 0;
            if (direction > 1)
            {
                direction = 0;
            }
            int dx = 0, dy = 0;

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.W:
                    dy = 1;
                    break;
                case Keys.S:
                    dy = -1;
                    break;
                case Keys.A:
                    dx = -1;
                    break;
                case Keys.D:
                    dx = 1;
                    break;
                case Keys.Q:
                    direction -= 1;
                    break;
                case Keys.E:
                    direction += 1;
                    break;
                default:
                    return;
            }

            playerController.Move(dx, dy);
            visibleArea = player.GetVisibleArea(maze, direction);
            MazeBlocksVisibility.UpdateMazeBlocksVisibility(mazeBlocks, visibleArea);
            Invalidate();
        }

        /// <summary>
        /// Обработчик события рисования формы.
        /// Отвечает за отрисовку элементов лабиринта, включая видимые блоки и игрока.
        /// Обновляет графику на экране в зависимости от текущего состояния видимости блоков.
        /// </summary>
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
