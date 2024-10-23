using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_Kova.Models
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }

        public void Move(int dx, int dy, int[,] maze)
        {
            var newX = X + dx;
            var newY = Y + dy;
            if (newX >= 0 && newX < maze.GetLength(0) && newY >= 0 && newY < maze.GetLength(1) && maze[newX, newY] == 0)
            {
                X = newX;
                Y = newY;
            }
        }

        public int[,] GetVisibleArea(int[,] maze)
        {
            var visibleArea = new int[4, 3];

            for (var y = 0; y < 5; y++)
            {
                for (var x = -1; x <= 1; x++)
                {
                    var checkX = X + x;
                    var checkY = Y - y;

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
