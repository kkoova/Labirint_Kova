using System;
using System.Drawing;

namespace Labirint_Kova.Models.Blocks.VisBlocks
{
    internal class Block_2_1 : MazeBlocks
    {
        public Block_2_1(int centerX, int centerY, int blockSize, Color color, int type)
            : base(GetPoints(centerX, centerY, blockSize, type), color)
        {
        }

        private static Point[] GetPoints(int centerX, int centerY, int blockSize, int type)
        {
            switch (type)
            {
                case 1:
                    return new Point[]
                    {
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX - blockSize - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX - blockSize - blockSize / 4, centerY + blockSize + blockSize / 4),
                    new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4)
                    };
                case 2:
                    return new Point[]
                    {
                    new Point(centerX, centerY),
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4),
                    new Point(centerX, centerY + blockSize)
                    };
                default:
                    throw new ArgumentException("Invalid section number");
            }
        }
    }
}
