using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test
{
    internal class Body
    {
        Vector2i pos;
        Vector2i size = new Vector2i(3, 3); // add auto size
        public Tile[] shape = [
            new Tile(new Vector2i(0,0)), new Tile(new Vector2i(1, 0)), new Tile(new Vector2i(2, 0)),
            new Tile(new Vector2i(0,1)), new Tile(new Vector2i(1, 1)), new Tile(new Vector2i(2, 1)),
            new Tile(new Vector2i(0,2)), new Tile(new Vector2i(1, 2)), new Tile(new Vector2i(2, 2)),
        ];

        public Body(Vector2i pos)
        {
            this.pos = pos;
        }

        public Vector2i GetPos()
        {
            return pos;
        }
    }
}
