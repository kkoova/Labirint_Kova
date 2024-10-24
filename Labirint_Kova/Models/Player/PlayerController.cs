using System.Windows.Forms;

namespace Labirint_Kova.Models.Player
{
    /// <summary>
    /// Контролер игрока
    /// </summary>
    public class PlayerController
    {
        private readonly Player player;
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
        /// Движение игрока
        /// </summary>
        /// <param name="dx">Путь X</param>
        /// <param name="dy">Путь Y</param>
        public void Move(int dx, int dy)
        {
            var newX = player.X + dx;
            var newY = player.Y + dy;

            if (IsValidMove(newX, newY))
            {
                player.X = newX;
                player.Y = newY;
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
