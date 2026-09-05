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
        void RemoveMiddle(Body b)
        {
            List<Tile> shape = b.GetShape();
            var size = b.GetSize();
            Vector2i middlePos = Vector2i.Divide(size, new Vector2i(2, 2));

            for (int i = 0; i < shape.Count-1; i++)
            {
                if (shape[i] == null) continue;

                if (Vector2i.Equals(shape[i].GetPos(), middlePos))
                {
                    shape[i].pixelValue = new PixelValue(shape[i].pixelValue.foreground, shape[i].pixelValue.background,'.');
                }
            }
        }

        foreach (Body b in bodies)
        {
            RemoveMiddle(b);
        }
        if (bodies.Count < 2) return;

        for (int i = 1; i < bodies.Count-1; i++)
        {
            
        }
    };
}
