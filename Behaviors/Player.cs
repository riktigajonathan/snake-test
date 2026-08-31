using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test
{
    internal class Player
    {
        public Snake snake;

        public Player()
        {
            snake = new Snake(new Vector2i(0, 0), 2);
        }

        public void Move(Vector2i dir)
        {
            snake.Move(dir);
        }

        public void Draw()
        {
            snake.Draw();
        }
    }
}
