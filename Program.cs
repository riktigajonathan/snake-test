using System.Numerics;
using System.Runtime.Intrinsics;
using static System.Net.WebRequestMethods;
using System.Threading;

namespace snake_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FConsole.Initialize("snake");
    
            var player = new Player();
            var map = new Map(24,24);

            while (true)
            {
                map.Update();
                player.Update();
                
                FrameBuffer.Draw();

                Thread.Sleep(100);
            }
        }
    }
}
