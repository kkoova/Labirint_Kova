using System.Drawing;

namespace Labirint_Kova.Models
{
    public class MazeBlocks
    {
        /// <summary>
        /// Координаты углов блока
        /// </summary>
        public Point[] Points
        { get; private set; }

        /// <summary>
        /// Цвет блока
        /// </summary>
        public Color BlockColor
        { get; private set; }

        /// <summary>
        /// Флаг отображения
        /// </summary>
        public bool IsVisible
        { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MazeBlocks"/> с заданными точками и цветом
        /// </summary>
        /// <param name="points">Массив точек, определяющий форму блока</param>
        /// <param name="color">Цвет блока</param>
        public MazeBlocks(Point[] points, Color color)
        {
            Points = points;
            BlockColor = color;
            IsVisible = true;
        }
    }
}
