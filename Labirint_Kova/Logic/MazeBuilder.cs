using Labirint_Kova.Models;
using Labirint_Kova.Models.Blocks;
using Labirint_Kova.Models.Blocks.VisBlocks;
using System.Collections.Generic;
using System.Drawing;

namespace Labirint_Kova.Logic
{
    /// <summary>
    /// Создание блоков и обновление видимости
    /// </summary>
    public static class MazeBuilder
    {
        /// <summary>
        /// Создание блоков
        /// </summary>
        /// <param name="centerX">Центр формы X</param>
        /// <param name="centerY">Центр формы Y</param>
        /// <param name="blockSize">размер блока</param>
        /// <param name="formWidth">Ширина формы</param>
        /// <param name="visibleArea">Видимые блоки</param>
        /// <returns>Лист блоков</returns>
        public static List<MazeBlocks> CreateMazeBlocks(int centerX, int centerY, int blockSize, int formWidth, int[,] visibleArea)
        {
            var mazeBlocks = new List<MazeBlocks>
            {
                new FloorSection(formWidth, centerY, blockSize, 1, ColorMaze.LimeGreen),
                new FloorSection(formWidth, centerY, blockSize, 2, ColorMaze.MustardYellow),
                new FloorSection(formWidth, centerY, blockSize, 3, ColorMaze.BrightLime),

                new CeilingSection(formWidth, centerY, blockSize, 1, ColorMaze.LeafGreen),
                new CeilingSection(formWidth, centerY, blockSize, 2, ColorMaze.OliveYellow),
                new CeilingSection(formWidth, centerY, blockSize, 3, ColorMaze.SpringGreen),

                new StaticSection(centerX, centerY, blockSize, ColorMaze.DarkBrown, 1),
                new StaticSection(centerX, centerY, blockSize, ColorMaze.DarkBrown, 2),
                new StaticSection(centerX, centerY, blockSize, ColorMaze.DarkBrown, 3),

                new Block_2_3(centerX, centerY, blockSize, ColorMaze.LeafGreen, 1),
                new Block_2_3(centerX, centerY, blockSize, ColorMaze.OliveGreen, 2),

                new Block_2_1(centerX, centerY, blockSize, ColorMaze.LeafGreen, 1),
                new Block_2_1(centerX, centerY, blockSize, ColorMaze.OliveGreen, 2),

                new StaticSection(centerX, centerY, blockSize, ColorMaze.LeafGreen, 4),

                new Block_3_1(centerX, centerY, blockSize, ColorMaze.LeafGreen, 1),
                new Block_3_1(centerX, centerY, blockSize, ColorMaze.LimeGreen, 2),

                new Block_3_3(centerX, centerY, blockSize, formWidth, ColorMaze.LeafGreen, 1),
                new Block_3_3(centerX, centerY, blockSize, formWidth, ColorMaze.LimeGreen, 2),

                new StaticSection(centerX, centerY, blockSize, ColorMaze.LeafGreen, 5),

                new Block_4_1(centerX, centerY, blockSize, Color.Black, 1),
                new Block_4_1(centerX, centerY, blockSize, ColorMaze.MustardYellow, 2),

                new Block_4_3(centerX, centerY, blockSize, formWidth,  Color.Black, 1),
                new Block_4_3(centerX, centerY, blockSize, formWidth,  ColorMaze.MustardYellow, 2),

                new StaticSection(centerX, centerY, blockSize, ColorMaze.BrightLime, 6),
        };

            MazeBlocksVisibility.UpdateMazeBlocksVisibility(mazeBlocks, visibleArea);

            return mazeBlocks;
        }
    }
}
