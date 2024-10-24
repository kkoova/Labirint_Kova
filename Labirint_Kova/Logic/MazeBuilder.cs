using Labirint_Kova.Models;
using Labirint_Kova.Models.Blocks;
using System.Collections.Generic;
using System.Drawing;

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

                //new CeilingSection(formWidth, centerX, centerY, blockSize, 1, ColorMaze.LeafGreen),
                //new CeilingSection(formWidth, centerX, centerY, blockSize, 2, ColorMaze.OliveYellow),
                //new CeilingSection(formWidth, centerX, centerY, blockSize, 3, ColorMaze.SpringGreen),



                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.DarkBrown, 1),
                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.OliveGreen, 8),
                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.OliveGreen, 9),
                new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.LeafGreen, 2),
                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.LeafGreen, 3),
                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.LeafGreen, 4),
                //new StaticSection(centerX, centerY, blockSize, formWidth, ColorMaze.LeafGreen, 5),
                //new StaticSection(centerX, centerY, blockSize, formWidth, Color.Black, 6),
                //new StaticSection(centerX, centerY, blockSize, formWidth, Color.Black, 7),

                new DiagonalSection(centerX, centerY, blockSize, formWidth, ColorMaze.OliveGreen, 1),
                //new DiagonalSection(centerX, centerY, blockSize, formWidth, ColorMaze.OliveGreen, 2),
                //new DiagonalSection(centerX, centerY, blockSize, formWidth, ColorMaze.LimeGreen, 3),
                //new DiagonalSection(centerX, centerY, blockSize, formWidth, ColorMaze.LimeGreen, 4),
                //new DiagonalSection(centerX, centerY, blockSize, formWidth, ColorMaze.MustardYellow, 5),
                //new DiagonalSection(centerX, centerY, blockSize, formWidth, ColorMaze.MustardYellow, 6),
        };

            int[,] visibleArea = new int[,]
            {
                { 1, 0, 1 },
                { 1, 0, 1 },
                { 1, 0, 0 },
                { 1, 0, 1 }
            };

            //MazeBlocksVisibility.UpdateMazeBlocksVisibility(mazeBlocks, visibleArea);

            foreach (var block in mazeBlocks)
            {
                if (block.IsVisible)
                {
                    block.IsVisible = true;
                }
            }

            return mazeBlocks;
        }
    }
}
