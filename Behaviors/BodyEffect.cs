using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test;

internal class BodyEffect
{
    public Action<List<Body>> action;

    public BodyEffect(Action<List<Body>> action) 
    {
        this.action = action;
    }

    public static Action<List<Body>> continuity = (bodies) =>
    {
        Reset(bodies);

        for (int i = 0; i < bodies.Count-1; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Body body = bodies[i+j];
                List<Tile> shape = body.GetShape();
                Vector2i size = body.GetSize();
                Vector2i middlePos = Vector2i.Divide(size, new Vector2i(2, 2));
                Vector2i change;
                if (j == 0)
                {
                    change = Vector2i.Sub(bodies[i + 1].GetPos(), body.GetPos());
                }
                else
                {
                    change = Vector2i.Sub(bodies[i].GetPos(), body.GetPos());
                }
                
                change = Vector2i.Sign(change);
                if (Equals(change, Vector2i.DOWN))
                {
                    RemoveAt(new Vector2i(middlePos.x, size.y - 1), shape);
                }
                else if (Equals(change, Vector2i.UP))
                {
                    RemoveAt(new Vector2i(middlePos.x, 0), shape);
                }
                else if (Equals(change, Vector2i.RIGHT))
                {
                    RemoveAt(new Vector2i(size.x - 1, middlePos.y), shape);
                }
                else if (Equals(change, Vector2i.LEFT))
                {
                    RemoveAt(new Vector2i(0, middlePos.y), shape);
                }
            }
        }

        void RemoveAt(Vector2i pos, List<Tile> shape)
        {
            for (int i = 0; i < shape.Count; i++)
            {
                if (shape[i] == null) continue;

                if (Vector2i.Equals(shape[i].GetPos(), pos))
                {
                    shape[i].pixelValue = new PixelValue(shape[i].pixelValue.foreground, shape[i].pixelValue.background, '.');
                }
            }
        }

        void Reset(List<Body> bodies)
        {
            foreach (Body body in bodies)
            {
                List<Tile> shape = body.GetShape();
                foreach (Tile t in shape)
                {
                    t.pixelValue = new PixelValue(t.pixelValue.foreground, t.pixelValue.background, 'O');
                }
                Vector2i size = body.GetSize();
                Vector2i middlePos = Vector2i.Divide(size, new Vector2i(2, 2));
                RemoveAt(middlePos, shape);
            }
        }
    };
}
