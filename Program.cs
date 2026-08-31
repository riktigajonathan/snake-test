using System.Numerics;
using System.Runtime.Intrinsics;
using static System.Net.WebRequestMethods;

namespace snake_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
    
            var player = new Player();
            var map = new Map(24,24);

            while (true)
            {
                FrameBuffer.Clear();
                map.Draw();
                player.Move(Vector2i.RIGHT);
                player.Draw();
                FrameBuffer.Draw();
            }
        }
    }
}