using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test;

public class Game : Gamestate
{
    public Game() : base("game") { }

    Player player;
    Map map;

    public override void OnEnter()
    {
        player = new();
        map = new();
    }

    public override void Update()
    {
        map.Update();
        player.Update();

        FrameBuffer.Draw();

        Thread.Sleep(Settings.waitMs);
    }
}
