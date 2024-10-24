using System;
using System.Drawing;

namespace Labirint_Kova.Models.Blocks
{
    public class StaticSection : MazeBlocks
    {
        public StaticSection(int centerX, int centerY, int blockSize, int clientWidth, Color color, int type)
            : base(GetPoints(centerX, centerY, blockSize, clientWidth, type), color)
        {
        }

        private static Point[] GetPoints(int centerX, int centerY, int blockSize, int clientWidth, int type)
        {
            switch (type)
            {
                case 1:
                    return new Point[]
                    {
                    new Point(centerX, centerY),
                    new Point(centerX + blockSize, centerY),
                    new Point(centerX + blockSize, centerY + blockSize),
                    new Point(centerX, centerY + blockSize)
                    };
                case 2:
                    return new Point[]
                    {
                    new Point(centerX + blockSize, centerY),
                    new Point(centerX + blockSize * 2, centerY),
                    new Point(centerX + blockSize * 2, centerY + blockSize),
                    new Point(centerX + blockSize, centerY + blockSize)
                    };
                case 3:
                    return new Point[]
                    {
                    new Point(centerX, centerY),
                    new Point(centerX - blockSize, centerY),
                    new Point(centerX - blockSize, centerY + blockSize),
                    new Point(centerX, centerY + blockSize)
                    };
                case 4:
                    return new Point[]
                    {
                    new Point(centerX - blockSize - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4),
                    new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4)
                    };
                case 5:
                    return new Point[]
                    {
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),
                    new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),
                    new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2)
                    };
                case 6:
                    return new Point[]
                    {
                    new Point(centerX + blockSize + blockSize / 4 * 3, centerY - blockSize / 4 * 3),
                    new Point(centerX - blockSize / 4 * 3, centerY - blockSize / 4 * 3),
                    new Point(centerX - blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),
                    new Point(centerX + blockSize + blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3)
                    };
                default:
                    throw new ArgumentException("Invalid section number");
            }
        }
    }

}
