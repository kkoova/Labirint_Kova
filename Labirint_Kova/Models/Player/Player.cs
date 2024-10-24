namespace Labirint_Kova.Models.Player
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }

        public int[,] GetVisibleArea(int[,] maze)
        {
            var visibleArea = new int[4, 3];  // Видимая область размером 4x3

            // Игрок всегда находится на позиции [3,1] видимой области
            // Мы всегда рассчитываем блоки относительно этой позиции

            for (var y = 0; y < 4; y++)  // Проходим по вертикали
            {
                for (var x = -1; x <= 1; x++)  // Проходим по горизонтали (влево и вправо от игрока)
                {
                    // Позиции для проверки в лабиринте
                    var checkX = X + x;  // Горизонтальная позиция в лабиринте относительно игрока
                    var checkY = Y + (3 - y);  // Здесь мы изменили знак на "+", чтобы двигаться вверх от игрока

                    // Проверяем границы лабиринта
                    if (checkX >= 0 && checkX < maze.GetLength(0) && checkY >= 0 && checkY < maze.GetLength(1))
                    {
                        visibleArea[y, x + 1] = maze[checkX, checkY];  // Отображаем блок из лабиринта
                    }
                    else
                    {
                        visibleArea[y, x + 1] = 1;  // Если за пределами лабиринта, считаем стеной
                    }
                }
            }

            return visibleArea;
        }


    }

}
