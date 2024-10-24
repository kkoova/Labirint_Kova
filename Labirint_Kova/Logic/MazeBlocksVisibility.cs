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
            for (int i = 0; i < mazeBlocks.Count; i++)
            {
                int x = GetBlockX(i);
                int y = GetBlockY(i);

                if (x >= 0 && x < visibleArea.GetLength(0) && y >= 0 && y < visibleArea.GetLength(1))
                {
                    // Если в visibleArea 1, то блок видим, иначе невидим
                    mazeBlocks[i].IsVisible = visibleArea[x, y] == 1;
                }
                else
                {
                    mazeBlocks[i].IsVisible = false; // Если блок за пределами видимой области
                }
            }
        }

        // Вспомогательный метод для получения координат X
        private static int GetBlockX(int index)
        {
            // Логика для получения X-координаты блока
            // Можно подстроить под нужную структуру данных
            return index % 11; // Пример, где 41 — ширина лабиринта
        }

        // Вспомогательный метод для получения координат Y
        private static int GetBlockY(int index)
        {
            // Логика для получения Y-координаты блока
            return index / 5; // Пример, где 41 — ширина лабиринта
        }
    }

}
