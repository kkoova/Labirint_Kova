using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_Kova.Models
{
    internal class MazeBlocks
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

        public MazeBlocks(Point[] points, Color color)
        {
            Points = points;
            BlockColor = color;
            IsVisible = true;
        }
    }
}
