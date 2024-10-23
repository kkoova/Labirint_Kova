using System;
using System.Drawing;

namespace Labirint_Kova.Models.Blocks
{
    public class CeilingSection : MazeBlocks
    {
        public CeilingSection(int formWidth, int centerX, int centerY, int blockSize, int sectionNumber, Color color)
            : base(GetSectionPoints(formWidth, centerX, centerY, blockSize, sectionNumber), color)
        {
        }

        private static Point[] GetSectionPoints(int formWidth, int centerX, int centerY, int blockSize, int sectionNumber)
        {
            switch (sectionNumber)
            {
                case 1:
                    return new Point[]
                    {
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX + blockSize, centerY),
                    new Point(centerX, centerY)
                    };
                case 2:
                    return new Point[]
                    {
                    new Point(0, centerY - blockSize / 4 - blockSize / 4),
                    new Point(formWidth, centerY - blockSize / 4 - blockSize / 4),
                    new Point(formWidth, centerY - blockSize / 4),
                    new Point(0, centerY - blockSize / 4)
                    };
                case 3:
                    return new Point[]
                    {
                    new Point(0, centerY - blockSize / 4 - 2 * blockSize / 4),
                    new Point(formWidth, centerY - blockSize / 4 - 2 * blockSize / 4),
                    new Point(formWidth, centerY - blockSize / 4 - blockSize / 4),
                    new Point(0, centerY - blockSize / 4 - blockSize / 4)
                    };
                default:
                    throw new ArgumentException("Invalid section number");
            }
        }
    }

}
