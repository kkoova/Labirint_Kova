using System;
using System.Collections.Generic;

namespace Labirint_Kova.Logic
{
    internal class GenerateMaze
    {
        private readonly static int[,] maze = new int[11, 5];

        /// <summary>
        /// Генерация лабиринта
        /// </summary>
        public void GenerateNumerMaze()
        {
            for (var y = 0; y < maze.GetLength(1); y++)
            {
                for (var x = 0; x < maze.GetLength(0); x++)
                {
                    maze[x, y] = 1;
                }
            }

            var rand = new Random();
            var stack = new Stack<(int x, int y)>();
            int startX = 1, startY = 1;
            maze[startX, startY] = 0;
            stack.Push((startX, startY));

            (int x, int y)[] directions = { (0, -2), (0, 2), (-2, 0), (2, 0) };

            while (stack.Count > 0)
            {
                var (currentX, currentY) = stack.Peek();
                var neighbors = new List<(int x, int y)>();

                foreach (var (dx, dy) in directions)
                {
                    var nx = currentX + dx;
                    var ny = currentY + dy;

                    if (nx > 0 && nx < maze.GetLength(0) - 1 && ny > 0 && ny < maze.GetLength(1) - 1 && maze[nx, ny] == 1)
                    {
                        neighbors.Add((nx, ny));
                    }
                }

                if (neighbors.Count > 0)
                {
                    var (nextX, nextY) = neighbors[rand.Next(neighbors.Count)];
                    maze[(currentX + nextX) / 2, (currentY + nextY) / 2] = 0;
                    maze[nextX, nextY] = 0;
                    stack.Push((nextX, nextY));
                }
                else
                {
                    stack.Pop();
                }
            }
        }

        public int[,] GetMaze()
        {
            return maze;
        }
    }
}
