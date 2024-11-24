using System;
using UnityEngine;

public class BadCarrot : Collectable
{

    public override void BadObj()
    {
        base.BadObj();
        Debug.Log("Killed");
    }


}
