using System;
using System.Drawing;

namespace Labirint_Kova.Models.Blocks.VisBlocks
{
    internal class Block_3_3 : MazeBlocks
    {
        public Block_3_3(int centerX, int centerY, int blockSize, int clientWidth, Color color, int type)
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
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),
                    new Point(clientWidth + 20, centerY - blockSize / 4 * 2),
                    new Point(clientWidth + 20, centerY + blockSize + blockSize / 4 * 2),
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2)
                    };
                case 2:
                    return new Point[]
                   {
                    new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),
                    new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4)
                   };
                default:
                    throw new ArgumentException("Invalid section number");
            }
        }
    }
}
