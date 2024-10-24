using System.Collections.Generic;
using Labirint_Kova.Models;

namespace Labirint_Kova.Logic
{
    /// <summary>
    /// Перевод блоков в видимое и невидимое состояние
    /// </summary>
    public class MazeBlocksVisibility
    {
        /// <summary>
        /// Обновление видимости блоков на основе области видимости
        /// </summary>
        /// <param name="mazeBlocks">Список всех блоков</param>
        /// <param name="visibleArea">Двумерный массив, где 1 — блок видим, 0 — блок невидим</param>
        public static void UpdateMazeBlocksVisibility(List<MazeBlocks> mazeBlocks, int[,] visibleArea)
        {
            AllVisible(mazeBlocks);

            var blockMapping = new int[,]
            {
                { 8, 6, 7 },
                { 11, 13, 10 },
                { 15, 18, 17 },
                { 20, 23, 22 },
            };

            var adjacentBlocks = new Dictionary<int, int[]>
            {
                { 11, new[] { 12 } },
                { 10, new[] { 9 } },
                { 15, new[] { 14 } },
                { 17, new[] { 16 } }
            };

            for (var y = 0; y < visibleArea.GetLength(0); y++)
            {
                for (var x = 0; x < visibleArea.GetLength(1); x++)
                {
                    if (visibleArea[y, x] == 0)
                    {
                        mazeBlocks[blockMapping[y, x]].IsVisible = false;

                        if (adjacentBlocks.ContainsKey(blockMapping[y, x]))
                        {
                            foreach (var adjacentIndex in adjacentBlocks[blockMapping[y, x]])
                            {
                                mazeBlocks[adjacentIndex].IsVisible = false;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Перевод всех блоков в видимое состояние
        /// </summary>
        /// <param name="mazeBlocks">Список всех блоков</param>
        public static void AllVisible(List<MazeBlocks> mazeBlocks)
        {
            foreach (var blocks in mazeBlocks)
            {
                blocks.IsVisible = true;
            }
        }
    }
}
