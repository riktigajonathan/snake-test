using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test;

public class Death : Gamestate
{
    public Death() : base("death") { }

    public override void OnEnter()
    {
        Console.Clear();
        Console.WriteLine("ya diedd");
        Console.WriteLine(FrameBuffer.buffer.Count);
        Settings.gameLoopActive = false;
    }
}
