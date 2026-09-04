using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_test;

internal class BodyEffect
{
    public string effectName;
    public Action<List<Body>> action;

    public BodyEffect(string effectName, Action<List<Body>> action) 
    {
        this.effectName = effectName;
        this.action = action;
    }
}
