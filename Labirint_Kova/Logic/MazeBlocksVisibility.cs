using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labirint_Kova.Models;

namespace Labirint_Kova.Logic
{
    public class MazeBlocksVisibility
    {
        /// <summary>
        /// Обновлене видимости блоков на основе области видимости
        /// </summary>
        /// <param name="mazeBlocks">Список всех блоков</param>
        /// <param name="visibleArea">Двумерный массив, где 1 — блок видим, 0 — блок невидим</param>
        public static void UpdateMazeBlocksVisibility(List<MazeBlocks> mazeBlocks, int[,] visibleArea)
        {
            AllVisible(mazeBlocks);

            if (visibleArea[0, 0] == 0)
            {
                mazeBlocks[8].IsVisible = false;
            }
            if (visibleArea[0, 1] == 0)
            {
                mazeBlocks[6].IsVisible = false;
            }
            if (visibleArea[0, 2] == 0)
            {
                mazeBlocks[7].IsVisible = false;
            }
            if (visibleArea[1, 0] == 0)
            {
                mazeBlocks[11].IsVisible = false;
                mazeBlocks[12].IsVisible = false;
            }
            if (visibleArea[1, 1] == 0)
            {
                mazeBlocks[13].IsVisible = false;
            }
            if (visibleArea[1, 2] == 0)
            {
                mazeBlocks[10].IsVisible = false;
                mazeBlocks[9].IsVisible = false;
            }
            if (visibleArea[2, 0] == 0)
            {
                mazeBlocks[15].IsVisible = false;
                mazeBlocks[14].IsVisible = false;
            }
            if (visibleArea[2, 1] == 0)
            {
                mazeBlocks[18].IsVisible = false;
            }
            if (visibleArea[2, 2] == 0)
            {
                mazeBlocks[17].IsVisible = false;
                mazeBlocks[16].IsVisible = false;
            }
            if (visibleArea[3, 0] == 0)
            {
                mazeBlocks[19].IsVisible = false;
                mazeBlocks[20].IsVisible = false;
            }
            if (visibleArea[3, 1] == 0)
            {
                mazeBlocks[23].IsVisible = false;
            }
            if (visibleArea[3, 2] == 0)
            {
                mazeBlocks[21].IsVisible = false;
                mazeBlocks[22].IsVisible = false;
            }
        }

        public static void AllVisible(List<MazeBlocks> mazeBlocks)
        {
            foreach (var blocks in mazeBlocks)
            {
                blocks.IsVisible = true;
            }
        }
    }
}
