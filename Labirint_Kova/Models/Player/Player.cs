﻿namespace Labirint_Kova.Models.Player
{
    /// <summary>
    /// Игрок
    /// </summary>
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Начальная позиция игрока
        /// </summary>
        /// <param name="startX">Начальная позиция игрока X</param>
        /// <param name="startY">Начальная позиция игрока Y</param>
        public Player(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }

        /// <summary>
        /// Создание массива видимых блоков
        /// </summary>
        /// <param name="maze">Лабиринт</param>
        /// <returns>Массив видимых блоков</returns>
        public int[,] GetVisibleArea(int[,] maze)
        {
            var visibleArea = new int[4, 3];

            for (var y = 0; y < 4; y++)
            {
                for (var x = -1; x <= 1; x++)
                {
                    var checkX = X + x;
                    var checkY = Y + (3 - y);

                    if (checkX >= 0 && checkX < maze.GetLength(0) && checkY >= 0 && checkY < maze.GetLength(1))
                    {
                        visibleArea[y, x + 1] = maze[checkX, checkY];
                    }
                    else
                    {
                        visibleArea[y, x + 1] = 1;
                    }
                }
            }
            return visibleArea;
        }
    }
}
