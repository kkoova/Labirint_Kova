using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_Kova.Models.Blocks
{
    public class FloorSection : MazeBlocks
    {
        public FloorSection(int formWidth, int centerY, int blockSize, int sectionNumber, Color color)
        : base(GetSectionPoints(formWidth, centerY, blockSize, sectionNumber), color)
        {
        }

        private static Point[] GetSectionPoints(int formWidth, int centerY, int blockSize, int sectionNumber)
        {
            switch (sectionNumber)
            {
                case 1:
                    return new Point[]
                    {
                    new Point(0, centerY + blockSize),
                    new Point(formWidth, centerY + blockSize),
                    new Point(formWidth, centerY + blockSize + blockSize / 4),
                    new Point(0, centerY + blockSize + blockSize / 4)
                    };
                case 2:
                    return new Point[]
                    {
                    new Point(0, centerY + blockSize + blockSize / 4),
                    new Point(formWidth, centerY + blockSize + blockSize / 4),
                    new Point(formWidth, centerY + blockSize + blockSize / 2),
                    new Point(0, centerY + blockSize + blockSize / 2)
                    };
                case 3:
                    return new Point[]
                    {
                    new Point(0, centerY + blockSize + blockSize / 2),
                    new Point(formWidth, centerY + blockSize + blockSize / 2),
                    new Point(formWidth, centerY + blockSize + 3 * blockSize / 4),
                    new Point(0, centerY + blockSize + 3 * blockSize / 4)
                    };
                default:
                    throw new ArgumentException("Invalid section number");
            }
        }
    }
}
