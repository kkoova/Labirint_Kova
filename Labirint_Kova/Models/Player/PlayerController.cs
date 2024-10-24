namespace Labirint_Kova.Models.Player
{
    public class PlayerController
    {
        private readonly Player player;
        private readonly int[,] maze;

        public PlayerController(Player player, int[,] maze)
        {
            this.player = player;
            this.maze = maze;
        }

        public void Move(int dx, int dy)
        {
            var newX = player.X + dx;
            var newY = player.Y + dy;

            if (IsValidMove(newX, newY))
            {
                player.X = newX;
                player.Y = newY;
            }
        }

        private bool IsValidMove(int x, int y)
        {
            return x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1) && maze[x, y] == 0;
        }
    }
}
