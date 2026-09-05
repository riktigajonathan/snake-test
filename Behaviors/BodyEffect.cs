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
        foreach (var body in bodies)
        {

        }
    };
}
