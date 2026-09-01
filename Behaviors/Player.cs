using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test
{
    internal class Player
    {
        Snake snake;
        Dictionary<ConsoleKey, Action> keybinds = new();
        Vector2i dir = Vector2i.RIGHT;

        public Player()
        {
            snake = new Snake(new Vector2i(0, 0), 3);

            keybinds.Add(ConsoleKey.UpArrow, () => dir = Vector2i.UP);
            keybinds.Add(ConsoleKey.DownArrow, () => dir = Vector2i.DOWN);
            keybinds.Add(ConsoleKey.RightArrow, () => dir = Vector2i.RIGHT);
            keybinds.Add(ConsoleKey.LeftArrow, () => dir = Vector2i.LEFT);
        }

        public void Move()
        {
            snake.Move(dir);
        }

        public void Update()
        {
            InputCheck();
            Move();
            snake.QueueDraw();
        }

        public void InputCheck()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                foreach (ConsoleKey key in keybinds.Keys)
                {
                    if (keyInfo.Key == key)
                    {
                        keybinds[key].Invoke();
                    }
                }
            }
        }
    }
}
