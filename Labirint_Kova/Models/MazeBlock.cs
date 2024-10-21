using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_Kova.Models
{
    internal class MazeBlock
    {
        /// <summary>
        /// Координаты углов блока
        /// </summary>
        public Point[] Points 
        { get; protected set; }

        /// <summary>
        /// Цвет блока
        /// </summary>
        public Color BlockColor 
        { get; protected set; }

        /// <summary>
        /// Флаг отображения
        /// </summary>
        public bool IsVisible 
        { get; set; }

        public MazeBlock(Color color)
        {
            BlockColor = color;
            IsVisible = true;
        }

        public virtual void Draw(Graphics g)
        {
            if (IsVisible)
            {
                g.FillPolygon(new SolidBrush(BlockColor), Points);
            }
        }
    }
}
