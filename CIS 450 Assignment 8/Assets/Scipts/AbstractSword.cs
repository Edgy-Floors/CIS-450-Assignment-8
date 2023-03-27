using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSword : MonoBehaviour
{
    public void makeSword()
    {
        heatMetal(metal());

        if(wantsEdge())
        {
            addEdge();
        }
        
        if(wantsFlexible())
        {
            addFlexible();
        }

        addHandle(handle());
    }

    // Conditional functions
    public abstract void addEdge();
    public abstract void addFlexible();

    // Boolean Functions
    public virtual bool wantsEdge() { return true; }
    public virtual string metal() { return "iron"; }
    public virtual bool wantsFlexible() { return true; }
    public virtual string handle() { return "basic handle"; }

    // Nonconditional Functions
    public abstract void heatMetal(string metal);
    public abstract void addHandle(string handle);
}
