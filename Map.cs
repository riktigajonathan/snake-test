using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test
{
    internal class Map
    {
        public static List<Tile> tiles = new List<Tile>();
        public static int width = 0;
        public static int height = 0;

        public Map(int _width, int _height)
        {
            width = _width;
            height = _height;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Tile newTile = new Tile(new Vector2i(j, i), ConsoleColor.Gray, '.');
                    tiles.Add(newTile);
                }
            }
        }

        public void Update()
        {
            QueueDraw();
        }

        public void QueueDraw()
        {
            foreach (var tile in tiles)
            {
                FrameBuffer.Add(tile);
            }
        }
    }
}
