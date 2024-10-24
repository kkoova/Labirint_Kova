using System;
using System.Drawing;

namespace Labirint_Kova.Models.Blocks.VisBlocks
{
    /// <summary>
    /// Блок [3, 1]
    /// </summary>
    internal class Block_3_1 : MazeBlocks
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Block_3_1"/>.
        /// </summary>
        /// <param name="centerX">Положение центра блока по оси X</param>
        /// <param name="centerY">Положение центра блока по оси Y</param>
        /// <param name="blockSize">Размер блока</param>
        /// <param name="color">Цвет блока</param>
        /// <param name="type">Тип блока, определяющий его форму</param>
        public Block_3_1(int centerX, int centerY, int blockSize, Color color, int type)
            : base(GetPoints(centerX, centerY, blockSize, type), color)
        {
        }

        /// <summary>
        /// Получает массив точек, определяющих форму блока в зависимости от заданного типа
        /// </summary>
        /// <param name="centerX">Положение центра блока по оси X</param>
        /// <param name="centerY">Положение центра блока по оси Y</param>
        /// <param name="blockSize">Размер блока, который используется для расчета координат</param>
        /// <param name="type">Тип блока, который определяет его форму</param>
        /// <returns>Массив точек, определяющих форму блока</returns>
        private static Point[] GetPoints(int centerX, int centerY, int blockSize, int type)
        {
            switch (type)
            {
                case 1:
                    return new Point[]
                    {
                    new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),
                    new Point(0, centerY - blockSize / 4 * 2),
                    new Point(0, centerY + blockSize + blockSize / 4 * 2),
                    new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2)
                    };
                case 2:
                    return new Point[]
                    {
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),
                    new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),
                    new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4)
                    };
                default:
                    throw new ArgumentException("Invalid section number");
            }
        }
    }
}
