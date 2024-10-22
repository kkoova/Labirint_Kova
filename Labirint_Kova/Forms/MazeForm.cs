using Labirint_Kova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_Kova.Forms
{
    public partial class MazeForm : Form
    {
        private List<MazeBlock> blocks;
        private const int blockSize = 450;
        public MazeForm()
        {
            InitializeComponent();

            DoubleBuffered = true;
            Paint += new PaintEventHandler(DrawMaze3D);

            InitializeBlocks();

        }

        /// <summary>
        /// Инициализация блоков
        /// </summary>
        private void InitializeBlocks()
        {
            int centerX = (ClientSize.Width - blockSize) / 2;
            int centerY = (ClientSize.Height - blockSize) / 2;

            blocks = new List<MazeBlock>
            {
                //пол
                new MazeBlock(new Point[]
                {
                    new Point(0, centerY + blockSize),
                    new Point(ClientSize.Width, centerY + blockSize),
                    new Point(ClientSize.Width, centerY + blockSize + blockSize / 4),
                    new Point(0, centerY + blockSize + blockSize / 4),
                }, Color.Yellow),

                new MazeBlock(new Point[]
                {
                    new Point(0, centerY + blockSize + blockSize / 4),                    // Левый верхний угол окна
                    new Point(ClientSize.Width, centerY + blockSize + blockSize / 4),          // Правый верхний угол окна
                    new Point(ClientSize.Width, centerY + blockSize + blockSize / 2),          // Правый нижний угол (высота blockSize / 4)
                    new Point(0, centerY + blockSize + blockSize / 2),
                }, Color.Red),

                new MazeBlock(new Point[]
{
                new Point(0, centerY + blockSize + blockSize / 2),                    // Левый верхний угол окна
                new Point(ClientSize.Width, centerY + blockSize + blockSize / 2),          // Правый верхний угол окна
                new Point(ClientSize.Width, centerY + blockSize + 3 * blockSize / 4),      // Правый нижний угол (высота blockSize / 4)
                new Point(0, centerY + blockSize + 3 * blockSize / 4),                // Левый нижний угол
                }, Color.Yellow),

                //потолок
                new MazeBlock(new Point[]
                {
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX + blockSize, centerY),
                    new Point(centerX, centerY),
                }, Color.Yellow),

                new MazeBlock(new Point[]
                {
                    new Point(0, centerY - blockSize / 4 - blockSize / 4),                     // Левый верхний угол
                    new Point(ClientSize.Width, centerY - blockSize / 4 - blockSize / 4),             // Правый верхний угол
                    new Point(ClientSize.Width, centerY - blockSize / 4),                              // Правый нижний угол
                    new Point(0, centerY - blockSize / 4)
                }, Color.Red),

                new MazeBlock(new Point[]
                {
                    new Point(0, centerY - blockSize / 4 - 2 * blockSize / 4),                 // Левый верхний угол
                    new Point(ClientSize.Width, centerY - blockSize / 4 - 2 * blockSize / 4),         // Правый верхний угол
                    new Point(ClientSize.Width, centerY - blockSize / 4 - blockSize / 4),             // Правый нижний угол
                    new Point(0, centerY - blockSize / 4 - blockSize / 4)
                }, Color.Yellow),

                //середина
                new MazeBlock(new Point[]
                {
                    new Point(centerX, centerY),                          // Левый верхний угол
                    new Point(centerX + blockSize, centerY),              // Правый верхний угол
                    new Point(centerX + blockSize, centerY + blockSize),  // Правый нижний угол
                    new Point(centerX, centerY + blockSize),               // Левый нижний угол
                }, Color.Green),
  
                new MazeBlock(new Point[]
                {
                    new Point(centerX + blockSize, centerY),                                                // Левый верхний угол
                    new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),                // Правый верхний угол
                    new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4),    // Правый нижний угол
                    new Point(centerX + blockSize, centerY + blockSize),                                     // Левый нижний угол         
                }, Color.Red),

                new MazeBlock(new Point[]
                {
                    new Point(centerX, centerY),
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),
                    new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4),
                    new Point(centerX, centerY + blockSize),
                }, Color.Red),

                new MazeBlock(new Point[]
                {
                    new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                    new Point(centerX + blockSize * 2, centerY - blockSize / 4),              // Правый верхний угол
                    new Point(centerX + blockSize * 2, centerY + blockSize + blockSize / 4),  // Правый нижний угол
                    new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
                }, Color.Gray),// Цвет блока (например, зеленый)

                new MazeBlock(new Point[]
                {
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                    new Point(centerX - blockSize - blockSize / 4, centerY - blockSize / 4),              // Правый верхний угол
                    new Point(centerX - blockSize - blockSize / 4, centerY + blockSize + blockSize / 4),  // Правый нижний угол
                    new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
                }, Color.Gray),// Цвет блока (например, зеленый)

                new MazeBlock(new Point[]
                {
                    new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                    new Point(0, centerY - blockSize / 4 * 2),              // Правый верхний угол
                    new Point(0, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                    new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
                }, Color.Gray),// Цвет блока (например, зеленый)

                new MazeBlock(new Point[]
                {
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                    new Point(ClientSize.Width + 20, centerY - blockSize / 4 * 2),              // Правый верхний угол
                    new Point(ClientSize.Width + 20, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
                }, Color.Gray),// Цвет блока (например, зеленый)

                new MazeBlock(new Point[]
                {
                    new Point(centerX + blockSize + blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),              // Правый верхний угол
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                    new Point(centerX + blockSize + blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
                }, Color.Yellow),// Цвет блока (например, зеленый)

                new MazeBlock(new Point[]
                {
                    new Point(centerX - blockSize / 4, centerY - blockSize / 4),                          // Левый верхний угол
                    new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),              // Правый верхний угол
                    new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),  // Правый нижний угол
                    new Point(centerX - blockSize / 4, centerY + blockSize + blockSize / 4),               // Левый нижний угол
                }, Color.Yellow),// Цвет блока (например, зеленый)

                new MazeBlock(new Point[]
                {
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                    new Point(centerX + blockSize + blockSize / 4 * 3, centerY - blockSize / 4 * 3),              // Правый верхний угол
                    new Point(centerX + blockSize + blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),  // Правый нижний угол
                    new Point(centerX + blockSize + blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
                }, Color.Red),// Цвет блока (например, зеленый)

                new MazeBlock(new Point[]
                {
                    new Point(centerX - blockSize / 4 * 2, centerY - blockSize / 4 * 2),                          // Левый верхний угол
                    new Point(centerX - blockSize / 4 * 3, centerY - blockSize / 4 * 3),              // Правый верхний угол
                    new Point(centerX - blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),  // Правый нижний угол
                    new Point(centerX - blockSize / 4 * 2, centerY + blockSize + blockSize / 4 * 2),               // Левый нижний угол
                }, Color.Red),



                new MazeBlock(new Point[]
                {
                    new Point(centerX + blockSize + blockSize / 4 * 3, centerY - blockSize / 4 * 3),                          // Левый верхний угол
                    new Point(ClientSize.Width + 20, centerY - blockSize / 4 * 4),              // Правый верхний угол
                    new Point(ClientSize.Width + 20, centerY + blockSize + blockSize / 4 * 4),  // Правый нижний угол
                    new Point(centerX + blockSize + blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),               // Левый нижний угол
                }, Color.Black),// Цвет блока (например, зеленый)

                 new MazeBlock(new Point[]
                {
                    new Point(centerX - blockSize / 4 * 3, centerY - blockSize / 4 * 3),                          // Левый верхний угол
                    new Point(0, centerY - blockSize / 4 * 4),              // Правый верхний угол
                    new Point(0, centerY + blockSize + blockSize / 4 * 4),  // Правый нижний угол
                    new Point(centerX - blockSize / 4 * 3, centerY + blockSize + blockSize / 4 * 3),               // Левый нижний угол
                }, Color.Black)
            };
        }

        private void DrawMaze3D(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.LightGray); // Цвет фона

            // Отрисовка каждого блока, если он активен
            foreach (MazeBlock block in blocks)
            {
                if (block.IsVisible)
                {
                    g.FillPolygon(new SolidBrush(block.BlockColor), block.Points);
                }
            }
        }

        public void HideBlock(int index)
        {
            if (index >= 0 && index < blocks.Count)
            {
                blocks[index].IsVisible = false;
                this.Invalidate(); // Обновляем экран
            }
        }

        // Метод для показа блока по индексу
        public void ShowBlock(int index)
        {
            if (index >= 0 && index < blocks.Count)
            {
                blocks[index].IsVisible = true;
                this.Invalidate(); // Обновляем экран
            }
        }

        private void MazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void MazeForm_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in Controls)
            {
                picture.BackColor = Color.Transparent;
            }
        }
    }
}
