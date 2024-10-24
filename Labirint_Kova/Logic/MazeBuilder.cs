using Labirint_Kova.Models;
using Labirint_Kova.Models.Blocks;
using Labirint_Kova.Models.Blocks.VisBlocks;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint_Kova.Logic
{
    public static class MazeBuilder
    {
        public static List<MazeBlocks> CreateMazeBlocks(int centerX, int centerY, int blockSize, int formWidth)
        {
            var mazeBlocks = new List<MazeBlocks>
            {
                //new FloorSection(formWidth, centerY, blockSize, 1, ColorMaze.LimeGreen),
                //new FloorSection(formWidth, centerY, blockSize, 2, ColorMaze.MustardYellow),
                //new FloorSection(formWidth, centerY, blockSize, 3, ColorMaze.BrightLime),

                new CeilingSection(formWidth, centerX, centerY, blockSize, 1, ColorMaze.LeafGreen),
                //new CeilingSection(formWidth, centerX, centerY, blockSize, 2, ColorMaze.OliveYellow),
                //new CeilingSection(formWidth, centerX, centerY, blockSize, 3, ColorMaze.SpringGreen),

                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.DarkBrown, 1),
                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.OliveGreen, 2),
                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.OliveGreen, 3),

                //new Block_2_3(centerX, centerY, blockSize, ColorMaze.LeafGreen, 1),
                //new Block_2_3(centerX, centerY, blockSize, ColorMaze.OliveGreen, 2),

                //new Block_2_1(centerX, centerY, blockSize, ColorMaze.LeafGreen, 1),
                //new Block_2_1(centerX, centerY, blockSize, ColorMaze.OliveGreen, 2),

                //new Block_3_1(centerX, centerY, blockSize, ColorMaze.LeafGreen, 1),
                //new Block_3_1(centerX, centerY, blockSize, ColorMaze.LimeGreen, 2),

                //new Block_3_3(centerX, centerY, blockSize, formWidth, ColorMaze.LeafGreen, 1),
                //new Block_3_3(centerX, centerY, blockSize, formWidth, ColorMaze.LimeGreen, 2),

                //new Block_4_1(centerX, centerY, blockSize, formWidth, ColorMaze.BrightLime, 1),
                //new Block_4_1(centerX, centerY, blockSize, formWidth, ColorMaze.MustardYellow, 2),

                //new Block_4_3(centerX, centerY, blockSize, formWidth,  ColorMaze.BrightLime, 1),
                //new Block_4_3(centerX, centerY, blockSize, formWidth,  ColorMaze.MustardYellow, 2),
        };

            int[,] visibleArea = new int[,]
            {
                { 1, 0, 1 },
                { 0, 0, 0 },
                { 1, 0, 1 },
                { 0, 0, 1 }
            };

            //MazeBlocksVisibility.UpdateMazeBlocksVisibility(mazeBlocks, visibleArea);

            return mazeBlocks;
        }
    }
}
