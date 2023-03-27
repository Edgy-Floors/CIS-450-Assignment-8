using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleEdgeSword : AbstractSword
{
    public override bool wantsFlexible()
    {
        return false;
    }
    public override void addEdge()
    {
    }

    public override void addFlexible()
    {
    }

    public override void addHandle(string handle)
    {
    }

    public override void heatMetal(string metal)
    {
    }
}
