using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_Kova.Models
{
    internal class PerspectiveBlock : MazeBlock
    {
        public enum PerspectiveDirection
        {
            Up,
            Down,
            Left,
            Right
        }

        public PerspectiveBlock(int x, int y, int width, int height, float scale, Color color, PerspectiveDirection direction)
            : base(color)
        {
            switch (direction)
            {
                case PerspectiveDirection.Up:
                    Points = new Point[]
                    {
                    new Point(x - (int)(width / 2 * scale), y + height / 2),
                    new Point(x + (int)(width / 2 * scale), y + height / 2),
                    new Point(x + width / 2, y - height / 2),
                    new Point(x - width / 2, y - height / 2),
                    };
                    break;

                case PerspectiveDirection.Down:
                    Points = new Point[]
                    {
                    new Point(x - width / 2, y - height / 2),
                    new Point(x + width / 2, y - height / 2),
                    new Point(x + (int)(width / 2 * scale), y + height / 2),
                    new Point(x - (int)(width / 2 * scale), y + height / 2),
                    };
                    break;

                case PerspectiveDirection.Left:
                    Points = new Point[]
                    {
                    new Point(x - width / 2, y - (int)(height / 2 * scale)),
                    new Point(x + width / 2, y - height / 2),
                    new Point(x + width / 2, y + height / 2),
                    new Point(x - width / 2, y + (int)(height / 2 * scale)),
                    };
                    break;

                case PerspectiveDirection.Right:
                    Points = new Point[]
                    {
                    new Point(x - width / 2, y - height / 2),
                    new Point(x + width / 2, y - (int)(height / 2 * scale)),
                    new Point(x + width / 2, y + (int)(height / 2 * scale)),
                    new Point(x - width / 2, y + height / 2),
                    };
                    break;
            }
        }
    }
}
