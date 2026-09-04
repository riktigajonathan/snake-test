using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test;

internal class Player
{
    Snake snake;
    Vector2i dir = Settings.startDir;
    Dictionary<ConsoleKey, Action> keybinds = new();

    public Player()
    {
        snake = new Snake(Settings.startPos, Settings.startLength);

        keybinds.Add(ConsoleKey.UpArrow, () => dir = Vector2i.Equals(dir, Vector2i.DOWN) ? dir : Vector2i.UP);
        keybinds.Add(ConsoleKey.DownArrow, () => dir = Vector2i.Equals(dir, Vector2i.UP) ? dir : Vector2i.DOWN);
        keybinds.Add(ConsoleKey.RightArrow, () => dir = Vector2i.Equals(dir, Vector2i.LEFT) ? dir : Vector2i.RIGHT);
        keybinds.Add(ConsoleKey.LeftArrow, () => dir = Vector2i.Equals(dir, Vector2i.RIGHT) ? dir : Vector2i.LEFT);
    }

    public void Update()
    {
        InputCheck();
        Move();
        snake.Update();
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

    public void Move()
    {
        snake.Move(dir);
    }
}
