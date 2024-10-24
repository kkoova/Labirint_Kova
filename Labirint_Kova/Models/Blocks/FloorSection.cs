using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_Kova.Models.Blocks
{
    /// <summary>
    /// Блоки пола
    /// </summary>
    public class FloorSection : MazeBlocks
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FloorSection"/>.
        /// </summary>
        /// <param name="centerX">Положение центра блока по оси X</param>
        /// <param name="centerY">Положение центра блока по оси Y</param>
        /// <param name="blockSize">Размер блока</param>
        /// <param name="color">Цвет блока</param>
        /// <param name="type">Тип блока, определяющий его форму</param>
        public FloorSection(int formWidth, int centerY, int blockSize, int sectionNumber, Color color)
        : base(GetSectionPoints(formWidth, centerY, blockSize, sectionNumber), color)
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
