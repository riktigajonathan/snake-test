using System.Numerics;
using System.Runtime.Intrinsics;
using static System.Net.WebRequestMethods;
using System.Threading;
using snake_test.Libraries;

namespace snake_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libraries.FConsole.Initialize("snake");
    
            var player = new Player();
            var map = new Map(24,24);

            while (true)
            {
                player.Move(Vector2i.RIGHT);
                
                map.Draw();
                player.Draw();
                
                FrameBuffer.Draw();
                FConsole.DrawBuffer();

                Thread.Sleep(100);
            }
        }
    }
}
