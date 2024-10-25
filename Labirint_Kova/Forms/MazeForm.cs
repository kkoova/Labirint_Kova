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
        private const int MiniMapSize = 5;
        private const int MiniMapCellSize = 10;

        private readonly GenerateMaze mazeGenerator;
        private readonly PlayerController playerController;
        private readonly Player player;

        private readonly int[,] maze;
        private int[,] visibleArea;

        private List<MazeBlocks> mazeBlocks;
        public Direction CurrentDirection { get; set; } = Direction.Forward;

        private string textEndFail;

        private int timeLeft;
        private const int TotalGameTime = 300;

        /// <summary>
        /// Конструктор формы лабиринта.
        /// Инициализирует компоненты формы и задает начальные параметры лабиринта,
        /// игрока, блока видимости и системы управления.
        /// </summary>
        public MazeForm()
        {
            InitializeComponent();
            InitializeText();
            DoubleBuffered = true;

            mazeGenerator = new GenerateMaze();
            mazeGenerator.GenerateNumerMaze();
            maze = mazeGenerator.GetMaze();

            player = new Player(1, maze.GetLength(1) - 2);
            playerController = new PlayerController(player, maze);
            visibleArea = player.GetVisibleArea(maze, 0);

            InitializeBlocks();

            timeLeft = TotalGameTime;
        }

        /// <summary>
        /// Настройка текста по текущему языку
        /// </summary>
        public void InitializeText()
        {
            textEndFail = LanguageManager.GetText("EndGameTxtFail");
        }

        /// <summary>
        /// Обновление языка
        /// </summary>
        public void UpdateLanguage()
        {
            InitializeText();
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
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.W:
                    playerController.MoveForward(CurrentDirection);
                    break;
                case Keys.S:
                    playerController.MoveBackward(CurrentDirection);
                    break;
                case Keys.A:
                    playerController.MoveLeft(CurrentDirection);
                    break;
                case Keys.D:
                    playerController.MoveRight(CurrentDirection);
                    break;
                case Keys.Q:
                    CurrentDirection = (Direction)(((int)CurrentDirection - 1 + 4) % 4);
                    break;
                case Keys.E:
                    CurrentDirection = (Direction)(((int)CurrentDirection + 1) % 4);
                    break;
                default:
                    return;
            }

            visibleArea = player.GetVisibleArea(maze, CurrentDirection);
            MazeBlocksVisibility.UpdateMazeBlocksVisibility(mazeBlocks, visibleArea);
            Invalidate();
        }

        /// <summary>
        /// Рисование минни - карты
        /// </summary>
        private void DrawMiniMap(Graphics g)
        {
            var endPosition = new Point(maze.GetLength(0) - 2, 1);
            var miniMapStartX = Width - MiniMapSize * MiniMapCellSize - 20;
            var miniMapStartY = 20;

            var centerX = MiniMapSize / 2;
            var centerY = MiniMapSize / 2;

            for (var y = -centerY; y <= centerY; y++)
            {
                for (var x = -centerX; x <= centerX; x++)
                {
                    var mazeX = player.X + x;
                    var mazeY = player.Y + y;

                    var drawX = miniMapStartX + (x + centerX) * MiniMapCellSize;
                    var drawY = miniMapStartY + (y + centerY) * MiniMapCellSize;

                    Color cellColor;
                    if (mazeX == player.X && mazeY == player.Y)
                    {
                        cellColor = Color.Green;
                    }
                    else if (mazeX == endPosition.X && mazeY == endPosition.Y)
                    {
                        cellColor = Color.IndianRed;
                    }
                    else if (mazeX >= 0 && mazeX < maze.GetLength(0) && mazeY >= 0 && mazeY < maze.GetLength(1))
                    {
                        cellColor = maze[mazeX, mazeY] == 1 ? Color.Black : Color.White;
                    }
                    else
                    {
                        cellColor = Color.Gray;
                    }

                    using (Brush brush = new SolidBrush(cellColor))
                    {
                        g.FillRectangle(brush, drawX, drawY, MiniMapCellSize, MiniMapCellSize);
                    }

                    g.DrawRectangle(Pens.Black, drawX, drawY, MiniMapCellSize, MiniMapCellSize);
                }
            }
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
            DrawMiniMap(e.Graphics);

            var timeText = $"{timeLeft / 60:D2}:{timeLeft % 60:D2}";
            var font = new Font("Arial", 16);
            Brush brushTime = Brushes.Black;
            e.Graphics.DrawString(timeText, font, brushTime, new Point(10, 10));
        }

        /// <summary>
        /// Тик таймера - обновление времени
        /// </summary>
        private void gameTime_Tick(object sender, System.EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                Invalidate();
            }
            else
            {
                gameTime.Stop();
                MessageBox.Show(textEndFail);
                Application.Exit();
            }
        }
    }
}
