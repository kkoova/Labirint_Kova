using System.Drawing;
using System.Windows.Forms;
using Labirint_Kova.Logic;

namespace Labirint_Kova.Models.Player
{
    /// <summary>
    /// Контролер игрока
    /// </summary>
    public class PlayerController
    {
        private readonly Player player;
        private readonly string textEndTrue = LanguageManager.GetText("EndGameTrue");
        private readonly int[,] maze;

        /// <summary>
        /// Контролер
        /// </summary>
        /// <param name="player">Игрок</param>
        /// <param name="maze">Лабиринт</param>
        public PlayerController(Player player, int[,] maze)
        {
            this.player = player;
            this.maze = maze;
        }

        /// <summary>
        /// Движение в зависимостьи от направление камеры (Вперед)
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveForward(Direction direction)
        {
            int dx = 0, dy = 0;

            switch (direction)
            {
                case Direction.Forward:
                    dy = -1;
                    break;
                case Direction.Right:
                    dx = 1;
                    break;
                case Direction.Backward:
                    dy = 1;
                    break;
                case Direction.Left:
                    dx = -1;
                    break;
            }

            TryMove(dx, dy);
        }

        /// <summary>
        /// Движение в зависимостьи от направление камеры (Назад)
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveBackward(Direction direction)
        {
            int dx = 0, dy = 0;

            switch (direction)
            {
                case Direction.Forward:
                    dy = 1;
                    break;
                case Direction.Right:
                    dx = -1;
                    break;
                case Direction.Backward:
                    dy = -1;
                    break;
                case Direction.Left:
                    dx = 1;
                    break;
            }

            TryMove(dx, dy);
        }

        /// <summary>
        /// Движение в зависимостьи от направление камеры (Вперед)
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveLeft(Direction direction)
        {
            int dx = 0, dy = 0;

            switch (direction)
            {
                case Direction.Forward:
                    dx = -1;
                    break;
                case Direction.Right:
                    dy = -1;
                    break;
                case Direction.Backward:
                    dx = 1;
                    break;
                case Direction.Left:
                    dy = 1;
                    break;
            }

            TryMove(dx, dy);
        }

        /// <summary>
        /// Движение в зависимостьи от направление камеры (Вперед)
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveRight(Direction direction)
        {
            int dx = 0, dy = 0;

            switch (direction)
            {
                case Direction.Forward:
                    dx = 1;
                    break;
                case Direction.Right:
                    dy = 1;
                    break;
                case Direction.Backward:
                    dx = -1;
                    break;
                case Direction.Left:
                    dy = -1;
                    break;
            }

            TryMove(dx, dy);
        }

        /// <summary>
        /// Попытка движения игрока
        /// </summary>
        /// <param name="dx">Движение X</param>
        /// <param name="dy">Движение Y</param>
        private void TryMove(int dx, int dy)
        {
            var newX = player.X + dx;
            var newY = player.Y + dy;

            if (IsValidMove(newX, newY))
            {
                player.X = newX;
                player.Y = newY;

                End();
            }
        }

        /// <summary>
        /// Выход из лабиринта
        /// </summary>
        private void End()
        {
            var endPosition = new Point(maze.GetLength(0) - 2, 1);

            if (player.X == endPosition.X && player.Y == endPosition.Y)
            {
                MessageBox.Show(textEndTrue);
                Application.Exit();
            }
        }

        /// <summary>
        /// Проверка на возможность ходьбы игрока
        /// </summary>
        /// <param name="x">Позиция X</param>
        /// <param name="y">Позиция Y</param>
        /// <returns></returns>
        private bool IsValidMove(int x, int y)
        {
            return x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1) && maze[x, y] == 0;
        }
    }
}
