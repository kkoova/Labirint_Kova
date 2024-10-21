using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_Kova.Models
{
    internal class StaticBlock : MazeBlock
    {
        public StaticBlock(int x, int y, int width, int height, Color color)
        : base(color)
        {
            Points = new Point[]
            {
            new Point(x, y),
            new Point(x + width, y),
            new Point(x + width, y + height),
            new Point(x, y + height)
            };
        }
    }
}
