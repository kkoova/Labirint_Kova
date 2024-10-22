using Labirint_Kova.Models;
using System.Collections.Generic;
using System.Drawing;

namespace Labirint_Kova.Logic
{
    public static class MazeBuilder
    {
        public static List<MazeBlocks> CreateMazeBlocks(int centerX, int centerY, int blockSize, int formWidth)
        {
            List<MazeBlocks> mazeBlocks = new List<MazeBlocks>();

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(0, centerY + blockSize),
                new Point(formWidth, centerY + blockSize),
                new Point(formWidth, centerY + blockSize + blockSize / 4),
                new Point(0, centerY + blockSize + blockSize / 4),
            }, ColorMaze.LimeGreen));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(0, centerY + blockSize + blockSize / 4),
                new Point(formWidth, centerY + blockSize + blockSize / 4),
                new Point(formWidth, centerY + blockSize + blockSize / 2),
                new Point(0, centerY + blockSize + blockSize / 2),
            }, ColorMaze.MustardYellow));

            mazeBlocks.Add(new MazeBlocks(new Point[]
{
            new Point(0, centerY + blockSize + blockSize / 2),                    // Левый верхний угол окна
            new Point(formWidth, centerY + blockSize + blockSize / 2),          // Правый верхний угол окна
            new Point(formWidth, centerY + blockSize + 3 * blockSize / 4),      // Правый нижний угол (высота blockSize / 4)
            new Point(0, centerY + blockSize + 3 * blockSize / 4),                // Левый нижний угол
            }, ColorMaze.BrightLime));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),
                new Point(centerX + blockSize, centerY),
                new Point(centerX, centerY),
            }, ColorMaze.LeafGreen));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(0, centerY - blockSize / 4 - blockSize / 4),                     // Левый верхний угол
                new Point(formWidth, centerY - blockSize / 4 - blockSize / 4),             // Правый верхний угол
                new Point(formWidth, centerY - blockSize / 4),                              // Правый нижний угол
                new Point(0, centerY - blockSize / 4)
            }, ColorMaze.OliveYellow));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(0, centerY - blockSize / 4 - 2 * blockSize / 4),                 // Левый верхний угол
                new Point(formWidth, centerY - blockSize / 4 - 2 * blockSize / 4),         // Правый верхний угол
                new Point(formWidth, centerY - blockSize / 4 - blockSize / 4),             // Правый нижний угол
                new Point(0, centerY - blockSize / 4 - blockSize / 4)
            }, ColorMaze.SpringGreen));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX, centerY),                          // Левый верхний угол
                new Point(centerX + blockSize, centerY),              // Правый верхний угол
                new Point(centerX + blockSize, centerY + blockSize),  // Правый нижний угол
                new Point(centerX, centerY + blockSize),               // Левый нижний угол
            }, ColorMaze.DarkBrown));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX + blockSize, centerY),                                                // Левый верхний угол
                new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),                // Правый верхний угол
                new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4),    // Правый нижний угол
                new Point(centerX + blockSize, centerY + blockSize),                                     // Левый нижний угол         
            }, ColorMaze.OliveGreen));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX, centerY),
                new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4),
                new Point(centerX, centerY + blockSize),
            }, ColorMaze.OliveGreen));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                new Point(centerX + blockSize * 2, centerY - blockSize / 4),              // Правый верхний угол
                new Point(centerX + blockSize * 2, centerY + blockSize + blockSize / 4),  // Правый нижний угол
                new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
            }, Color.Gray));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX - blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                new Point(centerX - blockSize - blockSize / 4, centerY - blockSize / 4),              // Правый верхний угол
                new Point(centerX - blockSize - blockSize / 4, centerY + blockSize + blockSize / 4),  // Правый нижний угол
                new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
            }, Color.Gray));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                new Point(0, centerY - blockSize / 4 * 2),              // Правый верхний угол
                new Point(0, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
            }, Color.Gray));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                new Point(formWidth + 20, centerY - blockSize / 4 * 2),              // Правый верхний угол
                new Point(formWidth + 20, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
            }, Color.Gray));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),              // Правый верхний угол
                new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
            }, ColorMaze.LimeGreen));

            new MazeBlocks(new Point[]
            {
                new Point(centerX - blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),              // Правый верхний угол
                new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
            }, ColorMaze.LimeGreen);

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                new Point(centerX + blockSize + blockSize / 4 * 3, centerY - blockSize / 4 * 3),              // Правый верхний угол
                new Point(centerX + blockSize + blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),  // Правый нижний угол
                new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
            }, ColorMaze.MustardYellow));

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                new Point(centerX - blockSize / 4 * 3, centerY - blockSize / 4 * 3),              // Правый верхний угол
                new Point(centerX - blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),  // Правый нижний угол
                new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
            }, ColorMaze.MustardYellow));



            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX + blockSize + blockSize / 4 * 3, centerY - blockSize / 4 * 3),                          // Левый верхний угол
                new Point(formWidth + 20, centerY - blockSize / 4 * 4),              // Правый верхний угол
                new Point(formWidth + 20, centerY + blockSize + blockSize / 4 * 4),  // Правый нижний угол
                new Point(centerX + blockSize + blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),               // Левый нижний угол
            }, Color.Black));// Цвет блока (например, зеленый)

            mazeBlocks.Add(new MazeBlocks(new Point[]
            {
                new Point(centerX - blockSize / 4 * 3, centerY - blockSize / 4 * 3),                          // Левый верхний угол
                new Point(0, centerY - blockSize / 4 * 4),              // Правый верхний угол
                new Point(0, centerY + blockSize + blockSize / 4 * 4),  // Правый нижний угол
                new Point(centerX - blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),               // Левый нижний угол
            }, Color.Black));

            return mazeBlocks;
        }
    } 
}
