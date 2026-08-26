using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test.Objects
{
    internal class Tile
    {
        public const char DEFAULT_CHAR = 'O';

        Vector2i pos;
        public char visual;
        public ConsoleColor color;

        public Tile(Vector2i pos, ConsoleColor color = ConsoleColor.White, char visual = DEFAULT_CHAR)
        {
            this.pos = pos;
            this.visual = visual;
            this.color = color;
        }

        public Vector2i GetPos()
        {
            return pos;
        }

        static public List<Vector2i> ExtractPositions(List<Tile> tiles)
        {
            var toReturn = new List<Vector2i>();

            foreach (Tile tile in tiles)
            {
                toReturn.Add(tile.pos);
            }

            return toReturn;
        }
    }
}
