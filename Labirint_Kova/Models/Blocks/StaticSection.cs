using System;
using System.Drawing;

namespace Labirint_Kova.Models.Blocks
{
    /// <summary>
    /// Блоки
    /// </summary>
    public class StaticSection : MazeBlocks
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="StaticSection"/>.
        /// </summary>
        /// <param name="centerX">Положение центра блока по оси X</param>
        /// <param name="centerY">Положение центра блока по оси Y</param>
        /// <param name="blockSize">Размер блока</param>
        /// <param name="color">Цвет блока</param>
        /// <param name="type">Тип блока, определяющий его форму</param>
        public StaticSection(int centerX, int centerY, int blockSize, Color color, int type)
            : base(GetPoints(centerX, centerY, blockSize, type), color)
        {
        }

        /// <summary>
        /// Получает массив точек, определяющих форму блока в зависимости от заданного типа
        /// </summary>
        /// <param name="centerX">Положение центра блока по оси X</param>
        /// <param name="centerY">Положение центра блока по оси Y</param>
        /// <param name="blockSize">Размер блока, который используется для расчета координат</param>
        /// <param name="sectionNumber">Тип блока, который определяет его форму</param>
        /// <returns>Массив точек, определяющих форму блока</returns>
        private static Point[] GetPoints(int centerX, int centerY, int blockSize, int type)
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
