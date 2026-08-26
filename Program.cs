using snake_test.Objects;
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
    
            var snake = new Snake(new Vector2i(2,0));
            var map = new Map(24,24);

            while (true)
            {
                FrameBuffer.Clear();
                map.Draw();
                snake.Draw();
                FrameBuffer.Draw();
            }
        }
    }
}