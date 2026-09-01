using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test
{
    class Snake
    {
        List<Body> bodies;
        public Snake(Vector2i pos, int length = 1)
        {
            bodies = new List<Body>();
            for (int i = 0; i < length; i++)
            {
                bodies.Add(new Body(pos));
            }
        }

        public void QueueDraw()
        {
            foreach (Body b in bodies)
            {
                foreach (Tile t in b.shape)
                {
                    var tilePos = t.GetPos();
                    var bodyPos = b.GetPos();
                    Tile tile = new Tile(new Vector2i(tilePos.x + bodyPos.x, tilePos.y + bodyPos.y), t.color, t.visual);
                    FrameBuffer.Add(tile);
                }
            }
        }

        public List<Tile> GetTiles()
        {
            List<Tile> toReturn = new List<Tile>();

            foreach (Body b in bodies)
            {
                foreach (Tile t in b.shape)
                {
                    var pos = t.GetPos();

                    Tile tile = new Tile(Vector2i.Add(pos, b.GetPos()), t.color, t.visual);

                    toReturn.Add(tile);
                }
            }

            return toReturn;
        }
        public void Move(Vector2i dir)
        {
            Body head = bodies[0];
            Vector2i toMove = Vector2i.Multiply(dir, bodies[bodies.Count - 1].size);
            MoveTail();
            MoveHead(Vector2i.Add(head.GetPos(), toMove));
        }

        public void MoveTail()
        {
            for (int i = bodies.Count-1; i >= 1; i--)
            {
                bodies[i].SetPos(bodies[i - 1].GetPos());
            }
        }

        public void MoveHead(Vector2i newPos)
        {
            bodies[0].SetPos(newPos);
        }
    }
}